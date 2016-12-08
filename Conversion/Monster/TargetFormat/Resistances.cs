using System.Collections.Generic;
using System.Linq;

namespace Converter
{
    public class Resistances
    {
        public List<string> DamageVulnerabilities { get; set; }
        public List<string> DamageResistance { get; set; }
        public List<string> DamageImmunities { get; set; }
        public List<string> ConditionImmunities { get; set; }


        private static List<string> GetValue(string resistanceValue)
        {
            if(string.IsNullOrEmpty(resistanceValue))
            {
                return new List<string>();
            }
            return resistanceValue.Split(',').ToList();
        }

        public static Resistances GetResistances(Monster monster)
        {
            return new Resistances()
            {
                DamageVulnerabilities = GetValue(monster.Damage_vulnerabilities),
                DamageResistance = GetValue(monster.Damage_resistances),
                DamageImmunities = GetValue(monster.Damage_immunities),
                ConditionImmunities = GetValue(monster.Condition_immunities),
            };
        }

    }



}