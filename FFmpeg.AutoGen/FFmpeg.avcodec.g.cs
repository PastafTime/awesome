using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    public unsafe partial struct AVOptionRanges
    {
    }
    
    public unsafe partial struct AVBuffer
    {
    }
    
    public unsafe partial struct AVBufferPool
    {
    }
    
    public unsafe partial struct AVBPrint
    {
    }
    
    public unsafe partial struct AVDictionary
    {
    }
    
    public unsafe partial struct AVCodecDescriptor
    {
        public AVCodecID @id;
        public AVMediaType @type;
        public sbyte* @name;
        public sbyte* @long_name;
        public int @props;
        public sbyte** @mime_types;
    }
    
    public unsafe partial struct RcOverride
    {
        public int @start_frame;
        public int @end_frame;
        public int @qscale;
        public float @quality_factor;
    }
    
    public unsafe partial struct AVPanScan
    {
        public int @id;
        public int @width;
        public int @height;
        public fixed short @position0[2]; public fixed short @position1[2]; public fixed short @position2[2]; 
    }
    
    public unsafe partial struct AVPacketSideData
    {
        public sbyte* @data;
        public int @size;
        public AVPacketSideDataType @type;
    }
    
    public unsafe partial struct AVPacket
    {
        public AVBufferRef* @buf;
        public long @pts;
        public long @dts;
        public sbyte* @data;
        public int @size;
        public int @stream_index;
        public int @flags;
        public AVPacketSideData* @side_data;
        public int @side_data_elems;
        public int @duration;
        public IntPtr @destruct;
        public void* @priv;
        public long @pos;
        public long @convergence_duration;
    }
    
    public unsafe partial struct AVCodecInternal
    {
    }
    
    public unsafe partial struct AVCodecContext
    {
        public AVClass* @av_class;
        public int @log_level_offset;
        public AVMediaType @codec_type;
        public AVCodec* @codec;
        public fixed sbyte @codec_name[32]; 
        public AVCodecID @codec_id;
        public uint @codec_tag;
        public uint @stream_codec_tag;
        public void* @priv_data;
        public AVCodecInternal* @internal;
        public void* @opaque;
        public int @bit_rate;
        public int @bit_rate_tolerance;
        public int @global_quality;
        public int @compression_level;
        public int @flags;
        public int @flags2;
        public sbyte* @extradata;
        public int @extradata_size;
        public AVRational @time_base;
        public int @ticks_per_frame;
        public int @delay;
        public int @width;
        public int @height;
        public int @coded_width;
        public int @coded_height;
        public int @gop_size;
        public AVPixelFormat @pix_fmt;
        public int @me_method;
        public IntPtr @draw_horiz_band;
        public IntPtr @get_format;
        public int @max_b_frames;
        public float @b_quant_factor;
        public int @rc_strategy;
        public int @b_frame_strategy;
        public float @b_quant_offset;
        public int @has_b_frames;
        public int @mpeg_quant;
        public float @i_quant_factor;
        public float @i_quant_offset;
        public float @lumi_masking;
        public float @temporal_cplx_masking;
        public float @spatial_cplx_masking;
        public float @p_masking;
        public float @dark_masking;
        public int @slice_count;
        public int @prediction_method;
        public int* @slice_offset;
        public AVRational @sample_aspect_ratio;
        public int @me_cmp;
        public int @me_sub_cmp;
        public int @mb_cmp;
        public int @ildct_cmp;
        public int @dia_size;
        public int @last_predictor_count;
        public int @pre_me;
        public int @me_pre_cmp;
        public int @pre_dia_size;
        public int @me_subpel_quality;
        public int @dtg_active_format;
        public int @me_range;
        public int @intra_quant_bias;
        public int @inter_quant_bias;
        public int @slice_flags;
        public int @xvmc_acceleration;
        public int @mb_decision;
        public ushort* @intra_matrix;
        public ushort* @inter_matrix;
        public int @scenechange_threshold;
        public int @noise_reduction;
        public int @me_threshold;
        public int @mb_threshold;
        public int @intra_dc_precision;
        public int @skip_top;
        public int @skip_bottom;
        public float @border_masking;
        public int @mb_lmin;
        public int @mb_lmax;
        public int @me_penalty_compensation;
        public int @bidir_refine;
        public int @brd_scale;
        public int @keyint_min;
        public int @refs;
        public int @chromaoffset;
        public int @scenechange_factor;
        public int @mv0_threshold;
        public int @b_sensitivity;
        public AVColorPrimaries @color_primaries;
        public AVColorTransferCharacteristic @color_trc;
        public AVColorSpace @colorspace;
        public AVColorRange @color_range;
        public AVChromaLocation @chroma_sample_location;
        public int @slices;
        public AVFieldOrder @field_order;
        public int @sample_rate;
        public int @channels;
        public AVSampleFormat @sample_fmt;
        public int @frame_size;
        public int @frame_number;
        public int @block_align;
        public int @cutoff;
        public int @request_channels;
        public ulong @channel_layout;
        public ulong @request_channel_layout;
        public AVAudioServiceType @audio_service_type;
        public AVSampleFormat @request_sample_fmt;
        public IntPtr @get_buffer;
        public IntPtr @release_buffer;
        public IntPtr @reget_buffer;
        public IntPtr @get_buffer2;
        public int @refcounted_frames;
        public float @qcompress;
        public float @qblur;
        public int @qmin;
        public int @qmax;
        public int @max_qdiff;
        public float @rc_qsquish;
        public float @rc_qmod_amp;
        public int @rc_qmod_freq;
        public int @rc_buffer_size;
        public int @rc_override_count;
        public RcOverride* @rc_override;
        public sbyte* @rc_eq;
        public int @rc_max_rate;
        public int @rc_min_rate;
        public float @rc_buffer_aggressivity;
        public float @rc_initial_cplx;
        public float @rc_max_available_vbv_use;
        public float @rc_min_vbv_overflow_use;
        public int @rc_initial_buffer_occupancy;
        public int @coder_type;
        public int @context_model;
        public int @lmin;
        public int @lmax;
        public int @frame_skip_threshold;
        public int @frame_skip_factor;
        public int @frame_skip_exp;
        public int @frame_skip_cmp;
        public int @trellis;
        public int @min_prediction_order;
        public int @max_prediction_order;
        public long @timecode_frame_start;
        public IntPtr @rtp_callback;
        public int @rtp_payload_size;
        public int @mv_bits;
        public int @header_bits;
        public int @i_tex_bits;
        public int @p_tex_bits;
        public int @i_count;
        public int @p_count;
        public int @skip_count;
        public int @misc_bits;
        public int @frame_bits;
        public sbyte* @stats_out;
        public sbyte* @stats_in;
        public int @workaround_bugs;
        public int @strict_std_compliance;
        public int @error_concealment;
        public int @debug;
        public int @debug_mv;
        public int @err_recognition;
        public long @reordered_opaque;
        public AVHWAccel* @hwaccel;
        public void* @hwaccel_context;
        public fixed ulong @error[8]; 
        public int @dct_algo;
        public int @idct_algo;
        public int @bits_per_coded_sample;
        public int @bits_per_raw_sample;
        public int @lowres;
        public AVFrame* @coded_frame;
        public int @thread_count;
        public int @thread_type;
        public int @active_thread_type;
        public int @thread_safe_callbacks;
        public IntPtr @execute;
        public IntPtr @execute2;
        public void* @thread_opaque;
        public int @nsse_weight;
        public int @profile;
        public int @level;
        public AVDiscard @skip_loop_filter;
        public AVDiscard @skip_idct;
        public AVDiscard @skip_frame;
        public sbyte* @subtitle_header;
        public int @subtitle_header_size;
        public int @error_rate;
        public AVPacket* @pkt;
        public ulong @vbv_delay;
        public int @side_data_only_packets;
        public int @initial_padding;
        public AVRational @framerate;
        public AVPixelFormat @sw_pix_fmt;
        public AVRational @pkt_timebase;
        public AVCodecDescriptor* @codec_descriptor;
        public long @pts_correction_num_faulty_pts;
        public long @pts_correction_num_faulty_dts;
        public long @pts_correction_last_pts;
        public long @pts_correction_last_dts;
        public sbyte* @sub_charenc;
        public int @sub_charenc_mode;
        public int @skip_alpha;
        public int @seek_preroll;
        public ushort* @chroma_intra_matrix;
        public sbyte* @dump_separator;
        public sbyte* @codec_whitelist;
        public uint @properties;
    }
    
    public unsafe partial struct AVHWAccel
    {
    }
    
    public unsafe partial struct AVCodec
    {
    }
    
    public unsafe partial struct AVProfile
    {
        public int @profile;
        public sbyte* @name;
    }
    
    public unsafe partial struct AVCodecDefault
    {
    }
    
    public unsafe partial struct AVSubtitle
    {
    }
    
    public unsafe partial struct AVCodec
    {
        public sbyte* @name;
        public sbyte* @long_name;
        public AVMediaType @type;
        public AVCodecID @id;
        public int @capabilities;
        public AVRational* @supported_framerates;
        public AVPixelFormat* @pix_fmts;
        public int* @supported_samplerates;
        public AVSampleFormat* @sample_fmts;
        public ulong* @channel_layouts;
        public sbyte @max_lowres;
        public AVClass* @priv_class;
        public AVProfile* @profiles;
        public int @priv_data_size;
        public AVCodec* @next;
        public IntPtr @init_thread_copy;
        public IntPtr @update_thread_context;
        public AVCodecDefault* @defaults;
        public IntPtr @init_static_data;
        public IntPtr @init;
        public IntPtr @encode_sub;
        public IntPtr @encode2;
        public IntPtr @decode;
        public IntPtr @close;
        public IntPtr @flush;
        public int @caps_internal;
    }
    
    public unsafe partial struct MpegEncContext
    {
    }
    
    public unsafe partial struct AVHWAccel
    {
        public sbyte* @name;
        public AVMediaType @type;
        public AVCodecID @id;
        public AVPixelFormat @pix_fmt;
        public int @capabilities;
        public AVHWAccel* @next;
        public IntPtr @alloc_frame;
        public IntPtr @start_frame;
        public IntPtr @decode_slice;
        public IntPtr @end_frame;
        public int @frame_priv_data_size;
        public IntPtr @decode_mb;
        public IntPtr @init;
        public IntPtr @uninit;
        public int @priv_data_size;
    }
    
    public unsafe partial struct AVPicture
    {
        public sbyte* @data0; public sbyte* @data1; public sbyte* @data2; public sbyte* @data3; public sbyte* @data4; public sbyte* @data5; public sbyte* @data6; public sbyte* @data7; 
        public fixed int @linesize[8]; 
    }
    
    public unsafe partial struct AVSubtitleRect
    {
        public int @x;
        public int @y;
        public int @w;
        public int @h;
        public int @nb_colors;
        public AVPicture @pict;
        public AVSubtitleType @type;
        public sbyte* @text;
        public sbyte* @ass;
        public int @flags;
    }
    
    public unsafe partial struct AVSubtitle
    {
        public ushort @format;
        public uint @start_display_time;
        public uint @end_display_time;
        public uint @num_rects;
        public AVSubtitleRect** @rects;
        public long @pts;
    }
    
    public unsafe partial struct AVCodecParserContext
    {
        public void* @priv_data;
        public AVCodecParser* @parser;
        public long @frame_offset;
        public long @cur_offset;
        public long @next_frame_offset;
        public int @pict_type;
        public int @repeat_pict;
        public long @pts;
        public long @dts;
        public long @last_pts;
        public long @last_dts;
        public int @fetch_timestamp;
        public int @cur_frame_start_index;
        public fixed long @cur_frame_offset[4]; 
        public fixed long @cur_frame_pts[4]; 
        public fixed long @cur_frame_dts[4]; 
        public int @flags;
        public long @offset;
        public fixed long @cur_frame_end[4]; 
        public int @key_frame;
        public long @convergence_duration;
        public int @dts_sync_point;
        public int @dts_ref_dts_delta;
        public int @pts_dts_delta;
        public fixed long @cur_frame_pos[4]; 
        public long @pos;
        public long @last_pos;
        public int @duration;
        public AVFieldOrder @field_order;
        public AVPictureStructure @picture_structure;
        public int @output_picture_number;
        public int @width;
        public int @height;
        public int @coded_width;
        public int @coded_height;
        public int @format;
    }
    
    public unsafe partial struct AVCodecParser
    {
    }
    
    public unsafe partial struct AVCodecParser
    {
        public fixed int @codec_ids[5]; 
        public int @priv_data_size;
        public IntPtr @parser_init;
        public IntPtr @parser_parse;
        public IntPtr @parser_close;
        public IntPtr @split;
        public AVCodecParser* @next;
    }
    
    public unsafe partial struct ReSampleContext
    {
    }
    
    public unsafe partial struct AVResampleContext
    {
    }
    
    public unsafe partial struct AVBitStreamFilterContext
    {
        public void* @priv_data;
        public AVBitStreamFilter* @filter;
        public AVCodecParserContext* @parser;
        public AVBitStreamFilterContext* @next;
    }
    
    public unsafe partial struct AVBitStreamFilter
    {
    }
    
    public unsafe partial struct AVBitStreamFilter
    {
        public sbyte* @name;
        public int @priv_data_size;
        public IntPtr @filter;
        public IntPtr @close;
        public AVBitStreamFilter* @next;
    }
    
    public enum AVMatrixEncoding : int
    {
        @AV_MATRIX_ENCODING_NONE = 0,
        @AV_MATRIX_ENCODING_DOLBY = 1,
        @AV_MATRIX_ENCODING_DPLII = 2,
        @AV_MATRIX_ENCODING_DPLIIX = 3,
        @AV_MATRIX_ENCODING_DPLIIZ = 4,
        @AV_MATRIX_ENCODING_DOLBYEX = 5,
        @AV_MATRIX_ENCODING_DOLBYHEADPHONE = 6,
        @AV_MATRIX_ENCODING_NB = 7,
    }
    
    public enum AVCodecID : int
    {
        @AV_CODEC_ID_NONE = 0,
        @AV_CODEC_ID_MPEG1VIDEO = 1,
        @AV_CODEC_ID_MPEG2VIDEO = 2,
        @AV_CODEC_ID_MPEG2VIDEO_XVMC = 3,
        @AV_CODEC_ID_H261 = 4,
        @AV_CODEC_ID_H263 = 5,
        @AV_CODEC_ID_RV10 = 6,
        @AV_CODEC_ID_RV20 = 7,
        @AV_CODEC_ID_MJPEG = 8,
        @AV_CODEC_ID_MJPEGB = 9,
        @AV_CODEC_ID_LJPEG = 10,
        @AV_CODEC_ID_SP5X = 11,
        @AV_CODEC_ID_JPEGLS = 12,
        @AV_CODEC_ID_MPEG4 = 13,
        @AV_CODEC_ID_RAWVIDEO = 14,
        @AV_CODEC_ID_MSMPEG4V1 = 15,
        @AV_CODEC_ID_MSMPEG4V2 = 16,
        @AV_CODEC_ID_MSMPEG4V3 = 17,
        @AV_CODEC_ID_WMV1 = 18,
        @AV_CODEC_ID_WMV2 = 19,
        @AV_CODEC_ID_H263P = 20,
        @AV_CODEC_ID_H263I = 21,
        @AV_CODEC_ID_FLV1 = 22,
        @AV_CODEC_ID_SVQ1 = 23,
        @AV_CODEC_ID_SVQ3 = 24,
        @AV_CODEC_ID_DVVIDEO = 25,
        @AV_CODEC_ID_HUFFYUV = 26,
        @AV_CODEC_ID_CYUV = 27,
        @AV_CODEC_ID_H264 = 28,
        @AV_CODEC_ID_INDEO3 = 29,
        @AV_CODEC_ID_VP3 = 30,
        @AV_CODEC_ID_THEORA = 31,
        @AV_CODEC_ID_ASV1 = 32,
        @AV_CODEC_ID_ASV2 = 33,
        @AV_CODEC_ID_FFV1 = 34,
        @AV_CODEC_ID_4XM = 35,
        @AV_CODEC_ID_VCR1 = 36,
        @AV_CODEC_ID_CLJR = 37,
        @AV_CODEC_ID_MDEC = 38,
        @AV_CODEC_ID_ROQ = 39,
        @AV_CODEC_ID_INTERPLAY_VIDEO = 40,
        @AV_CODEC_ID_XAN_WC3 = 41,
        @AV_CODEC_ID_XAN_WC4 = 42,
        @AV_CODEC_ID_RPZA = 43,
        @AV_CODEC_ID_CINEPAK = 44,
        @AV_CODEC_ID_WS_VQA = 45,
        @AV_CODEC_ID_MSRLE = 46,
        @AV_CODEC_ID_MSVIDEO1 = 47,
        @AV_CODEC_ID_IDCIN = 48,
        @AV_CODEC_ID_8BPS = 49,
        @AV_CODEC_ID_SMC = 50,
        @AV_CODEC_ID_FLIC = 51,
        @AV_CODEC_ID_TRUEMOTION1 = 52,
        @AV_CODEC_ID_VMDVIDEO = 53,
        @AV_CODEC_ID_MSZH = 54,
        @AV_CODEC_ID_ZLIB = 55,
        @AV_CODEC_ID_QTRLE = 56,
        @AV_CODEC_ID_TSCC = 57,
        @AV_CODEC_ID_ULTI = 58,
        @AV_CODEC_ID_QDRAW = 59,
        @AV_CODEC_ID_VIXL = 60,
        @AV_CODEC_ID_QPEG = 61,
        @AV_CODEC_ID_PNG = 62,
        @AV_CODEC_ID_PPM = 63,
        @AV_CODEC_ID_PBM = 64,
        @AV_CODEC_ID_PGM = 65,
        @AV_CODEC_ID_PGMYUV = 66,
        @AV_CODEC_ID_PAM = 67,
        @AV_CODEC_ID_FFVHUFF = 68,
        @AV_CODEC_ID_RV30 = 69,
        @AV_CODEC_ID_RV40 = 70,
        @AV_CODEC_ID_VC1 = 71,
        @AV_CODEC_ID_WMV3 = 72,
        @AV_CODEC_ID_LOCO = 73,
        @AV_CODEC_ID_WNV1 = 74,
        @AV_CODEC_ID_AASC = 75,
        @AV_CODEC_ID_INDEO2 = 76,
        @AV_CODEC_ID_FRAPS = 77,
        @AV_CODEC_ID_TRUEMOTION2 = 78,
        @AV_CODEC_ID_BMP = 79,
        @AV_CODEC_ID_CSCD = 80,
        @AV_CODEC_ID_MMVIDEO = 81,
        @AV_CODEC_ID_ZMBV = 82,
        @AV_CODEC_ID_AVS = 83,
        @AV_CODEC_ID_SMACKVIDEO = 84,
        @AV_CODEC_ID_NUV = 85,
        @AV_CODEC_ID_KMVC = 86,
        @AV_CODEC_ID_FLASHSV = 87,
        @AV_CODEC_ID_CAVS = 88,
        @AV_CODEC_ID_JPEG2000 = 89,
        @AV_CODEC_ID_VMNC = 90,
        @AV_CODEC_ID_VP5 = 91,
        @AV_CODEC_ID_VP6 = 92,
        @AV_CODEC_ID_VP6F = 93,
        @AV_CODEC_ID_TARGA = 94,
        @AV_CODEC_ID_DSICINVIDEO = 95,
        @AV_CODEC_ID_TIERTEXSEQVIDEO = 96,
        @AV_CODEC_ID_TIFF = 97,
        @AV_CODEC_ID_GIF = 98,
        @AV_CODEC_ID_DXA = 99,
        @AV_CODEC_ID_DNXHD = 100,
        @AV_CODEC_ID_THP = 101,
        @AV_CODEC_ID_SGI = 102,
        @AV_CODEC_ID_C93 = 103,
        @AV_CODEC_ID_BETHSOFTVID = 104,
        @AV_CODEC_ID_PTX = 105,
        @AV_CODEC_ID_TXD = 106,
        @AV_CODEC_ID_VP6A = 107,
        @AV_CODEC_ID_AMV = 108,
        @AV_CODEC_ID_VB = 109,
        @AV_CODEC_ID_PCX = 110,
        @AV_CODEC_ID_SUNRAST = 111,
        @AV_CODEC_ID_INDEO4 = 112,
        @AV_CODEC_ID_INDEO5 = 113,
        @AV_CODEC_ID_MIMIC = 114,
        @AV_CODEC_ID_RL2 = 115,
        @AV_CODEC_ID_ESCAPE124 = 116,
        @AV_CODEC_ID_DIRAC = 117,
        @AV_CODEC_ID_BFI = 118,
        @AV_CODEC_ID_CMV = 119,
        @AV_CODEC_ID_MOTIONPIXELS = 120,
        @AV_CODEC_ID_TGV = 121,
        @AV_CODEC_ID_TGQ = 122,
        @AV_CODEC_ID_TQI = 123,
        @AV_CODEC_ID_AURA = 124,
        @AV_CODEC_ID_AURA2 = 125,
        @AV_CODEC_ID_V210X = 126,
        @AV_CODEC_ID_TMV = 127,
        @AV_CODEC_ID_V210 = 128,
        @AV_CODEC_ID_DPX = 129,
        @AV_CODEC_ID_MAD = 130,
        @AV_CODEC_ID_FRWU = 131,
        @AV_CODEC_ID_FLASHSV2 = 132,
        @AV_CODEC_ID_CDGRAPHICS = 133,
        @AV_CODEC_ID_R210 = 134,
        @AV_CODEC_ID_ANM = 135,
        @AV_CODEC_ID_BINKVIDEO = 136,
        @AV_CODEC_ID_IFF_ILBM = 137,
        @AV_CODEC_ID_IFF_BYTERUN1 = 138,
        @AV_CODEC_ID_KGV1 = 139,
        @AV_CODEC_ID_YOP = 140,
        @AV_CODEC_ID_VP8 = 141,
        @AV_CODEC_ID_PICTOR = 142,
        @AV_CODEC_ID_ANSI = 143,
        @AV_CODEC_ID_A64_MULTI = 144,
        @AV_CODEC_ID_A64_MULTI5 = 145,
        @AV_CODEC_ID_R10K = 146,
        @AV_CODEC_ID_MXPEG = 147,
        @AV_CODEC_ID_LAGARITH = 148,
        @AV_CODEC_ID_PRORES = 149,
        @AV_CODEC_ID_JV = 150,
        @AV_CODEC_ID_DFA = 151,
        @AV_CODEC_ID_WMV3IMAGE = 152,
        @AV_CODEC_ID_VC1IMAGE = 153,
        @AV_CODEC_ID_UTVIDEO = 154,
        @AV_CODEC_ID_BMV_VIDEO = 155,
        @AV_CODEC_ID_VBLE = 156,
        @AV_CODEC_ID_DXTORY = 157,
        @AV_CODEC_ID_V410 = 158,
        @AV_CODEC_ID_XWD = 159,
        @AV_CODEC_ID_CDXL = 160,
        @AV_CODEC_ID_XBM = 161,
        @AV_CODEC_ID_ZEROCODEC = 162,
        @AV_CODEC_ID_MSS1 = 163,
        @AV_CODEC_ID_MSA1 = 164,
        @AV_CODEC_ID_TSCC2 = 165,
        @AV_CODEC_ID_MTS2 = 166,
        @AV_CODEC_ID_CLLC = 167,
        @AV_CODEC_ID_MSS2 = 168,
        @AV_CODEC_ID_VP9 = 169,
        @AV_CODEC_ID_AIC = 170,
        @AV_CODEC_ID_ESCAPE130_DEPRECATED = 171,
        @AV_CODEC_ID_G2M_DEPRECATED = 172,
        @AV_CODEC_ID_WEBP_DEPRECATED = 173,
        @AV_CODEC_ID_HNM4_VIDEO = 174,
        @AV_CODEC_ID_HEVC_DEPRECATED = 175,
        @AV_CODEC_ID_FIC = 176,
        @AV_CODEC_ID_ALIAS_PIX = 177,
        @AV_CODEC_ID_BRENDER_PIX_DEPRECATED = 178,
        @AV_CODEC_ID_PAF_VIDEO_DEPRECATED = 179,
        @AV_CODEC_ID_EXR_DEPRECATED = 180,
        @AV_CODEC_ID_VP7_DEPRECATED = 181,
        @AV_CODEC_ID_SANM_DEPRECATED = 182,
        @AV_CODEC_ID_SGIRLE_DEPRECATED = 183,
        @AV_CODEC_ID_MVC1_DEPRECATED = 184,
        @AV_CODEC_ID_MVC2_DEPRECATED = 185,
        @AV_CODEC_ID_HQX = 186,
        @AV_CODEC_ID_TDSC = 187,
        @AV_CODEC_ID_HQ_HQA = 188,
        @AV_CODEC_ID_HAP = 189,
        @AV_CODEC_ID_DDS = 190,
        @AV_CODEC_ID_BRENDER_PIX = 1112557912,
        @AV_CODEC_ID_Y41P = 1496592720,
        @AV_CODEC_ID_ESCAPE130 = 1160852272,
        @AV_CODEC_ID_EXR = 809850962,
        @AV_CODEC_ID_AVRP = 1096176208,
        @AV_CODEC_ID_012V = 808530518,
        @AV_CODEC_ID_G2M = 4665933,
        @AV_CODEC_ID_AVUI = 1096176969,
        @AV_CODEC_ID_AYUV = 1096373590,
        @AV_CODEC_ID_TARGA_Y216 = 1412575542,
        @AV_CODEC_ID_V308 = 1446195256,
        @AV_CODEC_ID_V408 = 1446260792,
        @AV_CODEC_ID_YUV4 = 1498764852,
        @AV_CODEC_ID_SANM = 1396788813,
        @AV_CODEC_ID_PAF_VIDEO = 1346455126,
        @AV_CODEC_ID_AVRN = 1096176238,
        @AV_CODEC_ID_CPIA = 1129335105,
        @AV_CODEC_ID_XFACE = 1480999235,
        @AV_CODEC_ID_SGIRLE = 1397180754,
        @AV_CODEC_ID_MVC1 = 1297498929,
        @AV_CODEC_ID_MVC2 = 1297498930,
        @AV_CODEC_ID_SNOW = 1397641047,
        @AV_CODEC_ID_WEBP = 1464156752,
        @AV_CODEC_ID_SMVJPEG = 1397577290,
        @AV_CODEC_ID_HEVC = 1211250229,
        @AV_CODEC_ID_VP7 = 1448097584,
        @AV_CODEC_ID_APNG = 1095781959,
        @AV_CODEC_ID_FIRST_AUDIO = 65536,
        @AV_CODEC_ID_PCM_S16LE = 65536,
        @AV_CODEC_ID_PCM_S16BE = 65537,
        @AV_CODEC_ID_PCM_U16LE = 65538,
        @AV_CODEC_ID_PCM_U16BE = 65539,
        @AV_CODEC_ID_PCM_S8 = 65540,
        @AV_CODEC_ID_PCM_U8 = 65541,
        @AV_CODEC_ID_PCM_MULAW = 65542,
        @AV_CODEC_ID_PCM_ALAW = 65543,
        @AV_CODEC_ID_PCM_S32LE = 65544,
        @AV_CODEC_ID_PCM_S32BE = 65545,
        @AV_CODEC_ID_PCM_U32LE = 65546,
        @AV_CODEC_ID_PCM_U32BE = 65547,
        @AV_CODEC_ID_PCM_S24LE = 65548,
        @AV_CODEC_ID_PCM_S24BE = 65549,
        @AV_CODEC_ID_PCM_U24LE = 65550,
        @AV_CODEC_ID_PCM_U24BE = 65551,
        @AV_CODEC_ID_PCM_S24DAUD = 65552,
        @AV_CODEC_ID_PCM_ZORK = 65553,
        @AV_CODEC_ID_PCM_S16LE_PLANAR = 65554,
        @AV_CODEC_ID_PCM_DVD = 65555,
        @AV_CODEC_ID_PCM_F32BE = 65556,
        @AV_CODEC_ID_PCM_F32LE = 65557,
        @AV_CODEC_ID_PCM_F64BE = 65558,
        @AV_CODEC_ID_PCM_F64LE = 65559,
        @AV_CODEC_ID_PCM_BLURAY = 65560,
        @AV_CODEC_ID_PCM_LXF = 65561,
        @AV_CODEC_ID_S302M = 65562,
        @AV_CODEC_ID_PCM_S8_PLANAR = 65563,
        @AV_CODEC_ID_PCM_S24LE_PLANAR_DEPRECATED = 65564,
        @AV_CODEC_ID_PCM_S32LE_PLANAR_DEPRECATED = 65565,
        @AV_CODEC_ID_PCM_S16BE_PLANAR_DEPRECATED = 65566,
        @AV_CODEC_ID_PCM_S24LE_PLANAR = 407917392,
        @AV_CODEC_ID_PCM_S32LE_PLANAR = 542135120,
        @AV_CODEC_ID_PCM_S16BE_PLANAR = 1347637264,
        @AV_CODEC_ID_ADPCM_IMA_QT = 69632,
        @AV_CODEC_ID_ADPCM_IMA_WAV = 69633,
        @AV_CODEC_ID_ADPCM_IMA_DK3 = 69634,
        @AV_CODEC_ID_ADPCM_IMA_DK4 = 69635,
        @AV_CODEC_ID_ADPCM_IMA_WS = 69636,
        @AV_CODEC_ID_ADPCM_IMA_SMJPEG = 69637,
        @AV_CODEC_ID_ADPCM_MS = 69638,
        @AV_CODEC_ID_ADPCM_4XM = 69639,
        @AV_CODEC_ID_ADPCM_XA = 69640,
        @AV_CODEC_ID_ADPCM_ADX = 69641,
        @AV_CODEC_ID_ADPCM_EA = 69642,
        @AV_CODEC_ID_ADPCM_G726 = 69643,
        @AV_CODEC_ID_ADPCM_CT = 69644,
        @AV_CODEC_ID_ADPCM_SWF = 69645,
        @AV_CODEC_ID_ADPCM_YAMAHA = 69646,
        @AV_CODEC_ID_ADPCM_SBPRO_4 = 69647,
        @AV_CODEC_ID_ADPCM_SBPRO_3 = 69648,
        @AV_CODEC_ID_ADPCM_SBPRO_2 = 69649,
        @AV_CODEC_ID_ADPCM_THP = 69650,
        @AV_CODEC_ID_ADPCM_IMA_AMV = 69651,
        @AV_CODEC_ID_ADPCM_EA_R1 = 69652,
        @AV_CODEC_ID_ADPCM_EA_R3 = 69653,
        @AV_CODEC_ID_ADPCM_EA_R2 = 69654,
        @AV_CODEC_ID_ADPCM_IMA_EA_SEAD = 69655,
        @AV_CODEC_ID_ADPCM_IMA_EA_EACS = 69656,
        @AV_CODEC_ID_ADPCM_EA_XAS = 69657,
        @AV_CODEC_ID_ADPCM_EA_MAXIS_XA = 69658,
        @AV_CODEC_ID_ADPCM_IMA_ISS = 69659,
        @AV_CODEC_ID_ADPCM_G722 = 69660,
        @AV_CODEC_ID_ADPCM_IMA_APC = 69661,
        @AV_CODEC_ID_ADPCM_VIMA_DEPRECATED = 69662,
        @AV_CODEC_ID_ADPCM_VIMA = 1447644481,
        @AV_CODEC_ID_VIMA = 1447644481,
        @AV_CODEC_ID_ADPCM_AFC = 1095123744,
        @AV_CODEC_ID_ADPCM_IMA_OKI = 1330333984,
        @AV_CODEC_ID_ADPCM_DTK = 1146374944,
        @AV_CODEC_ID_ADPCM_IMA_RAD = 1380008992,
        @AV_CODEC_ID_ADPCM_G726LE = 909260615,
        @AV_CODEC_ID_ADPCM_THP_LE = 1414025292,
        @AV_CODEC_ID_AMR_NB = 73728,
        @AV_CODEC_ID_AMR_WB = 73729,
        @AV_CODEC_ID_RA_144 = 77824,
        @AV_CODEC_ID_RA_288 = 77825,
        @AV_CODEC_ID_ROQ_DPCM = 81920,
        @AV_CODEC_ID_INTERPLAY_DPCM = 81921,
        @AV_CODEC_ID_XAN_DPCM = 81922,
        @AV_CODEC_ID_SOL_DPCM = 81923,
        @AV_CODEC_ID_MP2 = 86016,
        @AV_CODEC_ID_MP3 = 86017,
        @AV_CODEC_ID_AAC = 86018,
        @AV_CODEC_ID_AC3 = 86019,
        @AV_CODEC_ID_DTS = 86020,
        @AV_CODEC_ID_VORBIS = 86021,
        @AV_CODEC_ID_DVAUDIO = 86022,
        @AV_CODEC_ID_WMAV1 = 86023,
        @AV_CODEC_ID_WMAV2 = 86024,
        @AV_CODEC_ID_MACE3 = 86025,
        @AV_CODEC_ID_MACE6 = 86026,
        @AV_CODEC_ID_VMDAUDIO = 86027,
        @AV_CODEC_ID_FLAC = 86028,
        @AV_CODEC_ID_MP3ADU = 86029,
        @AV_CODEC_ID_MP3ON4 = 86030,
        @AV_CODEC_ID_SHORTEN = 86031,
        @AV_CODEC_ID_ALAC = 86032,
        @AV_CODEC_ID_WESTWOOD_SND1 = 86033,
        @AV_CODEC_ID_GSM = 86034,
        @AV_CODEC_ID_QDM2 = 86035,
        @AV_CODEC_ID_COOK = 86036,
        @AV_CODEC_ID_TRUESPEECH = 86037,
        @AV_CODEC_ID_TTA = 86038,
        @AV_CODEC_ID_SMACKAUDIO = 86039,
        @AV_CODEC_ID_QCELP = 86040,
        @AV_CODEC_ID_WAVPACK = 86041,
        @AV_CODEC_ID_DSICINAUDIO = 86042,
        @AV_CODEC_ID_IMC = 86043,
        @AV_CODEC_ID_MUSEPACK7 = 86044,
        @AV_CODEC_ID_MLP = 86045,
        @AV_CODEC_ID_GSM_MS = 86046,
        @AV_CODEC_ID_ATRAC3 = 86047,
        @AV_CODEC_ID_VOXWARE = 86048,
        @AV_CODEC_ID_APE = 86049,
        @AV_CODEC_ID_NELLYMOSER = 86050,
        @AV_CODEC_ID_MUSEPACK8 = 86051,
        @AV_CODEC_ID_SPEEX = 86052,
        @AV_CODEC_ID_WMAVOICE = 86053,
        @AV_CODEC_ID_WMAPRO = 86054,
        @AV_CODEC_ID_WMALOSSLESS = 86055,
        @AV_CODEC_ID_ATRAC3P = 86056,
        @AV_CODEC_ID_EAC3 = 86057,
        @AV_CODEC_ID_SIPR = 86058,
        @AV_CODEC_ID_MP1 = 86059,
        @AV_CODEC_ID_TWINVQ = 86060,
        @AV_CODEC_ID_TRUEHD = 86061,
        @AV_CODEC_ID_MP4ALS = 86062,
        @AV_CODEC_ID_ATRAC1 = 86063,
        @AV_CODEC_ID_BINKAUDIO_RDFT = 86064,
        @AV_CODEC_ID_BINKAUDIO_DCT = 86065,
        @AV_CODEC_ID_AAC_LATM = 86066,
        @AV_CODEC_ID_QDMC = 86067,
        @AV_CODEC_ID_CELT = 86068,
        @AV_CODEC_ID_G723_1 = 86069,
        @AV_CODEC_ID_G729 = 86070,
        @AV_CODEC_ID_8SVX_EXP = 86071,
        @AV_CODEC_ID_8SVX_FIB = 86072,
        @AV_CODEC_ID_BMV_AUDIO = 86073,
        @AV_CODEC_ID_RALF = 86074,
        @AV_CODEC_ID_IAC = 86075,
        @AV_CODEC_ID_ILBC = 86076,
        @AV_CODEC_ID_OPUS_DEPRECATED = 86077,
        @AV_CODEC_ID_COMFORT_NOISE = 86078,
        @AV_CODEC_ID_TAK_DEPRECATED = 86079,
        @AV_CODEC_ID_METASOUND = 86080,
        @AV_CODEC_ID_PAF_AUDIO_DEPRECATED = 86081,
        @AV_CODEC_ID_ON2AVC = 86082,
        @AV_CODEC_ID_DSS_SP = 86083,
        @AV_CODEC_ID_FFWAVESYNTH = 1179014995,
        @AV_CODEC_ID_SONIC = 1397706307,
        @AV_CODEC_ID_SONIC_LS = 1397706316,
        @AV_CODEC_ID_PAF_AUDIO = 1346455105,
        @AV_CODEC_ID_OPUS = 1330664787,
        @AV_CODEC_ID_TAK = 1950507339,
        @AV_CODEC_ID_EVRC = 1936029283,
        @AV_CODEC_ID_SMV = 1936944502,
        @AV_CODEC_ID_DSD_LSBF = 1146307660,
        @AV_CODEC_ID_DSD_MSBF = 1146307661,
        @AV_CODEC_ID_DSD_LSBF_PLANAR = 1146307633,
        @AV_CODEC_ID_DSD_MSBF_PLANAR = 1146307640,
        @AV_CODEC_ID_4GV = 1932814198,
        @AV_CODEC_ID_FIRST_SUBTITLE = 94208,
        @AV_CODEC_ID_DVD_SUBTITLE = 94208,
        @AV_CODEC_ID_DVB_SUBTITLE = 94209,
        @AV_CODEC_ID_TEXT = 94210,
        @AV_CODEC_ID_XSUB = 94211,
        @AV_CODEC_ID_SSA = 94212,
        @AV_CODEC_ID_MOV_TEXT = 94213,
        @AV_CODEC_ID_HDMV_PGS_SUBTITLE = 94214,
        @AV_CODEC_ID_DVB_TELETEXT = 94215,
        @AV_CODEC_ID_SRT = 94216,
        @AV_CODEC_ID_MICRODVD = 1833195076,
        @AV_CODEC_ID_EIA_608 = 1664495672,
        @AV_CODEC_ID_JACOSUB = 1246975298,
        @AV_CODEC_ID_SAMI = 1396788553,
        @AV_CODEC_ID_REALTEXT = 1381259348,
        @AV_CODEC_ID_STL = 1399870540,
        @AV_CODEC_ID_SUBVIEWER1 = 1398953521,
        @AV_CODEC_ID_SUBVIEWER = 1400201814,
        @AV_CODEC_ID_SUBRIP = 1397909872,
        @AV_CODEC_ID_WEBVTT = 1465275476,
        @AV_CODEC_ID_MPL2 = 1297108018,
        @AV_CODEC_ID_VPLAYER = 1448111218,
        @AV_CODEC_ID_PJS = 1349012051,
        @AV_CODEC_ID_ASS = 1095979808,
        @AV_CODEC_ID_HDMV_TEXT_SUBTITLE = 1111774296,
        @AV_CODEC_ID_FIRST_UNKNOWN = 98304,
        @AV_CODEC_ID_TTF = 98304,
        @AV_CODEC_ID_BINTEXT = 1112823892,
        @AV_CODEC_ID_XBIN = 1480739150,
        @AV_CODEC_ID_IDF = 4801606,
        @AV_CODEC_ID_OTF = 5198918,
        @AV_CODEC_ID_SMPTE_KLV = 1263294017,
        @AV_CODEC_ID_DVD_NAV = 1145979222,
        @AV_CODEC_ID_TIMED_ID3 = 1414087731,
        @AV_CODEC_ID_BIN_DATA = 1145132097,
        @AV_CODEC_ID_PROBE = 102400,
        @AV_CODEC_ID_MPEG2TS = 131072,
        @AV_CODEC_ID_MPEG4SYSTEMS = 131073,
        @AV_CODEC_ID_FFMETADATA = 135168,
        @CODEC_ID_NONE = 0,
        @CODEC_ID_MPEG1VIDEO = 1,
        @CODEC_ID_MPEG2VIDEO = 2,
        @CODEC_ID_MPEG2VIDEO_XVMC = 3,
        @CODEC_ID_H261 = 4,
        @CODEC_ID_H263 = 5,
        @CODEC_ID_RV10 = 6,
        @CODEC_ID_RV20 = 7,
        @CODEC_ID_MJPEG = 8,
        @CODEC_ID_MJPEGB = 9,
        @CODEC_ID_LJPEG = 10,
        @CODEC_ID_SP5X = 11,
        @CODEC_ID_JPEGLS = 12,
        @CODEC_ID_MPEG4 = 13,
        @CODEC_ID_RAWVIDEO = 14,
        @CODEC_ID_MSMPEG4V1 = 15,
        @CODEC_ID_MSMPEG4V2 = 16,
        @CODEC_ID_MSMPEG4V3 = 17,
        @CODEC_ID_WMV1 = 18,
        @CODEC_ID_WMV2 = 19,
        @CODEC_ID_H263P = 20,
        @CODEC_ID_H263I = 21,
        @CODEC_ID_FLV1 = 22,
        @CODEC_ID_SVQ1 = 23,
        @CODEC_ID_SVQ3 = 24,
        @CODEC_ID_DVVIDEO = 25,
        @CODEC_ID_HUFFYUV = 26,
        @CODEC_ID_CYUV = 27,
        @CODEC_ID_H264 = 28,
        @CODEC_ID_INDEO3 = 29,
        @CODEC_ID_VP3 = 30,
        @CODEC_ID_THEORA = 31,
        @CODEC_ID_ASV1 = 32,
        @CODEC_ID_ASV2 = 33,
        @CODEC_ID_FFV1 = 34,
        @CODEC_ID_4XM = 35,
        @CODEC_ID_VCR1 = 36,
        @CODEC_ID_CLJR = 37,
        @CODEC_ID_MDEC = 38,
        @CODEC_ID_ROQ = 39,
        @CODEC_ID_INTERPLAY_VIDEO = 40,
        @CODEC_ID_XAN_WC3 = 41,
        @CODEC_ID_XAN_WC4 = 42,
        @CODEC_ID_RPZA = 43,
        @CODEC_ID_CINEPAK = 44,
        @CODEC_ID_WS_VQA = 45,
        @CODEC_ID_MSRLE = 46,
        @CODEC_ID_MSVIDEO1 = 47,
        @CODEC_ID_IDCIN = 48,
        @CODEC_ID_8BPS = 49,
        @CODEC_ID_SMC = 50,
        @CODEC_ID_FLIC = 51,
        @CODEC_ID_TRUEMOTION1 = 52,
        @CODEC_ID_VMDVIDEO = 53,
        @CODEC_ID_MSZH = 54,
        @CODEC_ID_ZLIB = 55,
        @CODEC_ID_QTRLE = 56,
        @CODEC_ID_TSCC = 57,
        @CODEC_ID_ULTI = 58,
        @CODEC_ID_QDRAW = 59,
        @CODEC_ID_VIXL = 60,
        @CODEC_ID_QPEG = 61,
        @CODEC_ID_PNG = 62,
        @CODEC_ID_PPM = 63,
        @CODEC_ID_PBM = 64,
        @CODEC_ID_PGM = 65,
        @CODEC_ID_PGMYUV = 66,
        @CODEC_ID_PAM = 67,
        @CODEC_ID_FFVHUFF = 68,
        @CODEC_ID_RV30 = 69,
        @CODEC_ID_RV40 = 70,
        @CODEC_ID_VC1 = 71,
        @CODEC_ID_WMV3 = 72,
        @CODEC_ID_LOCO = 73,
        @CODEC_ID_WNV1 = 74,
        @CODEC_ID_AASC = 75,
        @CODEC_ID_INDEO2 = 76,
        @CODEC_ID_FRAPS = 77,
        @CODEC_ID_TRUEMOTION2 = 78,
        @CODEC_ID_BMP = 79,
        @CODEC_ID_CSCD = 80,
        @CODEC_ID_MMVIDEO = 81,
        @CODEC_ID_ZMBV = 82,
        @CODEC_ID_AVS = 83,
        @CODEC_ID_SMACKVIDEO = 84,
        @CODEC_ID_NUV = 85,
        @CODEC_ID_KMVC = 86,
        @CODEC_ID_FLASHSV = 87,
        @CODEC_ID_CAVS = 88,
        @CODEC_ID_JPEG2000 = 89,
        @CODEC_ID_VMNC = 90,
        @CODEC_ID_VP5 = 91,
        @CODEC_ID_VP6 = 92,
        @CODEC_ID_VP6F = 93,
        @CODEC_ID_TARGA = 94,
        @CODEC_ID_DSICINVIDEO = 95,
        @CODEC_ID_TIERTEXSEQVIDEO = 96,
        @CODEC_ID_TIFF = 97,
        @CODEC_ID_GIF = 98,
        @CODEC_ID_DXA = 99,
        @CODEC_ID_DNXHD = 100,
        @CODEC_ID_THP = 101,
        @CODEC_ID_SGI = 102,
        @CODEC_ID_C93 = 103,
        @CODEC_ID_BETHSOFTVID = 104,
        @CODEC_ID_PTX = 105,
        @CODEC_ID_TXD = 106,
        @CODEC_ID_VP6A = 107,
        @CODEC_ID_AMV = 108,
        @CODEC_ID_VB = 109,
        @CODEC_ID_PCX = 110,
        @CODEC_ID_SUNRAST = 111,
        @CODEC_ID_INDEO4 = 112,
        @CODEC_ID_INDEO5 = 113,
        @CODEC_ID_MIMIC = 114,
        @CODEC_ID_RL2 = 115,
        @CODEC_ID_ESCAPE124 = 116,
        @CODEC_ID_DIRAC = 117,
        @CODEC_ID_BFI = 118,
        @CODEC_ID_CMV = 119,
        @CODEC_ID_MOTIONPIXELS = 120,
        @CODEC_ID_TGV = 121,
        @CODEC_ID_TGQ = 122,
        @CODEC_ID_TQI = 123,
        @CODEC_ID_AURA = 124,
        @CODEC_ID_AURA2 = 125,
        @CODEC_ID_V210X = 126,
        @CODEC_ID_TMV = 127,
        @CODEC_ID_V210 = 128,
        @CODEC_ID_DPX = 129,
        @CODEC_ID_MAD = 130,
        @CODEC_ID_FRWU = 131,
        @CODEC_ID_FLASHSV2 = 132,
        @CODEC_ID_CDGRAPHICS = 133,
        @CODEC_ID_R210 = 134,
        @CODEC_ID_ANM = 135,
        @CODEC_ID_BINKVIDEO = 136,
        @CODEC_ID_IFF_ILBM = 137,
        @CODEC_ID_IFF_BYTERUN1 = 138,
        @CODEC_ID_KGV1 = 139,
        @CODEC_ID_YOP = 140,
        @CODEC_ID_VP8 = 141,
        @CODEC_ID_PICTOR = 142,
        @CODEC_ID_ANSI = 143,
        @CODEC_ID_A64_MULTI = 144,
        @CODEC_ID_A64_MULTI5 = 145,
        @CODEC_ID_R10K = 146,
        @CODEC_ID_MXPEG = 147,
        @CODEC_ID_LAGARITH = 148,
        @CODEC_ID_PRORES = 149,
        @CODEC_ID_JV = 150,
        @CODEC_ID_DFA = 151,
        @CODEC_ID_WMV3IMAGE = 152,
        @CODEC_ID_VC1IMAGE = 153,
        @CODEC_ID_UTVIDEO = 154,
        @CODEC_ID_BMV_VIDEO = 155,
        @CODEC_ID_VBLE = 156,
        @CODEC_ID_DXTORY = 157,
        @CODEC_ID_V410 = 158,
        @CODEC_ID_XWD = 159,
        @CODEC_ID_CDXL = 160,
        @CODEC_ID_XBM = 161,
        @CODEC_ID_ZEROCODEC = 162,
        @CODEC_ID_MSS1 = 163,
        @CODEC_ID_MSA1 = 164,
        @CODEC_ID_TSCC2 = 165,
        @CODEC_ID_MTS2 = 166,
        @CODEC_ID_CLLC = 167,
        @CODEC_ID_Y41P = 1496592720,
        @CODEC_ID_ESCAPE130 = 1160852272,
        @CODEC_ID_EXR = 809850962,
        @CODEC_ID_AVRP = 1096176208,
        @CODEC_ID_G2M = 4665933,
        @CODEC_ID_AVUI = 1096176969,
        @CODEC_ID_AYUV = 1096373590,
        @CODEC_ID_V308 = 1446195256,
        @CODEC_ID_V408 = 1446260792,
        @CODEC_ID_YUV4 = 1498764852,
        @CODEC_ID_SANM = 1396788813,
        @CODEC_ID_PAF_VIDEO = 1346455126,
        @CODEC_ID_SNOW = 1397641047,
        @CODEC_ID_FIRST_AUDIO = 65536,
        @CODEC_ID_PCM_S16LE = 65536,
        @CODEC_ID_PCM_S16BE = 65537,
        @CODEC_ID_PCM_U16LE = 65538,
        @CODEC_ID_PCM_U16BE = 65539,
        @CODEC_ID_PCM_S8 = 65540,
        @CODEC_ID_PCM_U8 = 65541,
        @CODEC_ID_PCM_MULAW = 65542,
        @CODEC_ID_PCM_ALAW = 65543,
        @CODEC_ID_PCM_S32LE = 65544,
        @CODEC_ID_PCM_S32BE = 65545,
        @CODEC_ID_PCM_U32LE = 65546,
        @CODEC_ID_PCM_U32BE = 65547,
        @CODEC_ID_PCM_S24LE = 65548,
        @CODEC_ID_PCM_S24BE = 65549,
        @CODEC_ID_PCM_U24LE = 65550,
        @CODEC_ID_PCM_U24BE = 65551,
        @CODEC_ID_PCM_S24DAUD = 65552,
        @CODEC_ID_PCM_ZORK = 65553,
        @CODEC_ID_PCM_S16LE_PLANAR = 65554,
        @CODEC_ID_PCM_DVD = 65555,
        @CODEC_ID_PCM_F32BE = 65556,
        @CODEC_ID_PCM_F32LE = 65557,
        @CODEC_ID_PCM_F64BE = 65558,
        @CODEC_ID_PCM_F64LE = 65559,
        @CODEC_ID_PCM_BLURAY = 65560,
        @CODEC_ID_PCM_LXF = 65561,
        @CODEC_ID_S302M = 65562,
        @CODEC_ID_PCM_S8_PLANAR = 65563,
        @CODEC_ID_ADPCM_IMA_QT = 69632,
        @CODEC_ID_ADPCM_IMA_WAV = 69633,
        @CODEC_ID_ADPCM_IMA_DK3 = 69634,
        @CODEC_ID_ADPCM_IMA_DK4 = 69635,
        @CODEC_ID_ADPCM_IMA_WS = 69636,
        @CODEC_ID_ADPCM_IMA_SMJPEG = 69637,
        @CODEC_ID_ADPCM_MS = 69638,
        @CODEC_ID_ADPCM_4XM = 69639,
        @CODEC_ID_ADPCM_XA = 69640,
        @CODEC_ID_ADPCM_ADX = 69641,
        @CODEC_ID_ADPCM_EA = 69642,
        @CODEC_ID_ADPCM_G726 = 69643,
        @CODEC_ID_ADPCM_CT = 69644,
        @CODEC_ID_ADPCM_SWF = 69645,
        @CODEC_ID_ADPCM_YAMAHA = 69646,
        @CODEC_ID_ADPCM_SBPRO_4 = 69647,
        @CODEC_ID_ADPCM_SBPRO_3 = 69648,
        @CODEC_ID_ADPCM_SBPRO_2 = 69649,
        @CODEC_ID_ADPCM_THP = 69650,
        @CODEC_ID_ADPCM_IMA_AMV = 69651,
        @CODEC_ID_ADPCM_EA_R1 = 69652,
        @CODEC_ID_ADPCM_EA_R3 = 69653,
        @CODEC_ID_ADPCM_EA_R2 = 69654,
        @CODEC_ID_ADPCM_IMA_EA_SEAD = 69655,
        @CODEC_ID_ADPCM_IMA_EA_EACS = 69656,
        @CODEC_ID_ADPCM_EA_XAS = 69657,
        @CODEC_ID_ADPCM_EA_MAXIS_XA = 69658,
        @CODEC_ID_ADPCM_IMA_ISS = 69659,
        @CODEC_ID_ADPCM_G722 = 69660,
        @CODEC_ID_ADPCM_IMA_APC = 69661,
        @CODEC_ID_VIMA = 1447644481,
        @CODEC_ID_AMR_NB = 73728,
        @CODEC_ID_AMR_WB = 73729,
        @CODEC_ID_RA_144 = 77824,
        @CODEC_ID_RA_288 = 77825,
        @CODEC_ID_ROQ_DPCM = 81920,
        @CODEC_ID_INTERPLAY_DPCM = 81921,
        @CODEC_ID_XAN_DPCM = 81922,
        @CODEC_ID_SOL_DPCM = 81923,
        @CODEC_ID_MP2 = 86016,
        @CODEC_ID_MP3 = 86017,
        @CODEC_ID_AAC = 86018,
        @CODEC_ID_AC3 = 86019,
        @CODEC_ID_DTS = 86020,
        @CODEC_ID_VORBIS = 86021,
        @CODEC_ID_DVAUDIO = 86022,
        @CODEC_ID_WMAV1 = 86023,
        @CODEC_ID_WMAV2 = 86024,
        @CODEC_ID_MACE3 = 86025,
        @CODEC_ID_MACE6 = 86026,
        @CODEC_ID_VMDAUDIO = 86027,
        @CODEC_ID_FLAC = 86028,
        @CODEC_ID_MP3ADU = 86029,
        @CODEC_ID_MP3ON4 = 86030,
        @CODEC_ID_SHORTEN = 86031,
        @CODEC_ID_ALAC = 86032,
        @CODEC_ID_WESTWOOD_SND1 = 86033,
        @CODEC_ID_GSM = 86034,
        @CODEC_ID_QDM2 = 86035,
        @CODEC_ID_COOK = 86036,
        @CODEC_ID_TRUESPEECH = 86037,
        @CODEC_ID_TTA = 86038,
        @CODEC_ID_SMACKAUDIO = 86039,
        @CODEC_ID_QCELP = 86040,
        @CODEC_ID_WAVPACK = 86041,
        @CODEC_ID_DSICINAUDIO = 86042,
        @CODEC_ID_IMC = 86043,
        @CODEC_ID_MUSEPACK7 = 86044,
        @CODEC_ID_MLP = 86045,
        @CODEC_ID_GSM_MS = 86046,
        @CODEC_ID_ATRAC3 = 86047,
        @CODEC_ID_VOXWARE = 86048,
        @CODEC_ID_APE = 86049,
        @CODEC_ID_NELLYMOSER = 86050,
        @CODEC_ID_MUSEPACK8 = 86051,
        @CODEC_ID_SPEEX = 86052,
        @CODEC_ID_WMAVOICE = 86053,
        @CODEC_ID_WMAPRO = 86054,
        @CODEC_ID_WMALOSSLESS = 86055,
        @CODEC_ID_ATRAC3P = 86056,
        @CODEC_ID_EAC3 = 86057,
        @CODEC_ID_SIPR = 86058,
        @CODEC_ID_MP1 = 86059,
        @CODEC_ID_TWINVQ = 86060,
        @CODEC_ID_TRUEHD = 86061,
        @CODEC_ID_MP4ALS = 86062,
        @CODEC_ID_ATRAC1 = 86063,
        @CODEC_ID_BINKAUDIO_RDFT = 86064,
        @CODEC_ID_BINKAUDIO_DCT = 86065,
        @CODEC_ID_AAC_LATM = 86066,
        @CODEC_ID_QDMC = 86067,
        @CODEC_ID_CELT = 86068,
        @CODEC_ID_G723_1 = 86069,
        @CODEC_ID_G729 = 86070,
        @CODEC_ID_8SVX_EXP = 86071,
        @CODEC_ID_8SVX_FIB = 86072,
        @CODEC_ID_BMV_AUDIO = 86073,
        @CODEC_ID_RALF = 86074,
        @CODEC_ID_IAC = 86075,
        @CODEC_ID_ILBC = 86076,
        @CODEC_ID_FFWAVESYNTH = 1179014995,
        @CODEC_ID_SONIC = 1397706307,
        @CODEC_ID_SONIC_LS = 1397706316,
        @CODEC_ID_PAF_AUDIO = 1346455105,
        @CODEC_ID_OPUS = 1330664787,
        @CODEC_ID_FIRST_SUBTITLE = 94208,
        @CODEC_ID_DVD_SUBTITLE = 94208,
        @CODEC_ID_DVB_SUBTITLE = 94209,
        @CODEC_ID_TEXT = 94210,
        @CODEC_ID_XSUB = 94211,
        @CODEC_ID_SSA = 94212,
        @CODEC_ID_MOV_TEXT = 94213,
        @CODEC_ID_HDMV_PGS_SUBTITLE = 94214,
        @CODEC_ID_DVB_TELETEXT = 94215,
        @CODEC_ID_SRT = 94216,
        @CODEC_ID_MICRODVD = 1833195076,
        @CODEC_ID_EIA_608 = 1664495672,
        @CODEC_ID_JACOSUB = 1246975298,
        @CODEC_ID_SAMI = 1396788553,
        @CODEC_ID_REALTEXT = 1381259348,
        @CODEC_ID_SUBVIEWER = 1400201814,
        @CODEC_ID_FIRST_UNKNOWN = 98304,
        @CODEC_ID_TTF = 98304,
        @CODEC_ID_BINTEXT = 1112823892,
        @CODEC_ID_XBIN = 1480739150,
        @CODEC_ID_IDF = 4801606,
        @CODEC_ID_OTF = 5198918,
        @CODEC_ID_PROBE = 102400,
        @CODEC_ID_MPEG2TS = 131072,
        @CODEC_ID_MPEG4SYSTEMS = 131073,
        @CODEC_ID_FFMETADATA = 135168,
    }
    
    public enum Motion_Est_ID : int
    {
        @ME_ZERO = 1,
        @ME_FULL = 2,
        @ME_LOG = 3,
        @ME_PHODS = 4,
        @ME_EPZS = 5,
        @ME_X1 = 6,
        @ME_HEX = 7,
        @ME_UMH = 8,
        @ME_TESA = 9,
        @ME_ITER = 50,
    }
    
    public enum AVDiscard : int
    {
        @AVDISCARD_NONE = -16,
        @AVDISCARD_DEFAULT = 0,
        @AVDISCARD_NONREF = 8,
        @AVDISCARD_BIDIR = 16,
        @AVDISCARD_NONINTRA = 24,
        @AVDISCARD_NONKEY = 32,
        @AVDISCARD_ALL = 48,
    }
    
    public enum AVAudioServiceType : int
    {
        @AV_AUDIO_SERVICE_TYPE_MAIN = 0,
        @AV_AUDIO_SERVICE_TYPE_EFFECTS = 1,
        @AV_AUDIO_SERVICE_TYPE_VISUALLY_IMPAIRED = 2,
        @AV_AUDIO_SERVICE_TYPE_HEARING_IMPAIRED = 3,
        @AV_AUDIO_SERVICE_TYPE_DIALOGUE = 4,
        @AV_AUDIO_SERVICE_TYPE_COMMENTARY = 5,
        @AV_AUDIO_SERVICE_TYPE_EMERGENCY = 6,
        @AV_AUDIO_SERVICE_TYPE_VOICE_OVER = 7,
        @AV_AUDIO_SERVICE_TYPE_KARAOKE = 8,
        @AV_AUDIO_SERVICE_TYPE_NB = 9,
    }
    
    public enum AVPacketSideDataType : int
    {
        @AV_PKT_DATA_PALETTE = 0,
        @AV_PKT_DATA_NEW_EXTRADATA = 1,
        @AV_PKT_DATA_PARAM_CHANGE = 2,
        @AV_PKT_DATA_H263_MB_INFO = 3,
        @AV_PKT_DATA_REPLAYGAIN = 4,
        @AV_PKT_DATA_DISPLAYMATRIX = 5,
        @AV_PKT_DATA_STEREO3D = 6,
        @AV_PKT_DATA_AUDIO_SERVICE_TYPE = 7,
        @AV_PKT_DATA_QUALITY_STATS = 8,
        @AV_PKT_DATA_SKIP_SAMPLES = 70,
        @AV_PKT_DATA_JP_DUALMONO = 71,
        @AV_PKT_DATA_STRINGS_METADATA = 72,
        @AV_PKT_DATA_SUBTITLE_POSITION = 73,
        @AV_PKT_DATA_MATROSKA_BLOCKADDITIONAL = 74,
        @AV_PKT_DATA_WEBVTT_IDENTIFIER = 75,
        @AV_PKT_DATA_WEBVTT_SETTINGS = 76,
        @AV_PKT_DATA_METADATA_UPDATE = 77,
    }
    
    public enum AVSideDataParamChangeFlags : int
    {
        @AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_COUNT = 1,
        @AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_LAYOUT = 2,
        @AV_SIDE_DATA_PARAM_CHANGE_SAMPLE_RATE = 4,
        @AV_SIDE_DATA_PARAM_CHANGE_DIMENSIONS = 8,
    }
    
    public enum AVFieldOrder : int
    {
        @AV_FIELD_UNKNOWN = 0,
        @AV_FIELD_PROGRESSIVE = 1,
        @AV_FIELD_TT = 2,
        @AV_FIELD_BB = 3,
        @AV_FIELD_TB = 4,
        @AV_FIELD_BT = 5,
    }
    
    public enum AVSubtitleType : int
    {
        @SUBTITLE_NONE = 0,
        @SUBTITLE_BITMAP = 1,
        @SUBTITLE_TEXT = 2,
        @SUBTITLE_ASS = 3,
    }
    
    public enum AVPictureStructure : int
    {
        @AV_PICTURE_STRUCTURE_UNKNOWN = 0,
        @AV_PICTURE_STRUCTURE_TOP_FIELD = 1,
        @AV_PICTURE_STRUCTURE_BOTTOM_FIELD = 2,
        @AV_PICTURE_STRUCTURE_FRAME = 3,
    }
    
    public enum AVLockOp : int
    {
        @AV_LOCK_CREATE = 0,
        @AV_LOCK_OBTAIN = 1,
        @AV_LOCK_RELEASE = 2,
        @AV_LOCK_DESTROY = 3,
    }
    
    public unsafe static partial class ffmpeg
    {
        public const ulong AV_CPU_FLAG_FORCE = 0x80000000;
        public const ulong AV_CPU_FLAG_MMX = 0x0001;
        public const ulong AV_CPU_FLAG_MMXEXT = 0x0002;
        public const ulong AV_CPU_FLAG_MMX2 = 0x0002;
        public const ulong AV_CPU_FLAG_3DNOW = 0x0004;
        public const ulong AV_CPU_FLAG_SSE = 0x0008;
        public const ulong AV_CPU_FLAG_SSE2 = 0x0010;
        public const ulong AV_CPU_FLAG_SSE2SLOW = 0x40000000;
        public const ulong AV_CPU_FLAG_3DNOWEXT = 0x0020;
        public const ulong AV_CPU_FLAG_SSE3 = 0x0040;
        public const ulong AV_CPU_FLAG_SSE3SLOW = 0x20000000;
        public const ulong AV_CPU_FLAG_SSSE3 = 0x0080;
        public const ulong AV_CPU_FLAG_ATOM = 0x10000000;
        public const ulong AV_CPU_FLAG_SSE4 = 0x0100;
        public const ulong AV_CPU_FLAG_SSE42 = 0x0200;
        public const ulong AV_CPU_FLAG_AVX = 0x4000;
        public const ulong AV_CPU_FLAG_AVXSLOW = 0x8000000;
        public const ulong AV_CPU_FLAG_XOP = 0x0400;
        public const ulong AV_CPU_FLAG_FMA4 = 0x0800;
        public const ulong AV_CPU_FLAG_CMOV = 0x1001000;
        public const ulong AV_CPU_FLAG_AVX2 = 0x8000;
        public const ulong AV_CPU_FLAG_FMA3 = 0x10000;
        public const ulong AV_CPU_FLAG_BMI1 = 0x20000;
        public const ulong AV_CPU_FLAG_BMI2 = 0x40000;
        public const ulong AV_CPU_FLAG_ALTIVEC = 0x0001;
        public const ulong AV_CPU_FLAG_VSX = 0x0002;
        public const ulong AV_CPU_FLAG_POWER8 = 0x0004;
        public const ulong AV_CPU_FLAG_ARMV5TE = (1<<0);
        public const ulong AV_CPU_FLAG_ARMV6 = (1<<1);
        public const ulong AV_CPU_FLAG_ARMV6T2 = (1<<2);
        public const ulong AV_CPU_FLAG_VFP = (1<<3);
        public const ulong AV_CPU_FLAG_VFPV3 = (1<<4);
        public const ulong AV_CPU_FLAG_NEON = (1<<5);
        public const ulong AV_CPU_FLAG_ARMV8 = (1<<6);
        public const ulong AV_CPU_FLAG_SETEND = (1<<16);
        public const ulong AV_CH_FRONT_LEFT = 0x00000001;
        public const ulong AV_CH_FRONT_RIGHT = 0x00000002;
        public const ulong AV_CH_FRONT_CENTER = 0x00000004;
        public const ulong AV_CH_LOW_FREQUENCY = 0x00000008;
        public const ulong AV_CH_BACK_LEFT = 0x00000010;
        public const ulong AV_CH_BACK_RIGHT = 0x00000020;
        public const ulong AV_CH_FRONT_LEFT_OF_CENTER = 0x00000040;
        public const ulong AV_CH_FRONT_RIGHT_OF_CENTER = 0x00000080;
        public const ulong AV_CH_BACK_CENTER = 0x00000100;
        public const ulong AV_CH_SIDE_LEFT = 0x00000200;
        public const ulong AV_CH_SIDE_RIGHT = 0x00000400;
        public const ulong AV_CH_TOP_CENTER = 0x00000800;
        public const ulong AV_CH_TOP_FRONT_LEFT = 0x00001000;
        public const ulong AV_CH_TOP_FRONT_CENTER = 0x00002000;
        public const ulong AV_CH_TOP_FRONT_RIGHT = 0x00004000;
        public const ulong AV_CH_TOP_BACK_LEFT = 0x00008000;
        public const ulong AV_CH_TOP_BACK_CENTER = 0x00010000;
        public const ulong AV_CH_TOP_BACK_RIGHT = 0x00020000;
        public const ulong AV_CH_STEREO_LEFT = 0x20000000;
        public const ulong AV_CH_STEREO_RIGHT = 0x40000000;
        public const ulong AV_CH_WIDE_LEFT = 0x0000000080000000UL;
        public const ulong AV_CH_WIDE_RIGHT = 0x0000000100000000UL;
        public const ulong AV_CH_SURROUND_DIRECT_LEFT = 0x0000000200000000UL;
        public const ulong AV_CH_SURROUND_DIRECT_RIGHT = 0x0000000400000000UL;
        public const ulong AV_CH_LOW_FREQUENCY_2 = 0x0000000800000000UL;
        public const ulong AV_CH_LAYOUT_NATIVE = 0x8000000000000000UL;
        public const ulong AV_CH_LAYOUT_MONO = (AV_CH_FRONT_CENTER);
        public const ulong AV_CH_LAYOUT_STEREO = (AV_CH_FRONT_LEFT|AV_CH_FRONT_RIGHT);
        public const ulong AV_CH_LAYOUT_2POINT1 = (AV_CH_LAYOUT_STEREO|AV_CH_LOW_FREQUENCY);
        public const ulong AV_CH_LAYOUT_2_1 = (AV_CH_LAYOUT_STEREO|AV_CH_BACK_CENTER);
        public const ulong AV_CH_LAYOUT_SURROUND = (AV_CH_LAYOUT_STEREO|AV_CH_FRONT_CENTER);
        public const ulong AV_CH_LAYOUT_3POINT1 = (AV_CH_LAYOUT_SURROUND|AV_CH_LOW_FREQUENCY);
        public const ulong AV_CH_LAYOUT_4POINT0 = (AV_CH_LAYOUT_SURROUND|AV_CH_BACK_CENTER);
        public const ulong AV_CH_LAYOUT_4POINT1 = (AV_CH_LAYOUT_4POINT0|AV_CH_LOW_FREQUENCY);
        public const ulong AV_CH_LAYOUT_2_2 = (AV_CH_LAYOUT_STEREO|AV_CH_SIDE_LEFT|AV_CH_SIDE_RIGHT);
        public const ulong AV_CH_LAYOUT_QUAD = (AV_CH_LAYOUT_STEREO|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT);
        public const ulong AV_CH_LAYOUT_5POINT0 = (AV_CH_LAYOUT_SURROUND|AV_CH_SIDE_LEFT|AV_CH_SIDE_RIGHT);
        public const ulong AV_CH_LAYOUT_5POINT1 = (AV_CH_LAYOUT_5POINT0|AV_CH_LOW_FREQUENCY);
        public const ulong AV_CH_LAYOUT_5POINT0_BACK = (AV_CH_LAYOUT_SURROUND|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT);
        public const ulong AV_CH_LAYOUT_5POINT1_BACK = (AV_CH_LAYOUT_5POINT0_BACK|AV_CH_LOW_FREQUENCY);
        public const ulong AV_CH_LAYOUT_6POINT0 = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_CENTER);
        public const ulong AV_CH_LAYOUT_6POINT0_FRONT = (AV_CH_LAYOUT_2_2|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER);
        public const ulong AV_CH_LAYOUT_HEXAGONAL = (AV_CH_LAYOUT_5POINT0_BACK|AV_CH_BACK_CENTER);
        public const ulong AV_CH_LAYOUT_6POINT1 = (AV_CH_LAYOUT_5POINT1|AV_CH_BACK_CENTER);
        public const ulong AV_CH_LAYOUT_6POINT1_BACK = (AV_CH_LAYOUT_5POINT1_BACK|AV_CH_BACK_CENTER);
        public const ulong AV_CH_LAYOUT_6POINT1_FRONT = (AV_CH_LAYOUT_6POINT0_FRONT|AV_CH_LOW_FREQUENCY);
        public const ulong AV_CH_LAYOUT_7POINT0 = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT);
        public const ulong AV_CH_LAYOUT_7POINT0_FRONT = (AV_CH_LAYOUT_5POINT0|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER);
        public const ulong AV_CH_LAYOUT_7POINT1 = (AV_CH_LAYOUT_5POINT1|AV_CH_BACK_LEFT|AV_CH_BACK_RIGHT);
        public const ulong AV_CH_LAYOUT_7POINT1_WIDE = (AV_CH_LAYOUT_5POINT1|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER);
        public const ulong AV_CH_LAYOUT_7POINT1_WIDE_BACK = (AV_CH_LAYOUT_5POINT1_BACK|AV_CH_FRONT_LEFT_OF_CENTER|AV_CH_FRONT_RIGHT_OF_CENTER);
        public const ulong AV_CH_LAYOUT_OCTAGONAL = (AV_CH_LAYOUT_5POINT0|AV_CH_BACK_LEFT|AV_CH_BACK_CENTER|AV_CH_BACK_RIGHT);
        public const ulong AV_CH_LAYOUT_HEXADECAGONAL = (AV_CH_LAYOUT_OCTAGONAL|AV_CH_WIDE_LEFT|AV_CH_WIDE_RIGHT|AV_CH_TOP_BACK_LEFT|AV_CH_TOP_BACK_RIGHT|AV_CH_TOP_BACK_CENTER|AV_CH_TOP_FRONT_CENTER|AV_CH_TOP_FRONT_LEFT|AV_CH_TOP_FRONT_RIGHT);
        public const ulong AV_CH_LAYOUT_STEREO_DOWNMIX = (AV_CH_STEREO_LEFT|AV_CH_STEREO_RIGHT);
        public const ulong LIBAVCODEC_VERSION_MAJOR = 56;
        public const ulong LIBAVCODEC_VERSION_MINOR = 60;
        public const ulong LIBAVCODEC_VERSION_MICRO = 100;
        public const ulong AV_CODEC_PROP_INTRA_ONLY = (1<<0);
        public const ulong AV_CODEC_PROP_LOSSY = (1<<1);
        public const ulong AV_CODEC_PROP_LOSSLESS = (1<<2);
        public const ulong AV_CODEC_PROP_REORDER = (1<<3);
        public const ulong AV_CODEC_PROP_BITMAP_SUB = (1<<16);
        public const ulong AV_CODEC_PROP_TEXT_SUB = (1<<17);
        public const ulong AV_INPUT_BUFFER_PADDING_SIZE = 32;
        public const ulong AV_INPUT_BUFFER_MIN_SIZE = 16384;
        public const ulong FF_INPUT_BUFFER_PADDING_SIZE = 32;
        public const ulong FF_MIN_BUFFER_SIZE = 16384;
        public const ulong FF_MAX_B_FRAMES = 16;
        public const ulong AV_CODEC_FLAG_UNALIGNED = (1<<0);
        public const ulong AV_CODEC_FLAG_QSCALE = (1<<1);
        public const ulong AV_CODEC_FLAG_4MV = (1<<2);
        public const ulong AV_CODEC_FLAG_OUTPUT_CORRUPT = (1<<3);
        public const ulong AV_CODEC_FLAG_QPEL = (1<<4);
        public const ulong AV_CODEC_FLAG_PASS1 = (1<<9);
        public const ulong AV_CODEC_FLAG_PASS2 = (1<<10);
        public const ulong AV_CODEC_FLAG_LOOP_FILTER = (1<<11);
        public const ulong AV_CODEC_FLAG_GRAY = (1<<13);
        public const ulong AV_CODEC_FLAG_PSNR = (1<<15);
        public const int AV_CODEC_FLAG_TRUNCATED = (1<<16);
        public const ulong AV_CODEC_FLAG_INTERLACED_DCT = (1<<18);
        public const ulong AV_CODEC_FLAG_LOW_DELAY = (1<<19);
        public const ulong AV_CODEC_FLAG_GLOBAL_HEADER = (1<<22);
        public const ulong AV_CODEC_FLAG_BITEXACT = (1<<23);
        public const ulong AV_CODEC_FLAG_AC_PRED = (1<<24);
        public const ulong AV_CODEC_FLAG_INTERLACED_ME = (1<<29);
        public const ulong AV_CODEC_FLAG_CLOSED_GOP = (1U<<31);
        public const ulong AV_CODEC_FLAG2_FAST = (1<<0);
        public const ulong AV_CODEC_FLAG2_NO_OUTPUT = (1<<2);
        public const ulong AV_CODEC_FLAG2_LOCAL_HEADER = (1<<3);
        public const ulong AV_CODEC_FLAG2_DROP_FRAME_TIMECODE = (1<<13);
        public const ulong AV_CODEC_FLAG2_CHUNKS = (1<<15);
        public const ulong AV_CODEC_FLAG2_IGNORE_CROP = (1<<16);
        public const ulong AV_CODEC_FLAG2_SHOW_ALL = (1<<22);
        public const ulong AV_CODEC_FLAG2_EXPORT_MVS = (1<<28);
        public const ulong AV_CODEC_FLAG2_SKIP_MANUAL = (1<<29);
        public const ulong AV_CODEC_CAP_DRAW_HORIZ_BAND = (1<<0);
        public const ulong AV_CODEC_CAP_DR1 = (1<<1);
        public const long AV_CODEC_CAP_TRUNCATED = (1<<3);
        public const ulong AV_CODEC_CAP_DELAY = (1<<5);
        public const ulong AV_CODEC_CAP_SMALL_LAST_FRAME = (1<<6);
        public const ulong AV_CODEC_CAP_HWACCEL_VDPAU = (1<<7);
        public const ulong AV_CODEC_CAP_SUBFRAMES = (1<<8);
        public const ulong AV_CODEC_CAP_EXPERIMENTAL = (1<<9);
        public const ulong AV_CODEC_CAP_CHANNEL_CONF = (1<<10);
        public const ulong AV_CODEC_CAP_FRAME_THREADS = (1<<12);
        public const ulong AV_CODEC_CAP_SLICE_THREADS = (1<<13);
        public const ulong AV_CODEC_CAP_PARAM_CHANGE = (1<<14);
        public const ulong AV_CODEC_CAP_AUTO_THREADS = (1<<15);
        public const ulong AV_CODEC_CAP_VARIABLE_FRAME_SIZE = (1<<16);
        public const ulong AV_CODEC_CAP_INTRA_ONLY = 0x40000000;
        public const ulong AV_CODEC_CAP_LOSSLESS = 0x80000000;
        public const ulong CODEC_FLAG_UNALIGNED = AV_CODEC_FLAG_UNALIGNED;
        public const ulong CODEC_FLAG_QSCALE = AV_CODEC_FLAG_QSCALE;
        public const ulong CODEC_FLAG_4MV = AV_CODEC_FLAG_4MV;
        public const ulong CODEC_FLAG_OUTPUT_CORRUPT = AV_CODEC_FLAG_OUTPUT_CORRUPT;
        public const ulong CODEC_FLAG_QPEL = AV_CODEC_FLAG_QPEL;
        public const ulong CODEC_FLAG_GMC = 0x0020;
        public const ulong CODEC_FLAG_MV0 = 0x0040;
        public const ulong CODEC_FLAG_INPUT_PRESERVED = 0x0100;
        public const ulong CODEC_FLAG_PASS1 = AV_CODEC_FLAG_PASS1;
        public const ulong CODEC_FLAG_PASS2 = AV_CODEC_FLAG_PASS2;
        public const ulong CODEC_FLAG_GRAY = AV_CODEC_FLAG_GRAY;
        public const ulong CODEC_FLAG_EMU_EDGE = 0x4000;
        public const ulong CODEC_FLAG_PSNR = AV_CODEC_FLAG_PSNR;
        public const ulong CODEC_FLAG_NORMALIZE_AQP = 0x00020000;
        public const ulong CODEC_FLAG_INTERLACED_DCT = AV_CODEC_FLAG_INTERLACED_DCT;
        public const ulong CODEC_FLAG_LOW_DELAY = AV_CODEC_FLAG_LOW_DELAY;
        public const ulong CODEC_FLAG_GLOBAL_HEADER = AV_CODEC_FLAG_GLOBAL_HEADER;
        public const ulong CODEC_FLAG_BITEXACT = AV_CODEC_FLAG_BITEXACT;
        public const ulong CODEC_FLAG_AC_PRED = AV_CODEC_FLAG_AC_PRED;
        public const ulong CODEC_FLAG_LOOP_FILTER = AV_CODEC_FLAG_LOOP_FILTER;
        public const ulong CODEC_FLAG_INTERLACED_ME = AV_CODEC_FLAG_INTERLACED_ME;
        public const ulong CODEC_FLAG_CLOSED_GOP = AV_CODEC_FLAG_CLOSED_GOP;
        public const ulong CODEC_FLAG2_FAST = AV_CODEC_FLAG2_FAST;
        public const ulong CODEC_FLAG2_NO_OUTPUT = AV_CODEC_FLAG2_NO_OUTPUT;
        public const ulong CODEC_FLAG2_LOCAL_HEADER = AV_CODEC_FLAG2_LOCAL_HEADER;
        public const ulong CODEC_FLAG2_DROP_FRAME_TIMECODE = AV_CODEC_FLAG2_DROP_FRAME_TIMECODE;
        public const ulong CODEC_FLAG2_IGNORE_CROP = AV_CODEC_FLAG2_IGNORE_CROP;
        public const ulong CODEC_FLAG2_CHUNKS = AV_CODEC_FLAG2_CHUNKS;
        public const ulong CODEC_FLAG2_SHOW_ALL = AV_CODEC_FLAG2_SHOW_ALL;
        public const ulong CODEC_FLAG2_EXPORT_MVS = AV_CODEC_FLAG2_EXPORT_MVS;
        public const ulong CODEC_FLAG2_SKIP_MANUAL = AV_CODEC_FLAG2_SKIP_MANUAL;
        public const ulong CODEC_CAP_DRAW_HORIZ_BAND = AV_CODEC_CAP_DRAW_HORIZ_BAND;
        public const ulong CODEC_CAP_DR1 = AV_CODEC_CAP_DR1;
        public const ulong CODEC_CAP_TRUNCATED = AV_CODEC_CAP_TRUNCATED;
        public const ulong CODEC_CAP_HWACCEL = 0x0010;
        public const ulong CODEC_CAP_DELAY = AV_CODEC_CAP_DELAY;
        public const ulong CODEC_CAP_SMALL_LAST_FRAME = AV_CODEC_CAP_SMALL_LAST_FRAME;
        public const ulong CODEC_CAP_HWACCEL_VDPAU = AV_CODEC_CAP_HWACCEL_VDPAU;
        public const ulong CODEC_CAP_SUBFRAMES = AV_CODEC_CAP_SUBFRAMES;
        public const ulong CODEC_CAP_EXPERIMENTAL = AV_CODEC_CAP_EXPERIMENTAL;
        public const ulong CODEC_CAP_CHANNEL_CONF = AV_CODEC_CAP_CHANNEL_CONF;
        public const ulong CODEC_CAP_NEG_LINESIZES = 0x0800;
        public const ulong CODEC_CAP_FRAME_THREADS = AV_CODEC_CAP_FRAME_THREADS;
        public const ulong CODEC_CAP_SLICE_THREADS = AV_CODEC_CAP_SLICE_THREADS;
        public const ulong CODEC_CAP_PARAM_CHANGE = AV_CODEC_CAP_PARAM_CHANGE;
        public const ulong CODEC_CAP_AUTO_THREADS = AV_CODEC_CAP_AUTO_THREADS;
        public const ulong CODEC_CAP_VARIABLE_FRAME_SIZE = AV_CODEC_CAP_VARIABLE_FRAME_SIZE;
        public const ulong CODEC_CAP_INTRA_ONLY = AV_CODEC_CAP_INTRA_ONLY;
        public const ulong CODEC_CAP_LOSSLESS = AV_CODEC_CAP_LOSSLESS;
        public const ulong HWACCEL_CODEC_CAP_EXPERIMENTAL = 0x0200;
        public const ulong MB_TYPE_INTRA4x4 = 0x0001;
        public const ulong MB_TYPE_INTRA16x16 = 0x0002;
        public const ulong MB_TYPE_INTRA_PCM = 0x0004;
        public const ulong MB_TYPE_16x16 = 0x0008;
        public const ulong MB_TYPE_16x8 = 0x0010;
        public const ulong MB_TYPE_8x16 = 0x0020;
        public const ulong MB_TYPE_8x8 = 0x0040;
        public const ulong MB_TYPE_INTERLACED = 0x0080;
        public const ulong MB_TYPE_DIRECT2 = 0x0100;
        public const ulong MB_TYPE_ACPRED = 0x0200;
        public const ulong MB_TYPE_GMC = 0x0400;
        public const ulong MB_TYPE_SKIP = 0x0800;
        public const ulong MB_TYPE_P0L0 = 0x1000;
        public const ulong MB_TYPE_P1L0 = 0x2000;
        public const ulong MB_TYPE_P0L1 = 0x4000;
        public const ulong MB_TYPE_P1L1 = 0x8000;
        public const ulong MB_TYPE_L0 = (MB_TYPE_P0L0|MB_TYPE_P1L0);
        public const ulong MB_TYPE_L1 = (MB_TYPE_P0L1|MB_TYPE_P1L1);
        public const ulong MB_TYPE_L0L1 = (MB_TYPE_L0|MB_TYPE_L1);
        public const ulong MB_TYPE_QUANT = 0x00010000;
        public const ulong MB_TYPE_CBP = 0x00020000;
        public const ulong FF_QSCALE_TYPE_MPEG1 = 0;
        public const ulong FF_QSCALE_TYPE_MPEG2 = 1;
        public const ulong FF_QSCALE_TYPE_H264 = 2;
        public const ulong FF_QSCALE_TYPE_VP56 = 3;
        public const ulong FF_BUFFER_TYPE_INTERNAL = 1;
        public const ulong FF_BUFFER_TYPE_USER = 2;
        public const ulong FF_BUFFER_TYPE_SHARED = 4;
        public const ulong FF_BUFFER_TYPE_COPY = 8;
        public const ulong FF_BUFFER_HINTS_VALID = 0x01;
        public const ulong FF_BUFFER_HINTS_READABLE = 0x02;
        public const ulong FF_BUFFER_HINTS_PRESERVE = 0x04;
        public const ulong FF_BUFFER_HINTS_REUSABLE = 0x08;
        public const ulong AV_GET_BUFFER_FLAG_REF = (1<<0);
        public const ulong AV_PKT_FLAG_KEY = 0x0001;
        public const ulong AV_PKT_FLAG_CORRUPT = 0x0002;
        public const long FF_COMPRESSION_DEFAULT = -1;
        public const ulong FF_ASPECT_EXTENDED = 15;
        public const ulong FF_RC_STRATEGY_XVID = 1;
        public const ulong FF_PRED_LEFT = 0;
        public const ulong FF_PRED_PLANE = 1;
        public const ulong FF_PRED_MEDIAN = 2;
        public const ulong FF_CMP_SAD = 0;
        public const ulong FF_CMP_SSE = 1;
        public const ulong FF_CMP_SATD = 2;
        public const ulong FF_CMP_DCT = 3;
        public const ulong FF_CMP_PSNR = 4;
        public const ulong FF_CMP_BIT = 5;
        public const ulong FF_CMP_RD = 6;
        public const ulong FF_CMP_ZERO = 7;
        public const ulong FF_CMP_VSAD = 8;
        public const ulong FF_CMP_VSSE = 9;
        public const ulong FF_CMP_NSSE = 10;
        public const ulong FF_CMP_W53 = 11;
        public const ulong FF_CMP_W97 = 12;
        public const ulong FF_CMP_DCTMAX = 13;
        public const ulong FF_CMP_DCT264 = 14;
        public const ulong FF_CMP_CHROMA = 256;
        public const ulong FF_DTG_AFD_SAME = 8;
        public const ulong FF_DTG_AFD_4_3 = 9;
        public const ulong FF_DTG_AFD_16_9 = 10;
        public const ulong FF_DTG_AFD_14_9 = 11;
        public const ulong FF_DTG_AFD_4_3_SP_14_9 = 13;
        public const ulong FF_DTG_AFD_16_9_SP_14_9 = 14;
        public const ulong FF_DTG_AFD_SP_4_3 = 15;
        public const ulong FF_DEFAULT_QUANT_BIAS = 999999;
        public const ulong SLICE_FLAG_CODED_ORDER = 0x0001;
        public const ulong SLICE_FLAG_ALLOW_FIELD = 0x0002;
        public const ulong SLICE_FLAG_ALLOW_PLANE = 0x0004;
        public const ulong FF_MB_DECISION_SIMPLE = 0;
        public const ulong FF_MB_DECISION_BITS = 1;
        public const ulong FF_MB_DECISION_RD = 2;
        public const ulong FF_CODER_TYPE_VLC = 0;
        public const ulong FF_CODER_TYPE_AC = 1;
        public const ulong FF_CODER_TYPE_RAW = 2;
        public const ulong FF_CODER_TYPE_RLE = 3;
        public const ulong FF_CODER_TYPE_DEFLATE = 4;
        public const ulong FF_BUG_AUTODETECT = 1;
        public const ulong FF_BUG_OLD_MSMPEG4 = 2;
        public const ulong FF_BUG_XVID_ILACE = 4;
        public const ulong FF_BUG_UMP4 = 8;
        public const ulong FF_BUG_NO_PADDING = 16;
        public const ulong FF_BUG_AMV = 32;
        public const ulong FF_BUG_AC_VLC = 0;
        public const ulong FF_BUG_QPEL_CHROMA = 64;
        public const ulong FF_BUG_STD_QPEL = 128;
        public const ulong FF_BUG_QPEL_CHROMA2 = 256;
        public const ulong FF_BUG_DIRECT_BLOCKSIZE = 512;
        public const ulong FF_BUG_EDGE = 1024;
        public const ulong FF_BUG_HPEL_CHROMA = 2048;
        public const ulong FF_BUG_DC_CLIP = 4096;
        public const ulong FF_BUG_MS = 8192;
        public const ulong FF_BUG_TRUNCATED = 16384;
        public const ulong FF_COMPLIANCE_VERY_STRICT = 2;
        public const ulong FF_COMPLIANCE_STRICT = 1;
        public const ulong FF_COMPLIANCE_NORMAL = 0;
        public const long FF_COMPLIANCE_UNOFFICIAL = -1;
        public const long FF_COMPLIANCE_EXPERIMENTAL = -2;
        public const ulong FF_EC_GUESS_MVS = 1;
        public const ulong FF_EC_DEBLOCK = 2;
        public const ulong FF_EC_FAVOR_INTER = 256;
        public const ulong FF_DEBUG_PICT_INFO = 1;
        public const ulong FF_DEBUG_RC = 2;
        public const ulong FF_DEBUG_BITSTREAM = 4;
        public const ulong FF_DEBUG_MB_TYPE = 8;
        public const ulong FF_DEBUG_QP = 16;
        public const ulong FF_DEBUG_MV = 32;
        public const ulong FF_DEBUG_DCT_COEFF = 0x00000040;
        public const ulong FF_DEBUG_SKIP = 0x00000080;
        public const ulong FF_DEBUG_STARTCODE = 0x00000100;
        public const ulong FF_DEBUG_PTS = 0x00000200;
        public const ulong FF_DEBUG_ER = 0x00000400;
        public const ulong FF_DEBUG_MMCO = 0x00000800;
        public const ulong FF_DEBUG_BUGS = 0x00001000;
        public const ulong FF_DEBUG_VIS_QP = 0x00002000;
        public const ulong FF_DEBUG_VIS_MB_TYPE = 0x00004000;
        public const ulong FF_DEBUG_BUFFERS = 0x00008000;
        public const ulong FF_DEBUG_THREADS = 0x00010000;
        public const ulong FF_DEBUG_GREEN_MD = 0x00800000;
        public const ulong FF_DEBUG_NOMC = 0x01000000;
        public const ulong FF_DEBUG_VIS_MV_P_FOR = 0x00000001;
        public const ulong FF_DEBUG_VIS_MV_B_FOR = 0x00000002;
        public const ulong FF_DEBUG_VIS_MV_B_BACK = 0x00000004;
        public const ulong AV_EF_CRCCHECK = (1<<0);
        public const ulong AV_EF_BITSTREAM = (1<<1);
        public const ulong AV_EF_BUFFER = (1<<2);
        public const ulong AV_EF_EXPLODE = (1<<3);
        public const ulong AV_EF_IGNORE_ERR = (1<<15);
        public const ulong AV_EF_CAREFUL = (1<<16);
        public const ulong AV_EF_COMPLIANT = (1<<17);
        public const ulong AV_EF_AGGRESSIVE = (1<<18);
        public const ulong FF_DCT_AUTO = 0;
        public const ulong FF_DCT_FASTINT = 1;
        public const ulong FF_DCT_INT = 2;
        public const ulong FF_DCT_MMX = 3;
        public const ulong FF_DCT_ALTIVEC = 5;
        public const ulong FF_DCT_FAAN = 6;
        public const ulong FF_IDCT_AUTO = 0;
        public const ulong FF_IDCT_INT = 1;
        public const ulong FF_IDCT_SIMPLE = 2;
        public const ulong FF_IDCT_SIMPLEMMX = 3;
        public const ulong FF_IDCT_ARM = 7;
        public const ulong FF_IDCT_ALTIVEC = 8;
        public const ulong FF_IDCT_SH4 = 9;
        public const ulong FF_IDCT_SIMPLEARM = 10;
        public const ulong FF_IDCT_IPP = 13;
        public const ulong FF_IDCT_XVID = 14;
        public const ulong FF_IDCT_XVIDMMX = 14;
        public const ulong FF_IDCT_SIMPLEARMV5TE = 16;
        public const ulong FF_IDCT_SIMPLEARMV6 = 17;
        public const ulong FF_IDCT_SIMPLEVIS = 18;
        public const ulong FF_IDCT_FAAN = 20;
        public const ulong FF_IDCT_SIMPLENEON = 22;
        public const ulong FF_IDCT_SIMPLEALPHA = 23;
        public const ulong FF_IDCT_SIMPLEAUTO = 128;
        public const ulong FF_THREAD_FRAME = 1;
        public const ulong FF_THREAD_SLICE = 2;
        public const long FF_PROFILE_UNKNOWN = -99;
        public const long FF_PROFILE_RESERVED = -100;
        public const ulong FF_PROFILE_AAC_MAIN = 0;
        public const ulong FF_PROFILE_AAC_LOW = 1;
        public const ulong FF_PROFILE_AAC_SSR = 2;
        public const ulong FF_PROFILE_AAC_LTP = 3;
        public const ulong FF_PROFILE_AAC_HE = 4;
        public const ulong FF_PROFILE_AAC_HE_V2 = 28;
        public const ulong FF_PROFILE_AAC_LD = 22;
        public const ulong FF_PROFILE_AAC_ELD = 38;
        public const ulong FF_PROFILE_MPEG2_AAC_LOW = 128;
        public const ulong FF_PROFILE_MPEG2_AAC_HE = 131;
        public const ulong FF_PROFILE_DTS = 20;
        public const ulong FF_PROFILE_DTS_ES = 30;
        public const ulong FF_PROFILE_DTS_96_24 = 40;
        public const ulong FF_PROFILE_DTS_HD_HRA = 50;
        public const ulong FF_PROFILE_DTS_HD_MA = 60;
        public const ulong FF_PROFILE_DTS_EXPRESS = 70;
        public const ulong FF_PROFILE_MPEG2_422 = 0;
        public const ulong FF_PROFILE_MPEG2_HIGH = 1;
        public const ulong FF_PROFILE_MPEG2_SS = 2;
        public const ulong FF_PROFILE_MPEG2_SNR_SCALABLE = 3;
        public const ulong FF_PROFILE_MPEG2_MAIN = 4;
        public const ulong FF_PROFILE_MPEG2_SIMPLE = 5;
        public const ulong FF_PROFILE_H264_CONSTRAINED = (1<<9);
        public const ulong FF_PROFILE_H264_INTRA = (1<<11);
        public const ulong FF_PROFILE_H264_BASELINE = 66;
        public const ulong FF_PROFILE_H264_CONSTRAINED_BASELINE = (66|FF_PROFILE_H264_CONSTRAINED);
        public const ulong FF_PROFILE_H264_MAIN = 77;
        public const ulong FF_PROFILE_H264_EXTENDED = 88;
        public const ulong FF_PROFILE_H264_HIGH = 100;
        public const ulong FF_PROFILE_H264_HIGH_10 = 110;
        public const ulong FF_PROFILE_H264_HIGH_10_INTRA = (110|FF_PROFILE_H264_INTRA);
        public const ulong FF_PROFILE_H264_HIGH_422 = 122;
        public const ulong FF_PROFILE_H264_HIGH_422_INTRA = (122|FF_PROFILE_H264_INTRA);
        public const ulong FF_PROFILE_H264_HIGH_444 = 144;
        public const ulong FF_PROFILE_H264_HIGH_444_PREDICTIVE = 244;
        public const ulong FF_PROFILE_H264_HIGH_444_INTRA = (244|FF_PROFILE_H264_INTRA);
        public const ulong FF_PROFILE_H264_CAVLC_444 = 44;
        public const ulong FF_PROFILE_VC1_SIMPLE = 0;
        public const ulong FF_PROFILE_VC1_MAIN = 1;
        public const ulong FF_PROFILE_VC1_COMPLEX = 2;
        public const ulong FF_PROFILE_VC1_ADVANCED = 3;
        public const ulong FF_PROFILE_MPEG4_SIMPLE = 0;
        public const ulong FF_PROFILE_MPEG4_SIMPLE_SCALABLE = 1;
        public const ulong FF_PROFILE_MPEG4_CORE = 2;
        public const ulong FF_PROFILE_MPEG4_MAIN = 3;
        public const ulong FF_PROFILE_MPEG4_N_BIT = 4;
        public const ulong FF_PROFILE_MPEG4_SCALABLE_TEXTURE = 5;
        public const ulong FF_PROFILE_MPEG4_SIMPLE_FACE_ANIMATION = 6;
        public const ulong FF_PROFILE_MPEG4_BASIC_ANIMATED_TEXTURE = 7;
        public const ulong FF_PROFILE_MPEG4_HYBRID = 8;
        public const ulong FF_PROFILE_MPEG4_ADVANCED_REAL_TIME = 9;
        public const ulong FF_PROFILE_MPEG4_CORE_SCALABLE = 10;
        public const ulong FF_PROFILE_MPEG4_ADVANCED_CODING = 11;
        public const ulong FF_PROFILE_MPEG4_ADVANCED_CORE = 12;
        public const ulong FF_PROFILE_MPEG4_ADVANCED_SCALABLE_TEXTURE = 13;
        public const ulong FF_PROFILE_MPEG4_SIMPLE_STUDIO = 14;
        public const ulong FF_PROFILE_MPEG4_ADVANCED_SIMPLE = 15;
        public const ulong FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_0 = 0;
        public const ulong FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_1 = 1;
        public const ulong FF_PROFILE_JPEG2000_CSTREAM_NO_RESTRICTION = 2;
        public const ulong FF_PROFILE_JPEG2000_DCINEMA_2K = 3;
        public const ulong FF_PROFILE_JPEG2000_DCINEMA_4K = 4;
        public const ulong FF_PROFILE_VP9_0 = 0;
        public const ulong FF_PROFILE_VP9_1 = 1;
        public const ulong FF_PROFILE_VP9_2 = 2;
        public const ulong FF_PROFILE_VP9_3 = 3;
        public const ulong FF_PROFILE_HEVC_MAIN = 1;
        public const ulong FF_PROFILE_HEVC_MAIN_10 = 2;
        public const ulong FF_PROFILE_HEVC_MAIN_STILL_PICTURE = 3;
        public const ulong FF_PROFILE_HEVC_REXT = 4;
        public const long FF_LEVEL_UNKNOWN = -99;
        public const long FF_SUB_CHARENC_MODE_DO_NOTHING = -1;
        public const ulong FF_SUB_CHARENC_MODE_AUTOMATIC = 0;
        public const ulong FF_SUB_CHARENC_MODE_PRE_DECODER = 1;
        public const ulong FF_CODEC_PROPERTY_LOSSLESS = 0x00000001;
        public const ulong FF_CODEC_PROPERTY_CLOSED_CAPTIONS = 0x00000002;
        public const ulong AV_HWACCEL_FLAG_IGNORE_LEVEL = (1<<0);
        public const ulong AV_HWACCEL_FLAG_ALLOW_HIGH_DEPTH = (1<<1);
        public const ulong AV_SUBTITLE_FLAG_FORCED = 0x00000001;
        public const ulong AV_PARSER_PTS_NB = 4;
        public const ulong PARSER_FLAG_COMPLETE_FRAMES = 0x0001;
        public const ulong PARSER_FLAG_ONCE = 0x0002;
        public const ulong PARSER_FLAG_FETCHED_OFFSET = 0x0004;
        public const ulong PARSER_FLAG_USE_CODEC_TS = 0x1000;
        private const string libavcodec = "avcodec-56";
        
        [DllImport(libavcodec, EntryPoint = "av_get_cpu_flags", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_cpu_flags();
        
        [DllImport(libavcodec, EntryPoint = "av_force_cpu_flags", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_force_cpu_flags(int @flags);
        
        [DllImport(libavcodec, EntryPoint = "av_set_cpu_flags_mask", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_set_cpu_flags_mask(int @mask);
        
        [DllImport(libavcodec, EntryPoint = "av_parse_cpu_flags", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_parse_cpu_flags([MarshalAs(UnmanagedType.LPStr)] string @s);
        
        [DllImport(libavcodec, EntryPoint = "av_parse_cpu_caps", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_parse_cpu_caps(uint* @flags, [MarshalAs(UnmanagedType.LPStr)] string @s);
        
        [DllImport(libavcodec, EntryPoint = "av_cpu_count", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_cpu_count();
        
        [DllImport(libavcodec, EntryPoint = "av_get_channel_layout", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong av_get_channel_layout([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        [DllImport(libavcodec, EntryPoint = "av_get_channel_layout_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_get_channel_layout_string(IntPtr @buf, int @buf_size, int @nb_channels, ulong @channel_layout);
        
        [DllImport(libavcodec, EntryPoint = "av_bprint_channel_layout", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_bprint_channel_layout(AVBPrint* @bp, int @nb_channels, ulong @channel_layout);
        
        [DllImport(libavcodec, EntryPoint = "av_get_channel_layout_nb_channels", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_channel_layout_nb_channels(ulong @channel_layout);
        
        [DllImport(libavcodec, EntryPoint = "av_get_default_channel_layout", CallingConvention = CallingConvention.Cdecl)]
        public static extern long av_get_default_channel_layout(int @nb_channels);
        
        [DllImport(libavcodec, EntryPoint = "av_get_channel_layout_channel_index", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_channel_layout_channel_index(ulong @channel_layout, ulong @channel);
        
        [DllImport(libavcodec, EntryPoint = "av_channel_layout_extract_channel", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong av_channel_layout_extract_channel(ulong @channel_layout, int @index);
        
        [DllImport(libavcodec, EntryPoint = "av_get_channel_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_get_channel_name(ulong @channel);
        
        [DllImport(libavcodec, EntryPoint = "av_get_channel_description", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_get_channel_description(ulong @channel);
        
        [DllImport(libavcodec, EntryPoint = "av_get_standard_channel_layout", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_standard_channel_layout(uint @index, ulong* @layout, sbyte** @name);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_get_pkt_timebase", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVRational av_codec_get_pkt_timebase(AVCodecContext* @avctx);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_set_pkt_timebase", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_codec_set_pkt_timebase(AVCodecContext* @avctx, AVRational @val);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_get_codec_descriptor", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodecDescriptor* av_codec_get_codec_descriptor(AVCodecContext* @avctx);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_set_codec_descriptor", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_codec_set_codec_descriptor(AVCodecContext* @avctx, AVCodecDescriptor* @desc);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_get_codec_properties", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint av_codec_get_codec_properties(AVCodecContext* @avctx);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_get_lowres", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_codec_get_lowres(AVCodecContext* @avctx);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_set_lowres", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_codec_set_lowres(AVCodecContext* @avctx, int @val);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_get_seek_preroll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_codec_get_seek_preroll(AVCodecContext* @avctx);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_set_seek_preroll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_codec_set_seek_preroll(AVCodecContext* @avctx, int @val);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_get_chroma_intra_matrix", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort* av_codec_get_chroma_intra_matrix(AVCodecContext* @avctx);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_set_chroma_intra_matrix", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_codec_set_chroma_intra_matrix(AVCodecContext* @avctx, ushort* @val);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_get_max_lowres", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_codec_get_max_lowres(AVCodec* @codec);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodec* av_codec_next(AVCodec* @c);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_version", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint avcodec_version();
        
        [DllImport(libavcodec, EntryPoint = "avcodec_configuration", CallingConvention = CallingConvention.Cdecl)]
        public static extern string avcodec_configuration();
        
        [DllImport(libavcodec, EntryPoint = "avcodec_license", CallingConvention = CallingConvention.Cdecl)]
        public static extern string avcodec_license();
        
        [DllImport(libavcodec, EntryPoint = "avcodec_register", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_register(AVCodec* @codec);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_register_all", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_register_all();
        
        [DllImport(libavcodec, EntryPoint = "avcodec_alloc_context3", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodecContext* avcodec_alloc_context3(AVCodec* @codec);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_free_context", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_free_context(AVCodecContext** @avctx);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_get_context_defaults3", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_get_context_defaults3(AVCodecContext* @s, AVCodec* @codec);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_get_class", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVClass* avcodec_get_class();
        
        [DllImport(libavcodec, EntryPoint = "avcodec_get_frame_class", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVClass* avcodec_get_frame_class();
        
        [DllImport(libavcodec, EntryPoint = "avcodec_get_subtitle_rect_class", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVClass* avcodec_get_subtitle_rect_class();
        
        [DllImport(libavcodec, EntryPoint = "avcodec_copy_context", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_copy_context(AVCodecContext* @dest, AVCodecContext* @src);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_alloc_frame", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVFrame* avcodec_alloc_frame();
        
        [DllImport(libavcodec, EntryPoint = "avcodec_get_frame_defaults", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_get_frame_defaults(AVFrame* @frame);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_free_frame", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_free_frame(AVFrame** @frame);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_open2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_open2(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_close", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_close(AVCodecContext* @avctx);
        
        [DllImport(libavcodec, EntryPoint = "avsubtitle_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avsubtitle_free(AVSubtitle* @sub);
        
        [DllImport(libavcodec, EntryPoint = "av_destruct_packet", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_destruct_packet(AVPacket* @pkt);
        
        [DllImport(libavcodec, EntryPoint = "av_init_packet", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_init_packet(AVPacket* @pkt);
        
        [DllImport(libavcodec, EntryPoint = "av_new_packet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_new_packet(AVPacket* @pkt, int @size);
        
        [DllImport(libavcodec, EntryPoint = "av_shrink_packet", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_shrink_packet(AVPacket* @pkt, int @size);
        
        [DllImport(libavcodec, EntryPoint = "av_grow_packet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_grow_packet(AVPacket* @pkt, int @grow_by);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_from_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_packet_from_data(AVPacket* @pkt, sbyte* @data, int @size);
        
        [DllImport(libavcodec, EntryPoint = "av_dup_packet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_dup_packet(AVPacket* @pkt);
        
        [DllImport(libavcodec, EntryPoint = "av_copy_packet", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_copy_packet(AVPacket* @dst, AVPacket* @src);
        
        [DllImport(libavcodec, EntryPoint = "av_copy_packet_side_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_copy_packet_side_data(AVPacket* @dst, AVPacket* @src);
        
        [DllImport(libavcodec, EntryPoint = "av_free_packet", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_free_packet(AVPacket* @pkt);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_new_side_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* av_packet_new_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int @size);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_shrink_side_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_packet_shrink_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int @size);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_get_side_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* av_packet_get_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int* @size);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_merge_side_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_packet_merge_side_data(AVPacket* @pkt);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_split_side_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_packet_split_side_data(AVPacket* @pkt);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_side_data_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_packet_side_data_name(AVPacketSideDataType @type);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_pack_dictionary", CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* av_packet_pack_dictionary(AVDictionary* @dict, int* @size);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_unpack_dictionary", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_packet_unpack_dictionary(sbyte* @data, int @size, AVDictionary** @dict);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_free_side_data", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_packet_free_side_data(AVPacket* @pkt);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_ref", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_packet_ref(AVPacket* @dst, AVPacket* @src);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_unref", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_packet_unref(AVPacket* @pkt);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_move_ref", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_packet_move_ref(AVPacket* @dst, AVPacket* @src);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_copy_props", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_packet_copy_props(AVPacket* @dst, AVPacket* @src);
        
        [DllImport(libavcodec, EntryPoint = "av_packet_rescale_ts", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_packet_rescale_ts(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_find_decoder", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodec* avcodec_find_decoder(AVCodecID @id);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_find_decoder_by_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodec* avcodec_find_decoder_by_name([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_default_get_buffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_default_get_buffer(AVCodecContext* @s, AVFrame* @pic);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_default_release_buffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_default_release_buffer(AVCodecContext* @s, AVFrame* @pic);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_default_reget_buffer", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_default_reget_buffer(AVCodecContext* @s, AVFrame* @pic);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_default_get_buffer2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_default_get_buffer2(AVCodecContext* @s, AVFrame* @frame, int @flags);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_get_edge_width", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint avcodec_get_edge_width();
        
        [DllImport(libavcodec, EntryPoint = "avcodec_align_dimensions", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_align_dimensions(AVCodecContext* @s, int* @width, int* @height);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_align_dimensions2", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_align_dimensions2(AVCodecContext* @s, int* @width, int* @height, [MarshalAs(UnmanagedType.LPArray, SizeConst=8)] int[] @linesize_align);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_enum_to_chroma_pos", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_enum_to_chroma_pos(int* @xpos, int* @ypos, AVChromaLocation @pos);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_chroma_pos_to_enum", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVChromaLocation avcodec_chroma_pos_to_enum(int @xpos, int @ypos);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_decode_audio3", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_decode_audio3(AVCodecContext* @avctx, short* @samples, int* @frame_size_ptr, AVPacket* @avpkt);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_decode_audio4", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_decode_audio4(AVCodecContext* @avctx, AVFrame* @frame, int* @got_frame_ptr, AVPacket* @avpkt);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_decode_video2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_decode_video2(AVCodecContext* @avctx, AVFrame* @picture, int* @got_picture_ptr, AVPacket* @avpkt);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_decode_subtitle2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_decode_subtitle2(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt);
        
        [DllImport(libavcodec, EntryPoint = "av_parser_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodecParser* av_parser_next(AVCodecParser* @c);
        
        [DllImport(libavcodec, EntryPoint = "av_register_codec_parser", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_register_codec_parser(AVCodecParser* @parser);
        
        [DllImport(libavcodec, EntryPoint = "av_parser_init", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodecParserContext* av_parser_init(int @codec_id);
        
        [DllImport(libavcodec, EntryPoint = "av_parser_parse2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_parser_parse2(AVCodecParserContext* @s, AVCodecContext* @avctx, sbyte** @poutbuf, int* @poutbuf_size, sbyte* @buf, int @buf_size, long @pts, long @dts, long @pos);
        
        [DllImport(libavcodec, EntryPoint = "av_parser_change", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_parser_change(AVCodecParserContext* @s, AVCodecContext* @avctx, sbyte** @poutbuf, int* @poutbuf_size, sbyte* @buf, int @buf_size, int @keyframe);
        
        [DllImport(libavcodec, EntryPoint = "av_parser_close", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_parser_close(AVCodecParserContext* @s);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_find_encoder", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodec* avcodec_find_encoder(AVCodecID @id);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_find_encoder_by_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodec* avcodec_find_encoder_by_name([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_encode_audio", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_encode_audio(AVCodecContext* @avctx, sbyte* @buf, int @buf_size, short* @samples);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_encode_audio2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_encode_audio2(AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_encode_video", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_encode_video(AVCodecContext* @avctx, sbyte* @buf, int @buf_size, AVFrame* @pict);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_encode_video2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_encode_video2(AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_encode_subtitle", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_encode_subtitle(AVCodecContext* @avctx, sbyte* @buf, int @buf_size, AVSubtitle* @sub);
        
        [DllImport(libavcodec, EntryPoint = "av_audio_resample_init", CallingConvention = CallingConvention.Cdecl)]
        public static extern ReSampleContext* av_audio_resample_init(int @output_channels, int @input_channels, int @output_rate, int @input_rate, AVSampleFormat @sample_fmt_out, AVSampleFormat @sample_fmt_in, int @filter_length, int @log2_phase_count, int @linear, double @cutoff);
        
        [DllImport(libavcodec, EntryPoint = "audio_resample", CallingConvention = CallingConvention.Cdecl)]
        public static extern int audio_resample(ReSampleContext* @s, short* @output, short* @input, int @nb_samples);
        
        [DllImport(libavcodec, EntryPoint = "audio_resample_close", CallingConvention = CallingConvention.Cdecl)]
        public static extern void audio_resample_close(ReSampleContext* @s);
        
        [DllImport(libavcodec, EntryPoint = "av_resample_init", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVResampleContext* av_resample_init(int @out_rate, int @in_rate, int @filter_length, int @log2_phase_count, int @linear, double @cutoff);
        
        [DllImport(libavcodec, EntryPoint = "av_resample", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_resample(AVResampleContext* @c, short* @dst, short* @src, int* @consumed, int @src_size, int @dst_size, int @update_ctx);
        
        [DllImport(libavcodec, EntryPoint = "av_resample_compensate", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_resample_compensate(AVResampleContext* @c, int @sample_delta, int @compensation_distance);
        
        [DllImport(libavcodec, EntryPoint = "av_resample_close", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_resample_close(AVResampleContext* @c);
        
        [DllImport(libavcodec, EntryPoint = "avpicture_alloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avpicture_alloc(AVPicture* @picture, AVPixelFormat @pix_fmt, int @width, int @height);
        
        [DllImport(libavcodec, EntryPoint = "avpicture_free", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avpicture_free(AVPicture* @picture);
        
        [DllImport(libavcodec, EntryPoint = "avpicture_fill", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avpicture_fill(AVPicture* @picture, sbyte* @ptr, AVPixelFormat @pix_fmt, int @width, int @height);
        
        [DllImport(libavcodec, EntryPoint = "avpicture_layout", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avpicture_layout(AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height, sbyte* @dest, int @dest_size);
        
        [DllImport(libavcodec, EntryPoint = "avpicture_get_size", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avpicture_get_size(AVPixelFormat @pix_fmt, int @width, int @height);
        
        [DllImport(libavcodec, EntryPoint = "avpicture_deinterlace", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avpicture_deinterlace(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height);
        
        [DllImport(libavcodec, EntryPoint = "av_picture_copy", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_picture_copy(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height);
        
        [DllImport(libavcodec, EntryPoint = "av_picture_crop", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_picture_crop(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @top_band, int @left_band);
        
        [DllImport(libavcodec, EntryPoint = "av_picture_pad", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_picture_pad(AVPicture* @dst, AVPicture* @src, int @height, int @width, AVPixelFormat @pix_fmt, int @padtop, int @padbottom, int @padleft, int @padright, int* @color);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_get_chroma_sub_sample", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_pix_fmt_to_codec_tag", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint avcodec_pix_fmt_to_codec_tag(AVPixelFormat @pix_fmt);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_get_pix_fmt_loss", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_find_best_pix_fmt_of_list", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_list(AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_find_best_pix_fmt_of_2", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_find_best_pix_fmt2", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_default_get_format", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVPixelFormat avcodec_default_get_format(AVCodecContext* @s, AVPixelFormat* @fmt);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_set_dimensions", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_set_dimensions(AVCodecContext* @s, int @width, int @height);
        
        [DllImport(libavcodec, EntryPoint = "av_get_codec_tag_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong av_get_codec_tag_string(IntPtr @buf, ulong @buf_size, uint @codec_tag);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_string(IntPtr @buf, int @buf_size, AVCodecContext* @enc, int @encode);
        
        [DllImport(libavcodec, EntryPoint = "av_get_profile_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string av_get_profile_name(AVCodec* @codec, int @profile);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_default_execute", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_default_execute(AVCodecContext* @c, IntPtr* @func, void* @arg, int* @ret, int @count, int @size);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_default_execute2", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_default_execute2(AVCodecContext* @c, IntPtr* @func, void* @arg, int* @ret, int @count);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_fill_audio_frame", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_fill_audio_frame(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, sbyte* @buf, int @buf_size, int @align);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_flush_buffers", CallingConvention = CallingConvention.Cdecl)]
        public static extern void avcodec_flush_buffers(AVCodecContext* @avctx);
        
        [DllImport(libavcodec, EntryPoint = "av_get_bits_per_sample", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_bits_per_sample(AVCodecID @codec_id);
        
        [DllImport(libavcodec, EntryPoint = "av_get_pcm_codec", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodecID av_get_pcm_codec(AVSampleFormat @fmt, int @be);
        
        [DllImport(libavcodec, EntryPoint = "av_get_exact_bits_per_sample", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_exact_bits_per_sample(AVCodecID @codec_id);
        
        [DllImport(libavcodec, EntryPoint = "av_get_audio_frame_duration", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_get_audio_frame_duration(AVCodecContext* @avctx, int @frame_bytes);
        
        [DllImport(libavcodec, EntryPoint = "av_register_bitstream_filter", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_register_bitstream_filter(AVBitStreamFilter* @bsf);
        
        [DllImport(libavcodec, EntryPoint = "av_bitstream_filter_init", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVBitStreamFilterContext* av_bitstream_filter_init([MarshalAs(UnmanagedType.LPStr)] string @name);
        
        [DllImport(libavcodec, EntryPoint = "av_bitstream_filter_filter", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_bitstream_filter_filter(AVBitStreamFilterContext* @bsfc, AVCodecContext* @avctx, [MarshalAs(UnmanagedType.LPStr)] string @args, sbyte** @poutbuf, int* @poutbuf_size, sbyte* @buf, int @buf_size, int @keyframe);
        
        [DllImport(libavcodec, EntryPoint = "av_bitstream_filter_close", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_bitstream_filter_close(AVBitStreamFilterContext* @bsf);
        
        [DllImport(libavcodec, EntryPoint = "av_bitstream_filter_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVBitStreamFilter* av_bitstream_filter_next(AVBitStreamFilter* @f);
        
        [DllImport(libavcodec, EntryPoint = "av_fast_padded_malloc", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_fast_padded_malloc(void* @ptr, uint* @size, ulong @min_size);
        
        [DllImport(libavcodec, EntryPoint = "av_fast_padded_mallocz", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_fast_padded_mallocz(void* @ptr, uint* @size, ulong @min_size);
        
        [DllImport(libavcodec, EntryPoint = "av_xiphlacing", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint av_xiphlacing(sbyte* @s, uint @v);
        
        [DllImport(libavcodec, EntryPoint = "av_log_missing_feature", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_log_missing_feature(void* @avc, [MarshalAs(UnmanagedType.LPStr)] string @feature, int @want_sample);
        
        [DllImport(libavcodec, EntryPoint = "av_log_ask_for_sample", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_log_ask_for_sample(void* @avc, [MarshalAs(UnmanagedType.LPStr)] string @msg);
        
        [DllImport(libavcodec, EntryPoint = "av_register_hwaccel", CallingConvention = CallingConvention.Cdecl)]
        public static extern void av_register_hwaccel(AVHWAccel* @hwaccel);
        
        [DllImport(libavcodec, EntryPoint = "av_hwaccel_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVHWAccel* av_hwaccel_next(AVHWAccel* @hwaccel);
        
        [DllImport(libavcodec, EntryPoint = "av_lockmgr_register", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_lockmgr_register(IntPtr* @cb);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_get_type", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVMediaType avcodec_get_type(AVCodecID @codec_id);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_get_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern string avcodec_get_name(AVCodecID @id);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_is_open", CallingConvention = CallingConvention.Cdecl)]
        public static extern int avcodec_is_open(AVCodecContext* @s);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_is_encoder", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_codec_is_encoder(AVCodec* @codec);
        
        [DllImport(libavcodec, EntryPoint = "av_codec_is_decoder", CallingConvention = CallingConvention.Cdecl)]
        public static extern int av_codec_is_decoder(AVCodec* @codec);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_descriptor_get", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodecDescriptor* avcodec_descriptor_get(AVCodecID @id);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_descriptor_next", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodecDescriptor* avcodec_descriptor_next(AVCodecDescriptor* @prev);
        
        [DllImport(libavcodec, EntryPoint = "avcodec_descriptor_get_by_name", CallingConvention = CallingConvention.Cdecl)]
        public static extern AVCodecDescriptor* avcodec_descriptor_get_by_name([MarshalAs(UnmanagedType.LPStr)] string @name);
        
    }
}
