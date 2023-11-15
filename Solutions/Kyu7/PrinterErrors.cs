﻿using Solutions.Attributes;
using System.Linq;

namespace Solutions.Kyu7
{
    [Kata("56541980fa08ab47a0000040")]
    public static class PrinterErrors
    {
        public static string PrinterError(string s)
        {
            return $"{s.Count(x => x >= 'n')}/{s.Length}";
        }
    }
}
