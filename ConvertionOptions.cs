using CommandLine;

namespace Converter
{

    [Verb("spell", HelpText = "Convert a spell file.")]
    class ConvertSpellOptions
    {

        [Option('i', "input", Required = true, HelpText = "Input files to be parsed.")]
        public string InputFile { get; set; }

        [Option('o', "output", Default = "output/convertedSpells.json.", HelpText = "Output file.")]
        public string OutputFile { get; set; }


    }


    [Verb("monster", HelpText = "Convert a monster file.")]
    class ConvertMonsterOptions
    {
        [Option('i', "input", Required = true, HelpText = "Input files to be parsed.")]
        public string InputFile { get; set; }


        [Option('o', "output", Default = "output/convertedMonsters.json.", HelpText = "Output file.")]
        public string OutputFile { get; set; }
    }

}