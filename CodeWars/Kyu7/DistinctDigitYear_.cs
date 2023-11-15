using CodeWars.Attributes;
using System.Linq;

namespace CodeWars.Kyu7
{
    [Kata("58aa68605aab54a26c0001a6")]
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
