using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
    public static class StringExtension
    {
        public static string RegexPercent(this string text)
        {
            Regex reg = new Regex(@"(^[1-9]+|^[1-9]+\.\d+)\sруб\.", RegexOptions.IgnorePatternWhitespace);
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
            string text = "23.78 руб., 22 р., 0.002 руб.";
            string i = text.RegexPercent();
            Console.WriteLine(i);
        }
    }
}

//string text = "23.78 руб., 22 р., 0.002 руб.";
//Regex newReg = new Regex(@"(^[1-9]+|^[1-9]+\.\d+)\sруб\.");