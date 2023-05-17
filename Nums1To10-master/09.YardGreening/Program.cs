using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double a = 7.61;
            double b = 0.18;
            double result = meters * a;
            double discount = b * result;


            Console.WriteLine($"The final price is: {result - discount} lv.");
            Console.WriteLine($"The discount is: {discount} + lv.");

        }
    }
}
