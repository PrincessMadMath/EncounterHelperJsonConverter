using System.Text.RegularExpressions;

namespace Converter
{
    public class SchoolExtracter
    {
        private static Regex upperCaseWord = new Regex(@"([A-Z]\w+)");

        private static string ExtractSchool(string type)
        {
            Match match = upperCaseWord.Match(type);

            if (match.Success)
            {
                var ingredients = match.Groups[1].Value;
                return ingredients;
            }
            else
            {
                return "";
            }
        }
        public static string GetSchool(Spell spell)
        {
            return ExtractSchool(spell.Type);
        }
    }



}