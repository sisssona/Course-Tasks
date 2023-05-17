using System;

namespace Exam22._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double fuelFor100Km = double.Parse(Console.ReadLine());
            
            
            double distance = 384400 * 2;
            double time = distance / speed;
            double totalTime = time + 3;
            double neededFuel = (fuelFor100Km * distance) / 100;


            Console.WriteLine(Math.Ceiling(totalTime));
            Console.WriteLine(neededFuel);
        }
    }
}
