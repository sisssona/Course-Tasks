using System;

namespace _1._Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"{b} {a}");
            }
            else
            {
                Console.WriteLine($"{a} {b}");
            }
        }
    }
}
