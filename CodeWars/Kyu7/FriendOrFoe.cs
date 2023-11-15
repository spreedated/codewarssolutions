using CodeWars.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Kyu7
{
    [Kata("55b42574ff091733d900002f")]
    public static class FriendOrFoe_
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(x => x.Length == 4);
        }
    }
}
