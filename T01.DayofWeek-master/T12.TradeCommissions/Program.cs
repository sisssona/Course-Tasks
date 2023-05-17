using System;

namespace T12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sumSell = double.Parse(Console.ReadLine());

            switch (city)
            {
                case "Sofia": 
                    if (0 <= sumSell && sumSell <= 500)
                    {
                        Console.WriteLine($"{sumSell * 0.05:f2}");
                    }
                    else if (500 < sumSell && sumSell <= 1000)
                    {
                        Console.WriteLine($"{sumSell * 0.07:f2}");
                    }
                    else if (1000 < sumSell && sumSell <= 10000)
                    {
                        Console.WriteLine($"{0.08 * sumSell:f2}");
                    }
                    else if (sumSell > 10000)
                    {
                        Console.WriteLine($"{0.12 * sumSell:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error"); 
                    }
                    break;
                case "Varna":
                    if (0 <= sumSell && sumSell <= 500)
                    {
                        Console.WriteLine($"{sumSell * 0.045:f2}");
                    }
                    else if (500 < sumSell && sumSell <= 1000)
                    {
                        Console.WriteLine($"{sumSell * 0.075:f2}");
                    }
                    else if (1000 < sumSell && sumSell <= 10000)
                    {
                        Console.WriteLine($"{0.1 * sumSell:f2}");
                    }
                    else if (sumSell > 10000)
                    {
                        Console.WriteLine($"{0.13 * sumSell:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error"); 
                    }
                    break;
                case "Plovdiv":

                    if (0 <= sumSell && sumSell <= 500)
                    {
                        Console.WriteLine($"{sumSell * 0.055:f2}");
                    }
                    else if (500 < sumSell && sumSell <= 1000)
                    {
                        Console.WriteLine($"{sumSell * 0.08:f2}");
                    }
                    else if (1000 < sumSell && sumSell <= 10000)
                    {
                        Console.WriteLine($"{sumSell * 0.12:f2}");
                    }
                    else if (sumSell > 10000)
                    {
                        Console.WriteLine($"{sumSell * 0.145:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error"); 
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
                   
            
                
        }
    }
}
