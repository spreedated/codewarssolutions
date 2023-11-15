using Solutions.Attributes;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Kyu8
{
    [Kata("5aa736a455f906981800360d", PRIMARY_AUTHOR)]
    public static class FeastOfManyBeasts
    {
        public static bool Feast(string beast, string dish)
        {
            return beast[0] == dish[0] && beast[^1] == dish[^1];
        }
    }
}
