using System.Collections.Generic;

namespace Converter
{
    public class SkillDetail
    {
        public SkillDetail(string name, string baseAbility, int modifier)
        {
            Name = name;
            BaseAbility = baseAbility;
            Modifier = modifier;
        }

        public string Name { get; set; }
        public string BaseAbility { get; set; }
        public int Modifier { get; set; }


        public static void ConditionnalAdd(List<SkillDetail> list, SkillDetail skill)
        {
            if (skill.Modifier != 0)
            {
                list.Add(skill);
            }
        }

    }
}