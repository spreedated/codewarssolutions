using CodeWars.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.Kyu4
{
    [Kata("52b7ed099cdc285c300001cd")]
    public static class SumOfIntervals
    {
        public static int SumIntervals(Interval[] intervals)
        {
            if (!intervals.Any())
            {
                return 0;
            }

            List<long> res = new();

            foreach (Interval item in intervals)
            {
                if (item.Item1 > item.Item2)
                {
                    res.Add(item.Item1 - item.Item2);
                    continue;
                }
                res.Add(item.Item2 - item.Item1);
            }

            return Convert.ToInt32(res.Sum());
        }

        public class Interval
        {
            public long Item1 { get; set; }
            public long Item2 { get; set; }
            public long Result
            {
                get
                {
                    if (this.Item1 > this.Item2)
                    {
                        return this.Item1 - this.Item2;
                    }
                    return this.Item2 - this.Item1;
                }
            }

            public Interval(long value1, long value2)
            {
                this.Item1 = value1;
                this.Item2 = value2;
            }
        }
    }
}
