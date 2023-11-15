using Solutions.Attributes;

namespace Solutions.Kyu7
{
    [Kata("5669a5113c8ebf16ed00004c")]
    public static class CommonSubstrings
    {
        public static bool SubstringTest(string str1, string str2)
        {
            string shortStr = str1.Length > str2.Length ? str2.ToLower() : str1.ToLower();
            string longStr = str1.Length > str2.Length ? str1.ToLower() : str2.ToLower();

            for (int i = 0; i < shortStr.Length - 1; i++)
            {
                if (longStr.Contains(shortStr.Substring(i, 2)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
