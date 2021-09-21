﻿using System;
using System.CodeDom.Compiler;
using System.Linq;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator
{
    internal class Writer
    {
        private readonly IndentedTextWriter _writer;

        public Writer(IndentedTextWriter writer)
        {
            _writer = writer;
        }

        public void Write(MacroDefinition macro)
        {
            var valid = macro.IsValid ? string.Empty : "// ";
            WriteLine($"{valid}public static {macro.TypeName} {macro.Name} = {macro.Expression};");
        }
        
        public void Write(EnumerationDefinition enumeration)
        {
            WriteSummary(enumeration);
            WriteLine($"public enum {enumeration.Name} : {enumeration.TypeName}");
            using (BeginBlock())
                foreach (var item in enumeration.Items)
                {
                    WriteSummary(item);
                    WriteLine($"@{item.Name} = {item.Value},");
                }
        }

        public void Write(StructureDefinition structure)
        {
            WriteSummary(structure);
            WriteLine($"public unsafe struct {structure.Name}");
            using (BeginBlock())
            {
                Func<StructureField, string> toString = x => x.FieldType.IsFixed
                    ? $"public fixed {x.FieldType.Name} @{x.Name}[{x.FieldType.FixedSize}];"
                    : $"public {x.FieldType.Name} @{x.Name};";

                var indexer = structure.Indexer;
                if (indexer == null)
                {
                    foreach (var item in structure.Fileds)
                    {
                        WriteSummary(item);
                        WriteLine(toString(item));
                    }
                }
                else
                {
                    var size = indexer.FieldType.FixedSize;
                    var prefix = indexer.FieldPrefix;

                    WriteLine(string.Join(" ", structure.Fileds.Select(toString)));

                    WriteLine();

                    WriteLine($"public {indexer.FieldType.Name} this[int index]");
                    using (BeginBlock())
                    {
                        var getCases = Enumerable.Range(0, size).Select(i => $"case {i}: return {prefix}{i};");
                        WriteLine($"get {{ switch (index) {{{string.Join(" ", getCases)} default: throw new ArgumentOutOfRangeException(); }}}}");
                        var setCases = Enumerable.Range(0, size).Select(i => $"case {i}: {prefix}{i} = value; return;");
                        WriteLine($"set {{ switch (index) {{{string.Join(" ", setCases)} default: throw new ArgumentOutOfRangeException(); }}}}");
                    }

                    WriteLine();

                    var fields = Enumerable.Range(0, size).Select(i => $"{prefix}{i}");
                    WriteLine($"public {indexer.FieldType.Name}[] ToArray() => new[] {{{string.Join(", ", fields)}}};");
                }

                var @delegate = structure.Delegate;
                if (@delegate != null)
                {
                    WriteLine($"public IntPtr Pointer;");
                    Write($"public static implicit operator {structure.Name}({@delegate.Name} func) => ");
                    Write($"new {structure.Name} {{ Pointer = Marshal.GetFunctionPointerForDelegate(func) }};");
                    WriteLine();
                }
            }
        }

        public void Write(FunctionDefinition function)
        {
            WriteSummary(function);
            function.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
            if (function.IsObsolete) WriteLine("[Obsolete]");
            WriteLine($"[DllImport(\"{function.LibraryName}\", EntryPoint = \"{function.Name}\", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]");
            function.ReturnType.Attributes.ToList().ForEach(WriteLine);
            var parameters = GetParameters(function.Parameters);
            WriteLine($"public static extern {function.ReturnType.Name} {function.Name}({parameters});");
        }

        public void Write(DelegateDefinition @delegate)
        {
            WriteSummary(@delegate);
            @delegate.Parameters.ToList().ForEach(x => WriteParam(x, x.Name));
            WriteSummary(@delegate);
            var parameters = GetParameters(@delegate.Parameters);
            WriteLine("[UnmanagedFunctionPointer(CallingConvention.Cdecl)]");
            WriteLine($"public unsafe delegate {@delegate.ReturnType.Name} {@delegate.Name} ({parameters});");
        }

        private static string GetParameters(FunctionParameter[] parameters)
        {
            return string.Join(", ", parameters.Select(x =>
                x.Type.Attributes.Any()
                    ? $"{string.Join("", x.Type.Attributes)} {x.Type.Name} @{x.Name}"
                    : $"{x.Type.Name} @{x.Name}"));
        }

        private void WriteSummary(ICanGenerateXmlDoc value)
        {
            if (!string.IsNullOrWhiteSpace(value.Content)) WriteLine($"/// <summary>{value.Content.Trim()}</summary>");
        }

        private void WriteParam(ICanGenerateXmlDoc value, string name)
        {
            if (!string.IsNullOrWhiteSpace(value.Content)) WriteLine($"/// <param name=\"{name}\">{value.Content.Trim()}</param>");
        }

        private void WriteLine() => _writer.WriteLine();
        private void WriteLine(string line) => _writer.WriteLine(line);
        private void Write(string value) => _writer.Write(value);
        private IDisposable BeginBlock() => _writer.BeginBlock();
    }
}