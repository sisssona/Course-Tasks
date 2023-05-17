using System;

namespace T03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double moneyForFlowers = 0;

            switch (flowerType)
            {
                case "Roses": moneyForFlowers = quantity * 5;
                    if (quantity > 80)
                    {
                        moneyForFlowers = moneyForFlowers - moneyForFlowers * 0.1;
                       
                    }
                    break;
                case "Dahlias": moneyForFlowers = quantity * 3.8;
                    if (quantity > 90)
                    {
                        moneyForFlowers *= 0.85;
                    }
                    break;
                case "Tulips": moneyForFlowers = quantity * 2.8;
                    if (quantity > 80)
                    {
                        moneyForFlowers *= 0.85;
                    }
                    break;
                case "Narcissus": moneyForFlowers = quantity * 3;
                    if (quantity < 120)
                    {
                        moneyForFlowers *= 1.15;
                    }
                    break;
                case "Gladiolus": moneyForFlowers = quantity * 2.50;
                    if (quantity < 80)
                    {
                        moneyForFlowers *= 1.20;
                    }
                    break;
                 
            }
            if (moneyForFlowers <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {(budget - moneyForFlowers):f2} leva left.");
            }
                    
            
            else
            {
                Console.WriteLine($"Not enough money, you need {(moneyForFlowers - budget):f2} leva more.");
            }

                    
                       
                    
                        

                    
            


        }
    }
}
