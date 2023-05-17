using System;

namespace CatDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatsPercent = double.Parse(Console.ReadLine());
            double proteinsPercent = double.Parse(Console.ReadLine());
            double carbohydratesPercent = double.Parse(Console.ReadLine());
            double calories = double.Parse(Console.ReadLine());
            double waterPercent = double.Parse(Console.ReadLine());

            double fatsGrams = (fatsPercent / 100 * calories) / 9;
            double proteinsGrams = (proteinsPercent / 100 * calories) / 4;
            double carbohydratesGrams = (carbohydratesPercent / 100 * calories) / 4;


            double foodWeight = fatsGrams + proteinsGrams + carbohydratesGrams;
            double caloriesForGram = calories / foodWeight;

            double leftWater = 100 / 100 - waterPercent / 100;
            double caloriesFor1Gram = leftWater * caloriesForGram;
            

            Console.WriteLine($"{caloriesFor1Gram:f4}");


        }
    }
}
