using Solutions.Attributes;
using System;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Kyu7
{
    [Kata("58b8c94b7df3f116eb00005b", PRIMARY_AUTHOR)]
    public static class ReverseLetters
    {
        public static string ReverseLetter(string str)
        {
            return new string(str.Where(x => (x >= 'a' && x <= 'z') || (x >= 'A' && x <= 'Z')).Reverse().ToArray());
        }
    }
}
