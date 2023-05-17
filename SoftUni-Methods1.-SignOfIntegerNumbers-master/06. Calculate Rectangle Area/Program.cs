using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(RectangleArea(a, b));
        }
        static int RectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
