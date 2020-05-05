using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    public static class StringExtension
   {
       public static string RegexIp(this string text)
        {
            Regex reg = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
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
            string text = "127.0.0.1, 255.255.255.0, 1300.6.7.8, abc.def.gha.bcd";
            string i = text.RegexIp();
            Console.WriteLine(i);
        }
    }
}
//string text = "127.0.0.1, 255.255.255.0, 1300.6.7.8, abc.def.gha.bcd";
//Regex newReg = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");