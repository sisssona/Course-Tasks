using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currBalance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double outFall4 = 39.99;
            double csOG = 15.99;
            double zplinterZell = 19.99;
            double honored2 = 59.99;
            double roverWatch = 29.99;
            double roverWatchOriginsEdition = 39.99;

            double totalSpentMoney = 0;

            while (input != "Game Time")
            {
                if (currBalance > 0)
                {
                    switch (input)
                    {
                        case "OutFall 4":
                            if (currBalance < outFall4 )
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {input}");
                                currBalance -= outFall4;
                                totalSpentMoney += outFall4;
                            } break;
                        case "CS: OG":
                            if (currBalance < csOG)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {input}");
                                currBalance -= csOG;
                                totalSpentMoney += csOG;
                            } break;
                        case "Zplinter Zell":
                            if (currBalance < zplinterZell)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {input}");
                                currBalance -= zplinterZell;
                                totalSpentMoney += zplinterZell;
                            }
                            break;
                        case "Honored 2":
                            if (currBalance < honored2)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {input}");
                                currBalance -= honored2;
                                totalSpentMoney += honored2;
                            }
                            break;
                        case "RoverWatch":
                            if (currBalance < roverWatch)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {input}");
                                currBalance -= roverWatch;
                                totalSpentMoney += roverWatch;
                            }
                            break;
                        case "RoverWatch Origins Edition":
                            if (currBalance < roverWatchOriginsEdition)
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            else
                            {
                                Console.WriteLine($"Bought {input}");
                                currBalance -= roverWatchOriginsEdition;
                                totalSpentMoney += roverWatchOriginsEdition;
                            }
                            break;
                        default: Console.WriteLine("Not found"); break;
                    }

                }
                if (currBalance <= 0)
                {
                    Console.WriteLine("Out of money!"); return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpentMoney:f2}. Remaining: ${currBalance:f2}");
        }
    }
}
