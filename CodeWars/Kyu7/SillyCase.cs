using CodeWars.Attributes;
using System;
using System.Linq;

namespace CodeWars.Kyu7
{
    [Kata("552ab0a4db0236ff1a00017a")]
    public static class SillyCase_
    {
        public static string SillyCase(string str)
        {
            return string.Join("", str.Take((int)Math.Ceiling((float)str.Length / 2)).Select(x => Convert.ToString(x).ToLower()).Concat(str.Skip((int)Math.Ceiling((float)str.Length / 2)).Select(x => Convert.ToString(x).ToUpper())));
        }
    }
}
