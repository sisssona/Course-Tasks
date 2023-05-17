using System;

namespace Problem_4._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a * b * c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a * b * c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a * b * c == 0)
            {
                Console.WriteLine("0");
            }

        }
    }
}
