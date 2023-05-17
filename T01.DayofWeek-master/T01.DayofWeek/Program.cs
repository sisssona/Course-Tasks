using System;

namespace T01.DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           

            switch (number)
            {
                case 1:
                    number = 1;
                    Console.WriteLine("Monday"); break;
                case 2:
                    number = 2;
                    Console.WriteLine("Tuesday"); break;
                case 3:
                    number = 3;
                    Console.WriteLine("Wednesday"); break;
                case 4:
                    number = 4;
                    Console.WriteLine("Thursday"); break;
                case 5:
                    number = 5;
                    Console.WriteLine("Friday"); break;
                case 6:
                    number = 6;
                    Console.WriteLine("Saturday"); break;
                case 7:
                    number = 7;
                    Console.WriteLine("Sunday"); break;
                default:
                    Console.WriteLine("Error"); break;

                    
            }
        }
    }
}
