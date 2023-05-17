using System;

namespace T05.Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PLUS_TIME = 15;
             
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += PLUS_TIME;

            if (minutes >= 60)
            {
                hour += 1;
                minutes -= 60;
            }
            if (hour >= 24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");


        }
    }
}
