using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Solutions.Attributes;
using static TextUserInterface.EngineBasics;
using static TextUserInterface.HelperFunctions;

namespace CodeWars
{
    internal static class Program
    {
        private static string title = null;
        public static Assembly OwnAssembly { get; private set; } = null;
        public static Assembly SolutionsAssembly { get; private set; } = null;

        static void Main(string[] args)
        {
            OwnAssembly = typeof(Program).Assembly;
            SolutionsAssembly = typeof(Solutions.Own.ReadingsOvertime).Assembly;

            title = typeof(Program).Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
            Console.Clear();
            DisplayProgramHeader(title);

            DisplayKyuSelection();

            Console.ReadKey();
        }

        private static void DisplayKyuSelection()
        {
            IOrderedEnumerable<string> sections = SolutionsAssembly.GetTypes()
                .Where(x => x.Namespace.ToLower().Contains("kyu", StringComparison.InvariantCulture) || x.Namespace.ToLower().Contains("own", StringComparison.InvariantCulture))
                .Select(x => x.Namespace[(x.Namespace.IndexOf('.')+1)..])
                .Distinct()
                .OrderBy(x => x);

            List<string> sectionsDisplayRead = new();

            foreach (string s in sections)
            {
                if (DoesContainDigit(s))
                {
                    sectionsDisplayRead.Add($"{s[..3]} {s[3..]}");
                    continue;
                }
                sectionsDisplayRead.Add(s);
            }

            string heading = "Kyu selection";

            Console.WriteLine($"  {heading}");
            Console.WriteLine($"  {new string('=', heading.Length)}\n");

            Console.WriteLine($"\tSelect your Kyu:\n");

            IEnumerable<KeyValuePair<string, string>> kyusAndCounts = GetAllSolutions().GroupBy(x => x.Key).Select(x => new KeyValuePair<string, string>(x.Key, x.Count().ToString()));

            foreach (KeyValuePair<string, string> kac in kyusAndCounts)
            {
                
            }
        }

        public static IEnumerable<KeyValuePair<string, string>> GetAllSolutions()
        {
            IEnumerable<Type> kyus = SolutionsAssembly.GetTypes()
                .Where(x => x.CustomAttributes.Any(x => x.AttributeType == typeof(KataAttribute)));

            foreach (Type k in kyus)
            {
                yield return new KeyValuePair<string, string>(k.Namespace[(k.Namespace.IndexOf('.')+1)..], k.Name);
            }
        }

        private static bool DoesContainDigit(string str)
        {
            return str.Any(x => int.TryParse(x.ToString(), out _));
        }
    }
}