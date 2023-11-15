using Solutions.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Kyu7
{
    [Kata("5886c6b2f3b6ae33dd0000be")]
    public static class FirstReverseTry_
    {
        public static int[] FirstReverseTry(int[] arr)
        {
            List<int> ret = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!ret.Any())
                {
                    ret.Add(arr[arr.Length - 1]);
                    continue;
                }
                if (i == arr.Length - 1)
                {
                    ret.Add(arr[0]);
                    continue;
                }
                ret.Add(arr[i]);
            }

            return ret.ToArray();
        }
    }
}
