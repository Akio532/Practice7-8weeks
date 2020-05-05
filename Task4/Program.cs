using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task4
{
    public static class StringExtension
    {
        public static string RegexDate(this string text)
        {
            Regex reg = new Regex(@"((0[1-9]|1\d|2[0-8])/(0[1-9]|1[0-2])/\d{4})|((29/(0[1-9]|1[0-2])/ ([02468][048]00|[13579][26]00|\d\d0[48]|\d\d[2468][048]|\d\d[13579][26])
)|(29/(0[13-9]|1[0-2])/\d{3}[1235679]))|(30/(0[13-9]|1[0-2])/\d{4})|
(31/(0[13578]|10|12)/\d{4})", RegexOptions.IgnorePatternWhitespace);
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
            string text = "29/02/2021, 29/02/2000, 31/12/9999";
            string i = text.RegexDate();
            Console.WriteLine(i);
        }
    }
}
//            string text = "29/02/2021, 29/02/2000, 31/12/9999";
//            Regex newReg = new Regex(@"((0[1-9]|1\d|2[0-8])/(0[1-9]|1[0-2])/\d{4})|((29/(0[1-9]|1[0-2])/ ([02468][048]00|[13579][26]00|\d\d0[48]|\d\d[2468][048]|\d\d[13579][26]))|(29/(0[13-9]|1[0-2])/\d{3}[1235679]))|(30/(0[13-9]|1[0-2])/\d{4})|
//(31/(0[13578]|10|12)/\d{4})", RegexOptions.IgnorePatternWhitespace);