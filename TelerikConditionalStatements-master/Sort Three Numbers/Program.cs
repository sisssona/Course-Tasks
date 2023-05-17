using System;

namespace Sort_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                if (number2 > number3)
                {
                    Console.WriteLine($"{number1} {number2} {number3}");
                }
                else
                {
                    Console.WriteLine($"{number1} {number3} {number2}");
                } 
            }
            if (number2 > number1 && number2 > number3)
            {
                if (number1 > number3)
                {
                    Console.WriteLine($"{number2} {number1} {number3}");
                }
                else
                {
                    Console.WriteLine($"{number2} {number3} {number1}");
                }
            }
            if (number3 > number1 && number3 > number2)
            {
                if (number1 > number2)
                {
                    Console.WriteLine($"{number3} {number1} {number2}");
                }
                else
                {
                    Console.WriteLine($"{number3} {number2} {number1}");
                }

            }
        }
    }
}
