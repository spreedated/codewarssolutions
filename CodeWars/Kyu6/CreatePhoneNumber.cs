using CodeWars.Attributes;
using System.Linq;

namespace CodeWars.Kyu6
{
    [Kata("525f50e3b73515a6db000b83")]
    public static class CreatePhoneNumber_
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({string.Join("", numbers.Take(3))}) {string.Join("", numbers.Skip(3).Take(3))}-{string.Join("", numbers.Skip(6))}";
        }
    }
}
