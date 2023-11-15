using CodeWars.Attributes;
using System;
using System.Linq;

namespace CodeWars.Kyu7
{
    [Kata("54ba84be607a92aa900000f1")]
    public static class Isograms
    {
        public static bool IsIsogram(string str)
        {
            return string.Join("", str.ToLower().Distinct()).SequenceEqual(str.ToLower());
        }
    }
}
