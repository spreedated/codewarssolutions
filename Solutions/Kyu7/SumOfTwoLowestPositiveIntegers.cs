using Solutions.Attributes;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Kyu7
{
    [Kata("558fc85d8fd1938afb000014", PRIMARY_AUTHOR)]
    public static class SumOfTwoLowestPositiveIntegers
    {
        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(x => x).Take(2).Sum();
        }
    }
}
