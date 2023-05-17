using System;
using System.Linq;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal reversedNum = ReverseNumber(number);
            Console.WriteLine(reversedNum);
        }
        static decimal ReverseNumber(decimal number)
        {
            decimal n = number;
            string reversedString = new string(n.ToString().Reverse().ToArray());
            decimal reversedDecimal;
            if (decimal.TryParse(reversedString, out reversedDecimal))
            {
                return reversedDecimal;
            }
            else
            {
                return 0;
            }
        }
    }
}

