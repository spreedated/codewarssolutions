using CodeWars.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kyu7
{
    [Kata("52b5247074ea613a09000164")]
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
