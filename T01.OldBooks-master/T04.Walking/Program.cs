using System;

namespace T04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GOAL = 10000;
            int totalSteps = 0;

            while (totalSteps < GOAL)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    totalSteps += stepsLeft;
                    break;
                }
                int steps = int.Parse(input);
                totalSteps += steps;
            }
            if (totalSteps >= GOAL)
            {
                Console.WriteLine("Goal reached! Good job!");
                int stepsOver = totalSteps - GOAL;
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
            else
            {
                int difference = GOAL - totalSteps;
                Console.WriteLine($"{difference} more steps to reach goal.");
            }
            
        }
    }
}
