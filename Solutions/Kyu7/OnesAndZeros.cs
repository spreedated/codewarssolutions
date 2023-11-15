using Solutions.Attributes;
using System;
using System.Linq;

namespace Solutions.Kyu7
{
    [Kata("578553c3a1b8d5c40300037c")]
    public static class OnesAndZeros
    {
        public static int BinaryArrayToNumber(int[] BinaryArray)
        {
            int res = 0;
            for (int i = 0; i < BinaryArray.Length; i++)
            {
                if (BinaryArray.Reverse().ToArray()[i] == 1)
                {
                    res += Convert.ToInt16(Math.Pow(2, i));
                }
            }

            return res;
        }
    }
}
