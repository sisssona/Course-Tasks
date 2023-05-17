using System;

namespace T04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            double rent = 0;
            double discount = 0;
            double priceAfterDiscount = 0;
            
            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Winter")
            {
                rent = 2600;
            }
           
            if (fisherman <= 6)
            {
                rent *= 0.9;
            }
            else if (fisherman > 7 && fisherman <= 11)
            {
                rent *= 0.85;
            }
             else if (fisherman > 12)
            {
                rent *= 0.75;
            }
            if (fisherman % 2 == 0 && season != "Autumn")
            {
                rent *= 0.95;
            }
            priceAfterDiscount = rent - (rent * discount);

            if (budget >= priceAfterDiscount)
            {
                Console.WriteLine($"Yes! You have {(budget - priceAfterDiscount):f2} leva left.");
            }
            else if (priceAfterDiscount > budget)
            {
                Console.WriteLine($"Not enough money! You need {(priceAfterDiscount - budget):f2} leva.");
            }

            
            
        }
    }
}
