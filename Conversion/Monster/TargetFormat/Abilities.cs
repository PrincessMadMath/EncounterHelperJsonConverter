namespace Converter
{
    public class Abilities
    {

        public int Strength { get; set; }
        public int Dexterity { get; set; }

        public int Constitution { get; set; }

        public int Intelligence { get; set; }

        public int Wisdom { get; set; }

        public int Charisma { get; set; }


        private static int GetValue(string abilityValue)
        {
            return int.Parse(abilityValue ?? "10");
        }

        public static Abilities GetAbility(Monster monster)
        {
            return new Abilities()
            {
                Strength = GetValue(monster.Strength),
                Dexterity = GetValue(monster.Dexterity),
                Constitution = GetValue(monster.Constitution),
                Intelligence = GetValue(monster.Intelligence),
                Wisdom = GetValue(monster.Wisdom),
                Charisma = GetValue(monster.Charisma)
            };
        }
    }



}