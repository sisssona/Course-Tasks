using System;

namespace T06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;

            int openedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < openedTabs; i++)
            {
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your slary."); break;
                }
                string browser = Console.ReadLine();
                if (browser == "FACEBOOK")
                {
                    salary -= FACEBOOK;
                }
                else if (browser == "INSTAGRAM")
                {
                    salary -= INSTAGRAM;
                }
                else if (browser == "REDDIT")
                {
                    salary -= REDDIT;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
