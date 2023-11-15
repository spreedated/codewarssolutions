using Solutions.Attributes;
using static Solutions.Constants;

namespace Solutions.Kyu8
{
    [Kata("55a70521798b14d4750000a4", PRIMARY_AUTHOR)]
    public static class ReturningStrings
    {
        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }
    }
}
