using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Converter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            if(args.Count() != 2)
            {
                Console.WriteLine("Need 2 arguments");
                return;
            }

            // Path to input to convert
            var path = args[0];

            // m : monster
            // s : spell
            var type = args[1];
            */

            // Path to input to convert
            var path = @"data/Spells.json";

            // m : monster
            // s : spell
            var type = "s";


            var text = System.IO.File.ReadAllText(path);

            if(type == "s")
            {
                ConvertSpells(text);
            }
            else{
                ConvertMonster(text);
            }

        }


        private static void ConvertSpells(string text)
        {
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
                    convertedSpells.Add(spelloutput.Name, spelloutput);
                }
            }

            var cleanSpells = JsonConvert.SerializeObject(convertedSpells.Values.ToList());
            System.IO.File.WriteAllText("output/cleanSpells.json", cleanSpells);
        }


        private static void ConvertMonster(string text)
        {
            var monsters = JsonConvert.DeserializeObject<List<Monster>>(text);

            var convertedMonsters = new List<MonsterOutput>();

            foreach (var monster in monsters)
            {
                    var  monsterOutput = MonsterOutput.Convert(monster);
                    convertedMonsters.Add(monsterOutput);
            }

            var converted = JsonConvert.SerializeObject(convertedMonsters);
            System.IO.File.WriteAllText("output/cleanMonsters.json", converted);
        }
    }
}
