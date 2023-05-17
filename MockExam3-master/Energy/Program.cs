using System;
using System.Numerics;

namespace Energy
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger evenDigitsSum = 0;
            BigInteger oddDigitsSum = 0;

            while (number != 0)
            {
                if (number % 2 == 1)
                {
                    oddDigitsSum += number % 10;
                    number /= 10;
                }
                else
                {
                    evenDigitsSum += number % 10;
                    number /= 10;
                }
                if (number == 0)
                {
                    evenDigitsSum += number % 10;
                    number /= 10;
                }
            }
               
                       
            if (oddDigitsSum > evenDigitsSum)
            {
                Console.WriteLine(oddDigitsSum + " cups of coffee");
            }
            if (evenDigitsSum > oddDigitsSum)
            {
                Console.WriteLine(evenDigitsSum + " energy drinks");
            }
            if (evenDigitsSum == oddDigitsSum)
            {
                Console.WriteLine(evenDigitsSum + " of both");
            }
        }
    }
}
