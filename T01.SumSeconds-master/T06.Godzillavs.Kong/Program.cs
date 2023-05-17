using System;

namespace T06.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double priceForClothesPerPerson = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double totalPricePerPerson = people * priceForClothesPerPerson;

            if (people >= 150)
            {
                //totalPricePerPerson *= 0.90
                double discount = totalPricePerPerson * 0.10;
                totalPricePerPerson -= discount;
            }
            double totalMoney = decor + totalPricePerPerson;
            
            if (totalMoney > budget)
            {
                double neededMoney = totalMoney - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else 
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            } 


        }
    }
}
