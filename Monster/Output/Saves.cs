namespace Converter
{
    public class Saves
    {

        public int StrengthSave { get; set; }
        public int DexteritySave { get; set; }

        public int ConstitutionSave { get; set; }

        public int IntelligenceSave { get; set; }

        public int WisdomSave { get; set; }

        public int CharismaSave { get; set; }

        private static int GetValue(string saveValue)
        {
            return int.Parse(saveValue ?? "0");
        }

        public static Saves GetSave(Monster monster)
        {
            return new Saves()
            {
                StrengthSave = GetValue(monster.Strength_save),
                DexteritySave = GetValue(monster.Dexterity_save),
                ConstitutionSave = GetValue(monster.Constitution_save),
                IntelligenceSave = GetValue(monster.Intelligence_save),
                WisdomSave = GetValue(monster.Wisdom_save),
                CharismaSave = GetValue(monster.Charisma_save)
            };
        }

    }



}