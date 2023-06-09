using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterviewSystem.Client.Util
{
    public class Utilities
    {
        public static string URLAPI = "https://localhost:7128/";

        public static string RemoveRepeatedWords(string text)
        {
            const string pattern = @"\b(\w+)\s+(\1)\b";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            string result = regex.Replace(text, "$1");

            return result;
        }

    }
}
