using System;

namespace T05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double budgetAfterDiscount = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (season == "summer")
                {
                    budgetAfterDiscount = budget * 0.70;
                    Console.WriteLine($"Camp - {budget - budgetAfterDiscount:f2}");
                }
                else if (season == "winter")
                {
                    budgetAfterDiscount = budget * 0.30;
                    Console.WriteLine($"Hotel - {budget - budgetAfterDiscount:f2}");
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");

                if (season == "summer")
                {
                    budgetAfterDiscount = budget * 0.60;
                    Console.WriteLine($"Camp - {budget - budgetAfterDiscount:f2}");
                }
                else if (season == "winter")
                {
                    budgetAfterDiscount = budget * 0.20;
                    Console.WriteLine($"Hotel - {budget - budgetAfterDiscount:f2}");
                }

            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                budgetAfterDiscount = budget * 0.10;
                Console.WriteLine($"Hotel - {budget - budgetAfterDiscount:f2}");

            }
        }
    }
}
