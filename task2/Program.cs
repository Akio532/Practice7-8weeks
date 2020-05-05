﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace task2
{
    public static class StringExtension
    {
        public static string RegexMAC(this string text)
        {
            Regex reg = new Regex(@"(?i)\{?[a-f\d]{8}-([a-f\d]{4}-){3}[a-f\d]{12}\}?", RegexOptions.IgnorePatternWhitespace);
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
            string text = "e02fd0e4-00fd-090A-ca30-0d00a0038ba0, e02fd0e400fd090Aca300d00a0038ba0";
            string i = text.RegexMAC();
            Console.WriteLine(i);
        }
    }
}
//string text = "e02fd0e4-00fd-090A-ca30-0d00a0038ba0, e02fd0e400fd090Aca300d00a0038ba0";
//Regex newReg = new Regex(@"(?i)\{?[a-f\d]{8}-([a-f\d]{4}-){3}[a-f\d]{12}\}?");