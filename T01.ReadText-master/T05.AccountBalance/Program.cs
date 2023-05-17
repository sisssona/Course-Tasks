using System;

namespace T05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double account = 0;

            while (command != "NoMoreMoney")
            {
                double currentAmount = double.Parse(command);
                if (currentAmount < 0)
                {
                    Console.WriteLine("Invalid operation!"); break;
                }
                account += currentAmount;
                Console.WriteLine($"Increase: {currentAmount:f2}");
                command = Console.ReadLine();
                
            }
            Console.WriteLine($"Total: {account:f2}");
        }
    }
}
