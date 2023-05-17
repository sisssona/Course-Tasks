using System;

namespace T9.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double daysInYear = 48 - h;
            double gamesInSofia = (3.0 / 4) * daysInYear;
            double gameInTown = h;
            double gamesHolidays = p * (2.0 / 3);
            double gameSum = gamesInSofia + gameInTown + gamesHolidays;
            double sum = 0;

            switch (year)
            {
                case "leap": sum = gameSum * 0.15; break;
            }
            Console.WriteLine(Math.Floor(gameSum + sum));
        }
    }
}
