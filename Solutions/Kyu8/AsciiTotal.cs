using Solutions.Attributes;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Kyu8
{
    [Kata("572b6b2772a38bc1e700007a", PRIMARY_AUTHOR)]
    public static class AsciiTotal
    {
        public static int UniTotal(string str)
        {
            return str.Sum(c => (int)c);
        }
    }
}
