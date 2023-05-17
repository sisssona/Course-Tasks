using System;

namespace GoldenMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());

            for (int i = 0; i < locations; i++)
            {
                double expectedAverageProduction = double.Parse(Console.ReadLine());
                int workingDays = int.Parse(Console.ReadLine());
                double goldPerDay = 0;

                for (int j = 0; j < workingDays; j++)
                {
                    double goldProduction = double.Parse(Console.ReadLine());
                    goldPerDay += goldProduction;
                }

                double averageProduction = goldPerDay / workingDays;

                if (averageProduction >= expectedAverageProduction)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageProduction:f2}.");
                }
                else if (averageProduction < expectedAverageProduction)
                {
                    Console.WriteLine($"You need {expectedAverageProduction - averageProduction:f2} gold.");
                }
            }

           
        }
    }
}
