using System;

namespace Find_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double nextNums = double.Parse(Console.ReadLine());
                sum += nextNums;
            }
            double averageSum = (double)sum / n;
            Console.WriteLine($"{averageSum:f2}");
        }
    }
}
