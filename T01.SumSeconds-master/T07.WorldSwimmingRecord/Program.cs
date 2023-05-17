using System;

namespace T07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double TimeInSeconds = double.Parse(Console.ReadLine());

            double distanceInSeconds = distanceInMeters * TimeInSeconds;
            double delay = Math.Floor(distanceInMeters / 15) * 12.5;
            double finalTime = distanceInSeconds + delay;

            if (finalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                Double timeNeeded = finalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
            }
            
        }
    }
}
