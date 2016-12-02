using System.Collections.Generic;
using Newtonsoft.Json;

namespace Converter
{
    public class MonsterOutput
    {

        public string ChallengeRating { get; set; }
        public string Name { get; set; }

        public string Size { get; set; }
        public string Type { get; set; }

        public string Subtype { get; set; }

        public string Alignment { get; set; }

        public int ArmorClass { get; set; }

        public int HitPoints { get; set; }

        public string Hit_dice { get; set; }

        public string Speed { get; set; }

        // Stats
        public Abilities Abilities { get; set; }


        // Saving throw
        public Saves Saves { get; set; }

        // Skills
        public Skills Skills {get; set;}


        // Resistances
        public Resistances Resistances { get; set; }

        //
        public List<Special_Ability> SpecialAbilities { get; set; }
        public List<Action> Actions { get; set; }

        public List<Special_Ability> LegendaryAbilities { get; set; }


        // Other
        public string Senses { get; set; }
        public string Languages { get; set; }

        public static MonsterOutput Convert(Monster monsterToConvert)
        {


            return new MonsterOutput()
            {
                ChallengeRating = monsterToConvert.Challenge_rating,
                Name = monsterToConvert.Name,
                Size = monsterToConvert.Size,
                Type = monsterToConvert.Type,
                Subtype = monsterToConvert.Subtype,
                Alignment = monsterToConvert.Alignment,

                // Enconter stat
                ArmorClass = int.Parse(monsterToConvert.Armor_class ?? "10"),
                HitPoints = int.Parse(monsterToConvert.Hit_points),
                Hit_dice = monsterToConvert.Hit_dice,
                Speed = monsterToConvert.Speed,

                // Stats
                Abilities = Abilities.GetAbility(monsterToConvert),


                // Saving throw
                Saves = Saves.GetSave(monsterToConvert),

                // Skills
                Skills = Skills.GetSkills(monsterToConvert),

                // Resistance and other
                Resistances = Resistances.GetResistances(monsterToConvert), 

                // Actions and abilities
                SpecialAbilities = monsterToConvert.Special_Abilities,
                Actions = monsterToConvert.Actions,
                LegendaryAbilities = monsterToConvert.Legendary_Abilities,

                // Others
                Senses = monsterToConvert.Senses,
                Languages = monsterToConvert.Languages,



            };
        }

    }

}