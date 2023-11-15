using CodeWars.Attributes;
using System.Linq;

namespace CodeWars.Kyu5
{
    [Kata("59437bd7d8c9438fb5000004", false)]
    public static class AlphabetWarsNuclearStrike
    {
        public static string AlphabetWar(string b)
        {
            if (!b.Any(x => x == '#'))
            {
                return b.Replace("[", "").Replace("]", "");
            }

            if (b.Any(x => x == '#') && b.Count(x => x == '[') == 1)
            {
                return b[(b.IndexOf('[') + 1)..b.IndexOf(']')];
            }

            return "oops";
        }
    }
}
