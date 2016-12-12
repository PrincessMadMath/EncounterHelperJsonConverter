using System.Collections.Generic;
using Newtonsoft.Json;

namespace Converter
{
    public class SpellOutput
    {
        public int Level { get; set; }

        public string Name { get; set; }

        public string School { get; set; }

        public string CastingTime { get; set; }

        public string Range { get; set; }

        public Components Components { get; set; }

        public bool CanBeRitual { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }

        [JsonProperty(PropertyName = "class")]
        public List<string> Class { get; set; }


        public static SpellOutput Convert(Spell spellToConvert)
        {
            return new SpellOutput()
            {
                Level = spellToConvert.Level,
                Name = CleanName(spellToConvert.Name),
                School = SchoolExtracter.GetSchool(spellToConvert),
                CastingTime = spellToConvert.CastingTime,
                Range = spellToConvert.Range,
                CanBeRitual = CheckIfCanBeRitual(spellToConvert.Name),
                Components = Components.GetComponents(spellToConvert),
                Duration = spellToConvert.Duration,
                Description = Components.TrimDescription(spellToConvert.Description),
                Class = new List<string>() { spellToConvert.Class }
            };
        }

        private static string CleanName(string name)
        {
            return name.Replace("(ritual)", "");
        }

        private static bool CheckIfCanBeRitual(string name)
        {
            return name.ToLower().Contains("ritual");
        }
    }
}