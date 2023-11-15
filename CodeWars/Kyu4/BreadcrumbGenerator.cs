using CodeWars.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kyu4
{
    [Kata("563fbac924106b8bf7000046")]
    public static class BreadcrumbGenerator
    {
        public static string GenerateBC(string url, string separator)
        {
            StringBuilder s = new();

            string strippedUrl = null;

            if (!url.Contains("://"))
            {
                strippedUrl = url[(url.IndexOf('/') + 1)..];
            }
            else
            {
                strippedUrl = url[(url.IndexOf("://")+3)..];
                strippedUrl = strippedUrl[(strippedUrl.IndexOf('/')+1)..];
            }

            if (strippedUrl.Split('/').Count(x => !string.IsNullOrEmpty(x)) <= 1)
            {
                s.Append("<span class=\"active\">HOME</span>");
                return s.ToString();
            }

            s.Append("<a href=\"/\">HOME</a>");
            s.Append($" {separator.Trim()} ");

            IEnumerable<string> parts = strippedUrl.Split('/').Where(x => !string.IsNullOrEmpty(x));

            foreach (string part in parts.Take(parts.Count()-(parts.Any(x => x.ToLower().Contains("index")) ? 2 : 1)))
            {
                if (part.Length <= 29)
                {
                    s.Append($"<a href=\"/{part}/\">{part.ToUpper().Replace('-', ' ')}</a>");
                }
                else
                {
                    string[] ignoreWords = new string[] { "the", "of", "in", "from", "by", "with", "and", "or", "for", "to", "at", "a" };
                    StringBuilder shortened = new();

                    foreach (string w in part.Split('-').Except(ignoreWords))
                    {
                        shortened.Append(w[..1].ToUpper());
                    }

                    s.Append($"<a href=\"/{part}/\">{shortened}</a>");
                }
                
                s.Append($" {separator.Trim()} ");
            }

            string lastpart = parts.Skip(parts.Count() - (parts.Any(x => x.ToLower().Contains("index")) ? 2 : 1)).Take(1).ToArray()[0];

            if (lastpart.Contains('?'))
            {
                lastpart = lastpart[..lastpart.IndexOf('?')];
            }

            if (lastpart.Contains('#'))
            {
                lastpart = lastpart[..lastpart.IndexOf('#')];
            }

            if (lastpart.Contains('.'))
            {
                s.Append($"<span class=\"active\">{lastpart[..lastpart.IndexOf('.')].ToUpper().Replace('-', ' ')}</span>");
            }
            else
            {
                s.Append($"<span class=\"active\">{lastpart.ToUpper().Replace('-', ' ')}</span>");
            }

            return s.ToString();
        }
    }
}
