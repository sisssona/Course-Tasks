﻿using System;

namespace sort3nums
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                if (number2 >= number3)
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
                if (number1 >= number3)
                {
                    Console.WriteLine($"{number2} {number1} {number3}");
                }
                else
                {
                    Console.WriteLine($"{number2} {number3} {number1}");
                }
            }
            if (number3 >= number1 && number3 >= number2)
            {
                if (number1 >= number2)
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
