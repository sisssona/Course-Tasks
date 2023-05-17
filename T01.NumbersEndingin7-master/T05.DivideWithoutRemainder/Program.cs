using System;

namespace T05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double category1 = 0;
            double category2 = 0;
            double category3 = 0;

            for (int i = 0; i < numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    category1++;
                }
                if (number % 3 == 0)
                {
                    category2++;
                }
                if (number % 4 == 0)
                {
                    category3++;
                }
            }
            double convertedToPercentage1 = category1 / numbers * 100;
            double convertedToPercentage2 = category2 / numbers * 100;
            double convertedToPercentage3 = category3 / numbers * 100;

            Console.WriteLine($"{convertedToPercentage1:f2}%");
            Console.WriteLine($"{convertedToPercentage2:f2}%");
            Console.WriteLine($"{convertedToPercentage3:f2}%");
        }
    }
}
