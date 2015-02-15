namespace Problem_1.StringBuilder_Extensions
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

    public static class Extensions
    {
        public static string Substringmodif(this StringBuilder str, int startIndex, int length)
        {
            string result = null;
            for (int i = startIndex; i < startIndex + length; i++)
            {
                result += str[i];
            }

            return result;
        }

        public static string RemoveText(this StringBuilder str, string text)
        {
            string input = Convert.ToString(str);
            var pattern = text;
            var rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            string result = rgx.Replace(input, string.Empty, 50);
            return result;
        }

        public static string AppendAll<T>(this IEnumerable<T> list)
        {
            string result = null;
            foreach (var item in list)
            {
                result += item.ToString() + " ";
            }

            return result;
        }
    }
}