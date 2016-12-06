using System.Collections.Generic;

namespace Converter
{
    public class SkillsExtractor
    {

        public static List<SkillDetail> GetSkills(Monster monster)
        {
            SkillsHelper skillHelper = ExtractSkills(monster);

            return Convert(skillHelper);
        }

        /************ Utility method ************/

        // Intermediate repressentation
        private class SkillsHelper
        {
            //Strength
            public int Athletics { get; set; }

            // Dexterity base
            public int Acrobatics { get; set; }
            public int Sleight_of_hand { get; set; }
            public int Stealth { get; set; }

            // Intelligence base
            public int Arcana { get; set; }
            public int History { get; set; }
            public int Investigation { get; set; }
            public int Nature { get; set; }
            public int Religion { get; set; }

            // Wisdom base
            public int Animal_handling { get; set; }
            public int Insight { get; set; }
            public int Medecine { get; set; }
            public int Perception { get; set; }
            public int Survival { get; set; }

            // Charisma base
            public int Deception { get; set; }
            public int Intimidation { get; set; }
            public int Performance { get; set; }
            public int Persuasion { get; set; }
        }


        // To get default value
        private static int GetValue(string saveValue)
        {
            return int.Parse(saveValue ?? "0");
        }

        private static SkillsHelper ExtractSkills(Monster monster)
        {
            return new SkillsHelper()
            {
                Athletics = GetValue(monster.Athletics),
                Acrobatics = GetValue(monster.Acrobatics),
                Sleight_of_hand = GetValue(monster.Sleight_of_hand),
                Stealth = GetValue(monster.Stealth),
                Arcana = GetValue(monster.Arcana),
                History = GetValue(monster.History),
                Investigation = GetValue(monster.Investigation),
                Nature = GetValue(monster.Nature),
                Religion = GetValue(monster.Religion),
                Animal_handling = GetValue(monster.Animal_handling),
                Insight = GetValue(monster.Insight),
                Medecine = GetValue(monster.Medecine),
                Perception = GetValue(monster.Perception),
                Survival = GetValue(monster.Survival),
                Deception = GetValue(monster.Deception),
                Intimidation = GetValue(monster.Intimidation),
                Performance = GetValue(monster.Performance),
                Persuasion = GetValue(monster.Persuasion),
            };
        }

        private static List<SkillDetail> Convert(SkillsHelper skills)
        {
            var list = new List<SkillDetail>();

            SkillDetail.ConditionnalAdd(list, new SkillDetail("Athletics", "Strength", skills.Acrobatics));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Acrobatics", "Dexterity", skills.Acrobatics));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Sleight of hand", "Dexterity", skills.Sleight_of_hand));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Stealth", "Dexterity", skills.Stealth));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Arcana", "Intelligence", skills.Arcana));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("History", "Intelligence", skills.History));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Investigation", "Intelligence", skills.Investigation));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Nature", "Intelligence", skills.Nature));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Religion", "Intelligence", skills.Religion));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Animal handling", "Wisdom", skills.Animal_handling));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Insight", "Wisdom", skills.Insight));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Medecine", "Wisdom", skills.Medecine));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Survival", "Wisdom", skills.Survival));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Deception", "Charisma", skills.Deception));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Intimidation", "Charisma", skills.Intimidation));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Performance", "Charisma", skills.Performance));
            SkillDetail.ConditionnalAdd(list, new SkillDetail("Persuasion", "Charisma", skills.Persuasion));

            return list;
        }

    }
}