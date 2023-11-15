using Solutions.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Kyu7
{
    [Kata("53dbd5315a3c69eed20002dd")]
    public static class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }
    }
}
