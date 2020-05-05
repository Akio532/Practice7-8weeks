using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task6
{
    public static class StringExtension
    {
        public static string RegexPassword(this string text)
        {
            Regex reg = new Regex(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\u005F).{8,}", RegexOptions.IgnorePatternWhitespace);
            MatchCollection matches = reg.Matches(text);
            foreach (Match mat in matches)
            {
                return (mat.Value);
            }
           return "0";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "C00l_Pass, SupperPas1, Cool_pass, C00l";
            string i = text.RegexPassword();
            Console.WriteLine(i);
        }
    }
}
//string text = "C00l_Pass, SupperPas1, Cool_pass, C00l";
//Regex newReg = new Regex(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\u005F).{8,}");