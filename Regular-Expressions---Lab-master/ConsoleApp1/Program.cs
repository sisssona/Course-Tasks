using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = @"[+359]{4}(\s|-)[2]\1[0-9]{3}\1[0-9]{4}";
            var phones = Console.ReadLine();
            MatchCollection validNumbers = Regex.Matches(phones, regex);
            var matchedPhones = validNumbers.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.Write(string.Join(", ", matchedPhones));

            Console.WriteLine();

        }
    }
}
