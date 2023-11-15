using Solutions.Attributes;
using System.Collections.Generic;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Kyu7
{
    [Kata("55b42574ff091733d900002f", PRIMARY_AUTHOR)]
    public static class FriendOrFoe_
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(x => x.Length == 4);
        }
    }
}
