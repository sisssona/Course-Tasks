using System;
using System.Globalization;


namespace Problem_10._Beer_Time
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string timeValue = Console.ReadLine();
            DateTime time;
            string startBeerTime = "1:00 PM";
            string endBeerTime = "3:00 AM";
            DateTime start = Convert.ToDateTime(startBeerTime);
            DateTime end = Convert.ToDateTime(endBeerTime);
            if (DateTime.TryParse(timeValue, out time))
            {
                if (time >= start || time <= end)
                {
                    Console.WriteLine("beer time");
                }
                else if (time < start || time > end)
                {
                    Console.WriteLine("non beer time");
                }
            }
            
            else
            {
                Console.WriteLine("invalid time");
            }
            

        }
    }

   
}
