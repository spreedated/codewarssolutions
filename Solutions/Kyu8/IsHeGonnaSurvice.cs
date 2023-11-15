using Solutions.Attributes;
using static Solutions.Constants;

namespace Solutions.Kyu8
{
    [Kata("59ca8246d751df55cc00014c", PRIMARY_AUTHOR)]
    public static class IsHeGonnaSurvice
    {
        public static bool Hero(int bullets, int dragons)
        {
            return bullets >= dragons*2;
        }
    }
}
