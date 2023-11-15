using Solutions.Attributes;
using System.Collections.Generic;
using System.Linq;
using static Solutions.Constants;

namespace Solutions.Own
{
    [Kata("Readings Overtime", PRIMARY_AUTHOR)]
    public static class ReadingsOvertime
    {
        public static long CalculateReadings(IEnumerable<long> readingsLog)
        {
            long sum = 0;
            long buff = 0;
            foreach (long r in readingsLog)
            {
                if (r < buff)
                {
                    sum += buff;
                }
                buff = r;
            }
            sum += readingsLog.Last();

            return sum;
        }
    }
}
