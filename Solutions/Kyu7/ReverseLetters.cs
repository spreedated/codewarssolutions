using Solutions.Attributes;
using System;
using System.Linq;

namespace Solutions.Kyu7
{
    [Kata("58b8c94b7df3f116eb00005b")]
    public static class ReverseLetters
    {
        public static string ReverseLetter(string str)
        {
            return new string(str.Where(x => (x >= 'a' && x <= 'z') || (x >= 'A' && x <= 'Z')).Reverse().ToArray());
        }
    }
}
