using System.Collections.Generic;
using System.Linq;
using CppSharp.AST;
using FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions;
using MacroDefinition = FFmpeg.AutoGen.CppSharpUnsafeGenerator.Definitions.MacroDefinition;

namespace FFmpeg.AutoGen.CppSharpUnsafeGenerator.Processors
{
    internal class ASTProcessor
    {
        private readonly List<IDefinition> _units = new List<IDefinition>();
        public HashSet<string> IgnoreUnitNames = new HashSet<string>(new[] {"__NSConstantString_tag"});

        public ASTProcessor()
        {
            FunctionProcessor = new FunctionProcessor(this);
            StructureProcessor = new StructureProcessor(this);
            EnumerationProcessor = new EnumerationProcessor(this);
            MacroProcessor = new MacroProcessor(this);
            MacroPostProcessor = new MacroPostProcessor();
        }

        public MacroProcessor MacroProcessor { get; }
        public EnumerationProcessor EnumerationProcessor { get; }
        public StructureProcessor StructureProcessor { get; }
        public FunctionProcessor FunctionProcessor { get; }
        public MacroPostProcessor MacroPostProcessor { get; }

        public Dictionary<string, FunctionExport> FunctionExportMap { get; set; }
        public IReadOnlyList<IDefinition> Units => _units;

        public bool IsKnownUnitName(string name) => _units.Any(x => x.Name == name);

        public T GetUnitByName<T>(string name) where T : IDefinition => _units.OfType<T>().FirstOrDefault(x => x.Name == name);

        public void AddUnit(IDefinition definition)
        {
            if (IgnoreUnitNames.Contains(definition.Name)) return;
            var existing = _units.FirstOrDefault(x => x.Name == definition.Name);
            if (existing != null)
                _units.Remove(existing);
            _units.Add(definition);
        }

        public void ClearUnits() => _units.Clear();

        public void Generate()
        {
        }

        public void Process(IEnumerable<TranslationUnit> units)
        {
            foreach (var translationUnit in units)
            {
                MacroProcessor.Process(translationUnit);
                EnumerationProcessor.Process(translationUnit);
                StructureProcessor.Process(translationUnit);
                FunctionProcessor.Process(translationUnit);
            }

            var macros = Units.OfType<MacroDefinition>().ToArray();
            MacroPostProcessor.Process(macros);
        }
    }
}