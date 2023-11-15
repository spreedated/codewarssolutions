using Solutions.Attributes;
using System;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Kyu7
{
    [Kata("54ba84be607a92aa900000f1", PRIMARY_AUTHOR)]
    public static class Isograms
    {
        public static bool IsIsogram(string str)
        {
            return string.Join("", str.ToLower().Distinct()).SequenceEqual(str.ToLower());
        }
    }
}
