using Solutions.Attributes;
using System;
using static Solutions.Constants;

namespace Solutions.Kyu7
{
    [Kata("52b5247074ea613a09000164", PRIMARY_AUTHOR)]
    public static class BoiledEggs
    {
        public static int CookingTime(int eggs)
        {
            float potMaxFill = 8;
            int minutesToBoil = 5;

            return (int)Math.Ceiling(eggs / potMaxFill) * minutesToBoil;
        }
    }
}
