using System;

namespace Sort_3_Numbers_with_Nested_Ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                if (b >= c)
                {
                    Console.WriteLine($"{a} {b} {c}");
                }
                else if (b <= c)
                {
                    Console.WriteLine($"{a} {c} {b}");
                }
            }
            if (b >= a && b >= c)
            {
                if (a >= c)
                {
                    Console.WriteLine($"{b} {a} {c}");
                }
                else if (a <= c)
                {
                    Console.WriteLine($"{b} {c} {a}");
                }
            }
            if (c >= a && c >= b)
            {
                if (a >= b)
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
                else if (a <= b)
                {
                    Console.WriteLine($"{c} {b} {a}");
                }
            }
            
        }
    }
}
