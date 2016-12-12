using System;
using System.Collections.Generic;
using System.Linq;
using CommandLine;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Converter
{

    [Verb("add", HelpText = "Add file contents to the index.")]
    class AddOptions
    {
        //normal options here
    }
    [Verb("commit", HelpText = "Record changes to the repository.")]
    class CommitOptions
    {
        //normal options here
    }
    [Verb("clone", HelpText = "Clone a repository into a new directory.")]
    class CloneOptions
    {
        //normal options here
    }

    public class Program
    {
        private static JsonSerializerSettings settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

        public static int Main(string[] args)
        {
            return CommandLine.Parser.Default.ParseArguments<ConvertSpellOptions, ConvertMonsterOptions>(args)
                .MapResult(
                (ConvertSpellOptions opts) => ConvertSpells(opts),
                (ConvertMonsterOptions opts) => ConvertMonster(opts),
                errs => 1);

        }

        private static int ConvertSpells(ConvertSpellOptions options)
        {
            try
            {
                var text = System.IO.File.ReadAllText(options.InputFile);

                var spells = JsonConvert.DeserializeObject<List<Spell>>(text);

                var convertedSpells = new Dictionary<string, SpellOutput>();

                foreach (var spell in spells)
                {
                    SpellOutput spelloutput;
                    if (convertedSpells.TryGetValue(spell.Name, out spelloutput))
                    {
                        spelloutput.Class.Add(spell.Class);
                    }
                    else
                    {
                        spelloutput = SpellOutput.Convert(spell);
                        convertedSpells.Add(spell.Name, spelloutput);
                    }
                }

                var convertedSpellsJson = JsonConvert.SerializeObject(convertedSpells.Values.ToList(), settings);
                System.IO.File.WriteAllText(options.OutputFile, convertedSpellsJson);

                Console.WriteLine($"Convertion of {convertedSpells.Count()} spells completed successfully!");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception in spell conversion:");
                Console.WriteLine(e);
            }


            return 0;
        }


        private static int ConvertMonster(ConvertMonsterOptions options)
        {
            try
            {
                var text = System.IO.File.ReadAllText(options.InputFile);

                var monsters = JsonConvert.DeserializeObject<List<Monster>>(text);

                var convertedMonsters = new List<MonsterOutput>();

                foreach (var monster in monsters)
                {
                    var monsterOutput = MonsterOutput.Convert(monster);
                    convertedMonsters.Add(monsterOutput);
                }



                var convertedMonstersJson = JsonConvert.SerializeObject(convertedMonsters, settings);
                System.IO.File.WriteAllText(options.OutputFile, convertedMonstersJson);

                Console.WriteLine($"Convertion of {convertedMonsters.Count()} monsters completed successfully!");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception in monster conversion:");
                Console.WriteLine(e);
                return 1;
            }

            return 0;
        }
    }
}
