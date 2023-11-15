using Solutions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Solutions.Constants;

namespace Solutions.Kyu5
{
    [Kata("526989a41034285187000de4", PRIMARY_AUTHOR)]
    public class CountIpAddresses
    {
        public static long IpsBetween(string start, string end)
        {
            string startAhex = $"0x{string.Join("", start.Split('.').SelectMany(x => int.Parse(x).ToString("x2")))}";
            string endAhex = $"0x{string.Join("", end.Split('.').SelectMany(x => int.Parse(x).ToString("x2")))}";

            return Convert.ToInt64(endAhex, 16) - Convert.ToInt64(startAhex, 16);
        }
    }
}
