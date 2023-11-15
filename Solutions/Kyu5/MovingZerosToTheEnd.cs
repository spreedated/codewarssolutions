using Solutions.Attributes;
using System.Linq;

namespace Solutions.Kyu5
{
    [Kata("52597aa56021e91c93000cb0")]
    public static class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
        }
    }
}
