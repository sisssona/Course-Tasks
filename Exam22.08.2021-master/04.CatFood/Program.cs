using System;

namespace _04.CatFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCats = int.Parse(Console.ReadLine());

            int cats = 1;
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            double totalFoodWeightGrams = 0;

            while (cats <= numberOfCats)
            {
                double foodWeightInGrams = double.Parse(Console.ReadLine());
                totalFoodWeightGrams += foodWeightInGrams;
                if (foodWeightInGrams >= 100 && foodWeightInGrams < 200)
                {
                    group1++;
                }
                else if (foodWeightInGrams >= 200 && foodWeightInGrams < 300)
                {
                    group2++;
                }
                else if (foodWeightInGrams >= 300 && foodWeightInGrams <= 400)
                {
                    group3++;
                }

                cats++;
            }

            double priceForFood = (totalFoodWeightGrams / 1000) * 12.45;
            
            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {priceForFood:f2} lv.");
        }
    }
}
        
    

