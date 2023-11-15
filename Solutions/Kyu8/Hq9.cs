using Solutions.Attributes;
using System.Text;
using static Solutions.Constants;

namespace Solutions.Kyu8
{
    [Kata("591588d49f4056e13f000001", PRIMARY_AUTHOR)]
    public static class Hq9
    {
        public static string Interpret(string code)
        {
            if (string.IsNullOrEmpty(code) || code.Trim().Length >= 2)
            {
                return null;
            }

            if (code.Equals("h", System.StringComparison.CurrentCultureIgnoreCase))
            {
                return "Hello World!";
            }

            if (code.Equals("q", System.StringComparison.CurrentCultureIgnoreCase))
            {
                return code;
            }

            if (code.Equals("9", System.StringComparison.CurrentCultureIgnoreCase))
            {
                string lyrics = "{0} bottles of beer on the wall, {0} bottles of beer.\nTake one down and pass it around, {1} bottle{2} of beer on the wall.\n";
                string lyricsEnd = "1 bottle of beer on the wall, 1 bottle of beer.\nTake one down and pass it around, no more bottles of beer on the wall.\nNo more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";

                StringBuilder s = new();

                for (int i = 99; i > 1; i--)
                {
                    s.Append(string.Format(lyrics, i, i - 1, i - 1 == 1 ? "" : "s"));
                }

                s.Append(lyricsEnd);

                return s.ToString();
            }

            return null;
        }
    }
}
