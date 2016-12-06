using System.Collections.Generic;

namespace Converter
{
    public class SavingThrow
    {

        public static List<SavingThrowDetail> GetSave(Monster monster)
        {
            SavesHelper save = ExtractSave(monster);

            return Convert(save);
        }


        /************ Utility method ************/

        // Intermediate representation
        private class SavesHelper
        {
            public int StrengthSave { get; set; }
            public int DexteritySave { get; set; }

            public int ConstitutionSave { get; set; }

            public int IntelligenceSave { get; set; }

            public int WisdomSave { get; set; }

            public int CharismaSave { get; set; }
        }


        private static SavesHelper ExtractSave(Monster monster)
        {
            return new SavesHelper()
            {
                StrengthSave = GetValue(monster.Strength_save),
                DexteritySave = GetValue(monster.Dexterity_save),
                ConstitutionSave = GetValue(monster.Constitution_save),
                IntelligenceSave = GetValue(monster.Intelligence_save),
                WisdomSave = GetValue(monster.Wisdom_save),
                CharismaSave = GetValue(monster.Charisma_save)
            };
        }

        // To get default value if not found 
        private static int GetValue(string saveValue)
        {
            return int.Parse(saveValue ?? "0");
        }

        private static List<SavingThrowDetail> Convert(SavesHelper save)
        {
            var list = new List<SavingThrowDetail>();
            SavingThrowDetail.ConditionnalAdd(list, new SavingThrowDetail("Strength", save.StrengthSave));
            SavingThrowDetail.ConditionnalAdd(list, new SavingThrowDetail("Dexterity", save.DexteritySave));
            SavingThrowDetail.ConditionnalAdd(list, new SavingThrowDetail("Constitution", save.ConstitutionSave));
            SavingThrowDetail.ConditionnalAdd(list, new SavingThrowDetail("Intelligence", save.IntelligenceSave));
            SavingThrowDetail.ConditionnalAdd(list, new SavingThrowDetail("Wisdom", save.WisdomSave));
            SavingThrowDetail.ConditionnalAdd(list, new SavingThrowDetail("Charisma", save.CharismaSave));

            return list;
        }

      


    }



}