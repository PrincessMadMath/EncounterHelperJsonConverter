using System.Collections.Generic;

namespace Converter
{
    public class SavingThrowDetail
    {
        public SavingThrowDetail(string name, int modifier)
        {
            Ability = name;
            Modifier = modifier;
        }

        public string Ability { get; set; }
        public int Modifier { get; set; }


        public static void ConditionnalAdd(List<SavingThrowDetail> list, SavingThrowDetail savingThrow)
        {
            if (savingThrow.Modifier != 0)
            {
                list.Add(savingThrow);
            }
        }
    }
}