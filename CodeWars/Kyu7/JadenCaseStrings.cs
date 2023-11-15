using CodeWars.Attributes;
using System.Linq;

namespace CodeWars.Kyu7
{
    [Kata("5390bac347d09b7da40006f6")]
    public static class JadenCaseStrings
    {
        public static string ToJadenCase(this string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
            {
                return "";
            }
            return string.Join(' ', phrase.Split(' ').Select(x => $"{x[0].ToString().ToUpper()}{x[1..].ToString().ToLower()}"));
        }
    }
}
