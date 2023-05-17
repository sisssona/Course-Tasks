using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = "\\b(?<day>[0-9]{2})(.)(?<month>[A-Z]{1}[a-z]{2})\\1(?<year>[0-9]{4})\\b";
            var dates = Console.ReadLine();
            MatchCollection validDates = Regex.Matches(dates, regex);   
            foreach (Match validDate in validDates) 
            {
                var day = validDate.Groups["day"].Value;    
                var month = validDate.Groups["month"].Value;
                var year = validDate.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
