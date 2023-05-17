using System;

namespace Min_Max_Sum_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxNum = double.MinValue;
            double minNum = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                if (numbers >= maxNum)
                {
                    maxNum = numbers;
                }
                if (numbers < minNum)
                {
                    minNum = numbers;
                }
                sum += numbers;

            }

            double averageSum = sum / n;
            Console.WriteLine($"min={minNum:f2}");
            Console.WriteLine($"max={maxNum:f2}");
            Console.WriteLine($"sum={sum:f2}");
            Console.WriteLine($"avg={averageSum:f2}");

        }
    }
}
