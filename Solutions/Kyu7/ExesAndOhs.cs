using Solutions.Attributes;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Kyu7
{
    [Kata("55908aad6620c066bc00002a", PRIMARY_AUTHOR)]
    public static class ExesAndOhs
    {
        public static bool XO(string input)
        {
            return input.ToLower().Count(x => x == 'o') == input.ToLower().Count(x => x == 'x');
        }
    }
}
