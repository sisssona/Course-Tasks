using System;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double winTheBallSum = double.Parse(Console.ReadLine());

            double shortPantsPrice = 0.75 * tshirtPrice;
            double socksPrice = 0.20 * shortPantsPrice;
            double footballShoesPrice = 2 * (shortPantsPrice + tshirtPrice);

            double finalSum = tshirtPrice + shortPantsPrice + socksPrice + footballShoesPrice;
            double sumAfterDiscount = finalSum - (0.15 * finalSum);

            if (finalSum >= winTheBallSum)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {sumAfterDiscount:f2} lv.");
            }
            else if (finalSum < winTheBallSum)
            {
                double neededMoney = winTheBallSum - sumAfterDiscount;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {neededMoney:f2} lv. more.");
            }


        }
    }
}
