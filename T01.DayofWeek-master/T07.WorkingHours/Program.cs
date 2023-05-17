using System;

namespace T07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();
            
            if (hour >= 10 && hour <= 18)
            {
                switch (dayOfTheWeek)
                    {

                    case "Monday":
                    case "Tuesday":  
                    case "Wednesday":  
                    case "Thursday":  
                    case "Friday":  
                    case "Saturday": 
                        Console.WriteLine("open"); break;
                    case "Sunday":
                    default:
                        Console.WriteLine("closed"); break;
                }
                     

            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
