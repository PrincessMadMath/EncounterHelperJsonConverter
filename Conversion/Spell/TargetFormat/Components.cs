using System;
using System.Text.RegularExpressions;

namespace Converter
{
    public class Components
    {
        private static Regex ingredientRetriever = new Regex(@"^\((.*)\)");
        private static Regex goldRetriver = new Regex(@"(\d+,?\d+)\s*gp");

        public bool Somatic { get; set; }
        public bool Verbal { get; set; }

        public bool Material { get; set; }

        public string Ingredients { get; set; }

        public int RequiredGold { get; set; }


        public static string TrimDescription(string description)
        {
            Match match = ingredientRetriever.Match(description);

            if (match.Success)
            {
                var ingredients = match.Groups[0].Value;
                return description.Replace(ingredients, string.Empty).Trim();
            }
            else
            {
                return description;
            }
        }

        private static string GetIngredients(string description)
        {
            Match match = ingredientRetriever.Match(description);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return "";
            }
        }

        private static int GetGoldRequirement(string description)
        {
            Match match = goldRetriver.Match(description);

            if (match.Success)
            {
                var gold = match.Groups[1].Value.Replace(",", "");
                return int.Parse(gold);
            }
            else
            {
                return 0;
            }
        }

        public static Components GetComponents(Spell spell)
        {
            bool needMaterial = spell.Components.Contains("M");

            return new Components()
            {
                Somatic = spell.Components.Contains("S"),
                Verbal = spell.Components.Contains("V"),
                Material = needMaterial,
                Ingredients = needMaterial ? GetIngredients(spell.Description) : "",
                RequiredGold = needMaterial ? GetGoldRequirement(spell.Description) : 0
            };
        }
    }



}