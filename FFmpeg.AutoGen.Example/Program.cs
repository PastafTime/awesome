﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using FFmpeg.AutoGen.New;

namespace FFmpeg.AutoGen_.Example
{
    internal class Program
    {
        private static unsafe void Main(string[] args)
        {
            Console.WriteLine(@"Current directory: " + Environment.CurrentDirectory);
            Console.WriteLine(@"Runnung in {0}-bit mode.", Environment.Is64BitProcess ? @"64" : @"32");

            // register path to ffmpeg
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                    var ffmpegPath = $@"../../../../FFmpeg/bin/{(Environment.Is64BitProcess ? @"x64" : @"x86")}";
                    InteropHelper.RegisterLibrariesSearchPath(ffmpegPath);
                    break;
                case PlatformID.Unix:
                case PlatformID.MacOSX:
                    var libraryPath = Environment.GetEnvironmentVariable(InteropHelper.LD_LIBRARY_PATH);
                    InteropHelper.RegisterLibrariesSearchPath(libraryPath);
                    break;
            }

            // decode 100 frame from url or path

            //string url = @"../../sample_mpeg4.mp4";
            var url = @"http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4";

            ffmpeg.av_register_all();
            ffmpeg.avcodec_register_all();
            ffmpeg.avformat_network_init();
            
            Console.WriteLine($"FFmpeg version info: {ffmpeg.av_version_info()}");

            var pFormatContext = ffmpeg.avformat_alloc_context();

            if (ffmpeg.avformat_open_input(&pFormatContext, url, null, null) != 0)
            {
                throw new ApplicationException(@"Could not open file");
            }

            if (ffmpeg.avformat_find_stream_info(pFormatContext, null) != 0)
            {
                throw new ApplicationException(@"Could not find stream info");
            }

            AVStream* pStream = null;
            for (var i = 0; i < pFormatContext->nb_streams; i++)
            {
                if (pFormatContext->streams[i]->codec->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO)
                {
                    pStream = pFormatContext->streams[i];
                    break;
                }
            }
            if (pStream == null)
            {
                throw new ApplicationException(@"Could not found video stream");
            }


            var codecContext = *pStream->codec;
           
            Console.WriteLine($"codec name: { ffmpeg.avcodec_get_name(codecContext.codec_id)}");
            
            var width = codecContext.width;
            var height = codecContext.height;
            var sourcePixFmt = codecContext.pix_fmt;
            var codecId = codecContext.codec_id;
            var convertToPixFmt = AVPixelFormat.AV_PIX_FMT_BGR24;
            var pConvertContext = ffmpeg.sws_getContext(width, height, sourcePixFmt,
                width, height, convertToPixFmt,
                ffmpeg.SWS_FAST_BILINEAR, null, null, null);
            if (pConvertContext == null)
            {
                throw new ApplicationException(@"Could not initialize the conversion context");
            }

            var pConvertedFrame = ffmpeg.av_frame_alloc();
            var convertedFrameBufferSize = ffmpeg.av_image_get_buffer_size(convertToPixFmt, width, height, 1);
            var pConvertedFrameBuffer = (byte*)ffmpeg.av_malloc((ulong)convertedFrameBufferSize);
            ffmpeg.avpicture_fill((AVPicture*)pConvertedFrame, pConvertedFrameBuffer, convertToPixFmt, width, height);

            var pCodec = ffmpeg.avcodec_find_decoder(codecId);
            if (pCodec == null)
            {
                throw new ApplicationException(@"Unsupported codec");
            }

            // Reusing codec context from stream info, initally it was looking like this: 
            // AVCodecContext* pCodecContext = ffmpeg.avcodec_alloc_context3(pCodec); // but it is not working for all kind of codecs
            var pCodecContext = &codecContext;
            
            //if ((pCodec->capabilities & ffmpeg.AV_CODEC_CAP_TRUNCATED) == ffmpeg.AV_CODEC_CAP_TRUNCATED)
            //{
            //    pCodecContext->flags |= ffmpeg.AV_CODEC_FLAG_TRUNCATED;
            //}

            if (ffmpeg.avcodec_open2(pCodecContext, pCodec, null) < 0)
            {
                throw new ApplicationException(@"Could not open codec");
            }

            var pDecodedFrame = ffmpeg.av_frame_alloc();

            var packet = new AVPacket();
            var pPacket = &packet;
            ffmpeg.av_init_packet(pPacket);

            var frameNumber = 0;
            while (frameNumber < 1400)
            {
                if (ffmpeg.av_read_frame(pFormatContext, pPacket) < 0)
                {
                    ffmpeg.av_packet_unref(pPacket);
                    ffmpeg.av_frame_unref(pDecodedFrame);

                    throw new ApplicationException(@"Could not read frame");
                }

                if (pPacket->stream_index != pStream->index)
                {
                    continue;
                }

                if (ffmpeg.avcodec_send_packet(pCodecContext, pPacket) < 0)
                {
                    ffmpeg.av_packet_unref(pPacket);
                    ffmpeg.av_frame_unref(pDecodedFrame);

                    throw new ApplicationException($@"Error while sending packet {frameNumber}");
                }

                if (ffmpeg.avcodec_receive_frame(pCodecContext, pDecodedFrame) < 0)
                {
                    ffmpeg.av_frame_unref(pDecodedFrame);
                    throw new ApplicationException($@"Error while receiving frame {frameNumber}");
                }

                ffmpeg.av_packet_unref(pPacket);

                Console.WriteLine($@"frame: {frameNumber}");


                //var data = new byte[pDecodedFrame->linesize0 * pDecodedFrame->height];
                //for (int i = 0; i < data.Length; i++)
                //{
                //     data[i] = *(pDecodedFrame->data0 + i);
                //}

                byte*[] src = {pDecodedFrame->data0, pDecodedFrame->data1, pDecodedFrame->data2};
                var srcStride = new[] { pDecodedFrame->linesize[0], pDecodedFrame->linesize[1], pDecodedFrame->linesize[2] };
                byte*[] dst = {pConvertedFrame->data0};
                var dstStride = new[]{ pConvertedFrame->linesize[0] };
                ffmpeg.sws_scale(pConvertContext, src, srcStride, 0, height, dst, dstStride);

                var convertedFrameAddress = pConvertedFrame->data0;

                var imageBufferPtr = new IntPtr(convertedFrameAddress);

                var linesize = dstStride[0];
                using (var bitmap = new Bitmap(width, height, linesize, PixelFormat.Format24bppRgb, imageBufferPtr))
                {
                    bitmap.Save(@"frame.buffer.jpg", ImageFormat.Jpeg);
                }

                ffmpeg.av_frame_unref(pDecodedFrame);
                frameNumber++;
            }

            ffmpeg.av_free(pConvertedFrame);
            ffmpeg.av_free(pConvertedFrameBuffer);
            ffmpeg.sws_freeContext(pConvertContext);

            ffmpeg.av_free(pDecodedFrame);
            ffmpeg.avcodec_close(pCodecContext);
            ffmpeg.avformat_close_input(&pFormatContext);
        }
    }
}