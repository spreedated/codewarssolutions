using Solutions.Attributes;
using System.Collections.Generic;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Kyu7
{
    [Kata("53dbd5315a3c69eed20002dd", PRIMARY_AUTHOR)]
    public static class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }
    }
}
