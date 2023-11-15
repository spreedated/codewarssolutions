using Solutions.Attributes;
using System.Linq;

namespace Solutions.Kyu7
{
    [Kata("55908aad6620c066bc00002a")]
    public static class ExesAndOhs
    {
        public static bool XO(string input)
        {
            return input.ToLower().Count(x => x == 'o') == input.ToLower().Count(x => x == 'x');
        }
    }
}
