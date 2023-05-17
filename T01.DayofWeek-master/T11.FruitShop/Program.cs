using System;

namespace T11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            const double BANANA_PRICE = 2.50;
            const double APPLE_PRICE = 1.20;
            const double ORANGE_PRICE = 0.85;
            const double GRAPEFRUIT_PRICE = 1.45;
            const double KIWI_PRICE = 2.70;
            const double PINEAPPLE_PRICE = 5.50;
            const double GRAPES_PRICE = 3.85;

            if (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday"
                || dayOfTheWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana": price = BANANA_PRICE * quantity; break;
                    case "apple": price = APPLE_PRICE * quantity; break;
                    case "orange": price = ORANGE_PRICE * quantity; break;
                    case "grapefruit": price = GRAPEFRUIT_PRICE * quantity; break;
                    case "kiwi": price = KIWI_PRICE * quantity; break;
                    case "pineapple": price = PINEAPPLE_PRICE * quantity; break;
                    case "grapes": price = GRAPES_PRICE * quantity; break;
                }
            }
            else if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": price = (BANANA_PRICE + 0.20) * quantity; break;
                    case "apple": price = (APPLE_PRICE + 0.05) * quantity; break;
                    case "orange": price = (ORANGE_PRICE + 0.05) * quantity; break;
                    case "grapefruit": price = (GRAPEFRUIT_PRICE + 0.15) * quantity; break;
                    case "kiwi": price = (KIWI_PRICE + 0.30) * quantity; break;
                    case "pineapple": price = (PINEAPPLE_PRICE + 0.10) * quantity; break;
                    case "grapes": price = (GRAPES_PRICE + 0.35) * quantity; break;
                }
            }
            if (price != 0.0) Console.WriteLine($"{price:f2}");

            else 
            {
                Console.WriteLine("error");
            }
            


        }
    }
}
