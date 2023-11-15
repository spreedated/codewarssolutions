using CodeWars.Attributes;

namespace CodeWars.Kyu1
{
    [Kata("59568be9cc15b57637000054", false)]
    public static class BecomeImmortal
    {
        public static long ElderAge(long n, long m, long k, long newp)
        {
            long[,] magic = new long[m, n];

            for (long i = 0; i < m; i++)
            {
                for (long j = 0; j < n; j++)
                {
                    magic[i, j] = j - k < 0 ? 0 : j - k;
                }
            }

            long s = 0;

            for (int i = 0; i < magic.GetLength(1); i++)
            {
                s += magic[0, i];
            }

            return (s * m) - newp < 0 ? (s * m) : (s * m) - newp;
        }
    }
}
