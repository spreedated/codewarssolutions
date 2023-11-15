using Solutions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kyu6
{
    [Kata("55bf01e5a717a0d57e0000ec")]
    public class PersistentBugger
    {
        public static int Persistence(long n)
        {
            List<long> results = new()
            {
                n
            };

            while (!results.Exists(x => x <= 9))
            {
                long res = int.Parse(results[^1].ToString()[0].ToString());

                foreach (char c in results[^1].ToString().Skip(1))
                {
                    res *= int.Parse(c.ToString());
                }

                results.Add(res);
            }

            return results.Count-1;
        }
    }
}
