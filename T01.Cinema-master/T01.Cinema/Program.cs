using System;

namespace T01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colons = int.Parse(Console.ReadLine());

            double income = 0;
           
            if (projection == "Premiere")
            {
                income = rows * colons * 12;
                Console.WriteLine($"{income:f2} leva", income);
            }
            else if (projection == "Normal")
            {
                income = rows * colons * 7.50;
                Console.WriteLine($"{income:f2} leva", income);
            }
            else if (projection == "Discount")
            {
                income = rows * colons * 5.00;
                Console.WriteLine($"{income:f2} leva", income);
            }




            



        }
    }
}
