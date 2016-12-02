namespace Converter
{
    public class Skills
    {

        // Strength
        public int Acrobatics { get; set; }

        // Dexterity base
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


        private static int GetValue(string saveValue)
        {
            return int.Parse(saveValue ?? "0");
        }

        public static Skills GetSkills(Monster monster)
        {
            return new Skills()
            {
                Acrobatics = GetValue(monster.Acrobatics),
                Sleight_of_hand = GetValue(monster.Sleight_of_hand),
                Stealth = GetValue(monster.Stealth),
                Arcana = GetValue(monster.Arcana),
                History = GetValue(monster.History),
                Investigation = GetValue(monster.Investigation),
                Nature = GetValue(monster.Nature),
                Religion =GetValue( monster.Religion),
                Animal_handling =GetValue( monster.Animal_handling),
                Insight =GetValue( monster.Insight),
                Medecine = GetValue(monster.Medecine),
                Perception = GetValue(monster.Perception),
                Survival = GetValue(monster.Survival),
                Deception =GetValue( monster.Deception),
                Intimidation =GetValue( monster.Intimidation),
                Performance =GetValue( monster.Performance),
                Persuasion = GetValue(monster.Persuasion),
            };
        }

    }
}