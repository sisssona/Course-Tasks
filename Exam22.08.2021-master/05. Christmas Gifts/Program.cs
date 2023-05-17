using System;

namespace _05._Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int adults = 0;
            int kids = 0;

            while (input != "Christmas")
            {
                int age = int.Parse(input);
                if (age <= 16)
                {
                    kids++;
                }
                else if (age > 16)
                {
                    adults++;
                }
                input = Console.ReadLine();
            }

            double toysSum = kids * 5;
            double sweathersSum = adults * 15;

            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {toysSum}");
            Console.WriteLine($"Money for sweaters: {sweathersSum}");
        }
    }
}
