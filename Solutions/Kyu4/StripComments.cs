using Solutions.Attributes;
using System;
using System.Linq;
using System.Text;
using static Solutions.Constants;

namespace Solutions.Kyu4
{
    [Kata("51c8e37cee245da6b40000bd", PRIMARY_AUTHOR)]
    public static class StripComments_
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            StringBuilder s = new();

            foreach (string line in text.Split('\n'))
            {
                if (!line.Any(x => commentSymbols.Select(x => x[0]).Contains(x)))
                {
                    s.Append(line.TrimEnd() + '\n');
                    continue;
                }
                s.Append(line[..line.IndexOfAny(commentSymbols.Select(x => x[0]).ToArray())].TrimEnd() + '\n');
            }

            return s.ToString().EndsWith('\n') ? s.ToString()[..s.ToString().LastIndexOf('\n')] : s.ToString();
        }
    }
}
