using System;

namespace T01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTime = 0;
            int firstRunner = int.Parse(Console.ReadLine());
            int secondRunner = int.Parse(Console.ReadLine());
            int thirdRunner = int.Parse(Console.ReadLine());
            totalTime = firstRunner + secondRunner + thirdRunner;

            int minutes = 0;
            int seconds = 0;

            if(totalTime >= 120)
            {
                minutes = 2;
                seconds = totalTime - 120;
            }
            else if (totalTime >= 60)
            {
                minutes = 1;
                seconds = totalTime - 60;
            }
            else
            {
                seconds = totalTime;
            }
            Console.WriteLine($"{minutes}:{seconds:d2}");

        }
    }
}
