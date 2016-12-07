using System.Collections.Generic;

namespace Converter
{

    public class Monster
    {

        public string Challenge_rating { get; set; }
        public string Name { get; set; }

        public string Size { get; set; }
        public string Type { get; set; }

        public string Subtype { get; set; }

        public string Alignment { get; set; }

        public string Armor_class { get; set; }

        public string Hit_points { get; set; }

        public string Hit_dice { get; set; }

        public string Speed { get; set; }

        // Stats
        
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }


        // Saving throw
        public string Strength_save { get; set; }
        public string Dexterity_save { get; set; }
        public string Constitution_save { get; set; }
        public string Intelligence_save { get; set; }
        public string Wisdom_save { get; set; }
        public string Charisma_save { get; set; }


        // Skills

        //** strength
        public string Athletics { get; set; }

        //** dexterity
         public string Acrobatics { get; set; }
        public string Sleight_of_hand { get; set; }
        public string Stealth { get; set; }

        //** intelligence
        public string Arcana { get; set; }
        public string History { get; set; }
        public string Investigation { get; set; }
        public string Nature { get; set; }
        public string Religion { get; set; }

        //** wisdom

        public string Animal_handling { get; set; }
        public string Insight { get; set; }
        public string Medecine { get; set; }
        public string Perception { get; set; }
        public string Survival { get; set; }

        //** charisma
        public string Deception { get; set; }
        public string Intimidation { get; set; }
        public string Performance { get; set; }
        public string Persuasion { get; set; }


        // Sensibility
        public string Damage_vulnerabilities { get; set; }
        public string Damage_resistances { get; set; }
        public string Damage_immunities { get; set; }
        public string Condition_immunities { get; set; }

        //
        public List<SpecialAbility> Special_Abilities {get; set;}
        public List<Action> Actions { get; set; }

        public List<SpecialAbility> Legendary_Actions { get; set; }


        // Other
        public string Senses { get; set; }
        public string Languages { get; set; }


    }

}