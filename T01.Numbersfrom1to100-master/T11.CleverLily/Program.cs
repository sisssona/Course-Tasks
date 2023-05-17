using System;

namespace T11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int oddCounter = 0;
            double savedMoney = 0;
            double moneyGift = 10;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += (moneyGift - 1);
                    moneyGift += 10;
                }
                else
                {
                    oddCounter++;
                } 
            }
            double profitFromToys = oddCounter * toyPrice;
            savedMoney += profitFromToys;

            if (savedMoney >= washingMashinePrice)
            {
                Console.WriteLine($"Yes! {(savedMoney - washingMashinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMashinePrice - savedMoney):f2}");
            }



        
            

           
            
        }
    }
}
