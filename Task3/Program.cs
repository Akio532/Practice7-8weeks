using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3
{
    public static class StringExtension

    {
        public static string RegexMail(this string text)
        {
            Regex reg = new Regex(@"(http?:\/\/)?(\w{2,25}\.)+\w{3}([a-z0-9\-?=$-_.+!*()]+)(?i)");
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
            string text = "http://www.example.com, http://example.com, Just Text, http://a.com";
            string i = text.RegexMail();
            Console.WriteLine(i);
        }
    }
}

//string text = "http://www.example.com, http://example.com, Just Text, http://a.com";
//Regex newReg = new Regex(@"(http?:\/\/)?(\w{2,25}\.)+\w{3}([a-z0-9\-?=$-_.+!*()]+)(?i)");