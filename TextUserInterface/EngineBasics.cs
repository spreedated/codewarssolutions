﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TextUserInterface
{
    public static class EngineBasics
    {
        private static KeyValuePair<string, string>[] foregroundColors;
        public static void DisplayProgramHeader(string heading)
        {
            StringBuilder sb = new();
            int spaces = Convert.ToInt32(Math.Ceiling((Console.BufferWidth / 2) - (double)(heading.Length / 2)));
            sb.Append($"▐{new string('█', Console.BufferWidth - 2)}▌\n");
            sb.Append($"{new string('█', (spaces - 1) / 2)}▌{new string(' ', spaces / 2)}{heading}{new string(' ', spaces / 2)}▐{new string('█', (spaces - 3) / 2)}\n");
            sb.Append($"{new string('█', (spaces - 1) / 2)}▌{new string(' ', spaces / 2)}{new string('▀', heading.Length)}{new string(' ', spaces / 2)}▐{new string('█', (spaces - 3) / 2)}\n");
            sb.Append($"▐{new string('█', Console.BufferWidth - 2)}▌\n");
            sb.Append($"\n\n");

            DisplayColoredBlocks(sb);

            Console.ResetColor();
        }

        private static void DisplayColoredBlocks(StringBuilder sb)
        {
            if (foregroundColors == null)
            {
                PropertyInfo[] props = typeof(ConsoleEscapeSequences).GetProperties(BindingFlags.Public | BindingFlags.Static).Where(x => x.Name.ToLower().StartsWith("foreground")).ToArray();
                foregroundColors = new KeyValuePair<string, string>[props.Length];

                for (int i = 0; i < props.Length; i++)
                {
                    foregroundColors[i] = new(props[i].Name.Replace("Foreground", ""), (string)props[i].GetValue(null));
                }
            }

            StringBuilder s = new();

            foreach (char c in sb.ToString())
            {
                if (c == '█' || c == '▐' || c == '▌')
                {
                    Random rnd = new(BitConverter.ToInt32(Guid.NewGuid().ToByteArray()));
                    s.Append($"{foregroundColors.ToArray()[rnd.Next(0, foregroundColors.Length - 1)].Value}{c}");
                    continue;
                }
                if (c == '▀' || c == ' ')
                {
                    s.Append(c);
                    continue;
                }
                s.Append($"{Array.Find(foregroundColors, x => x.Key == "White").Value}{c}");
            }

            Console.Write(s.ToString());
        }

        /// <summary>
        /// Changes the Foreground Color and resets it afterwards
        /// </summary>
        /// <param name="color"></param>
        /// <param name="text"></param>
        /// <param name="newline"></param>
        public static void WriteColor(ConsoleColor color, string text, bool newline = true)
        {
            Console.ForegroundColor = color;
            Console.Write($"{text}{(newline ? "\n" : "")}");
            Console.ResetColor();
        }

        public static void DisplaySolutionEnd()
        {
            StringBuilder sb = new();

            sb.Append("\n\n");
            sb.Append($"{new string(' ', Console.BufferWidth / 4)}▐{new string('█', (Console.BufferWidth - 2) / 2)}▌\n");
            sb.Append("\tPress any key to return ...");

            DisplayColoredBlocks(sb);

            Console.ReadKey();
        }

        public static void DisplayEnd()
        {
            StringBuilder sb = new();
            string text = "\nThank you for using!\n\n\nVisit our github repo:\n\nhttps://github.com/spreedated/festocodingchallange\n";

            int barWidth = (Console.BufferWidth - 2) / 2;

            sb.Append("\n\n\n");
            sb.Append($"{new string(' ', Console.BufferWidth / 4)}▐{new string('█', barWidth)}▌\n");
            sb.Append($"{new string(' ', Console.BufferWidth / 4)}▐{new string('█', barWidth)}▌\n");

            foreach (string line in text.Split('\n'))
            {
                sb.Append($"{new string(' ', (Console.BufferWidth / 2) - (line.Length / 2))}{line}\n");
            }

            sb.Append($"{new string(' ', Console.BufferWidth / 4)}▐{new string('█', barWidth)}▌\n");
            sb.Append($"{new string(' ', Console.BufferWidth / 4)}▐{new string('█', barWidth)}▌\n");
            sb.Append($"{new string('\n', 4)}");

            Console.Clear();
            DisplayColoredBlocks(sb);

            Environment.Exit(0);
        }
    }
}
