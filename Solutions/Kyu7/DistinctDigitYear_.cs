using Solutions.Attributes;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Kyu7
{
    [Kata("58aa68605aab54a26c0001a6", PRIMARY_AUTHOR)]
    public static class DistinctDigitYear_
    {
        public static int DistinctDigitYear(int year)
        {
            int res = year + 1;
            while (string.Join("", res.ToString().Distinct()) != res.ToString())
            {
                res++;
            }
            return res;
        }
    }
}
