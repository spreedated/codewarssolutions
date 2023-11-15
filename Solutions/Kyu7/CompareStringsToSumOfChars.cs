using Solutions.Attributes;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Kyu7
{
    [Kata("576bb3c4b1abc497ec000065", PRIMARY_AUTHOR)]
    public static class CompareStringsToSumOfChars
    {
        public static bool Compare(string s1, string s2)
        {
            if ((string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) || (!s1.Any(x => x >= 'a' && x <= 'z' || x >= 'A' && x <= 'Z') && !s2.Any(x => x >= 'a' && x <= 'z' || x >= 'A' && x <= 'Z')))
            {
                return true;
            }

            if (s1.ToUpper().Select(x => x).Sum(x => x) == s2.ToUpper().Select(x => x).Sum(x => x))
            {
                return true;
            }

            return false;
        }
    }
}
