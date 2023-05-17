﻿using System;

namespace _10._LadyBugs__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieledSize = int.Parse(Console.ReadLine());
            int[] ladyBugField = new int[fieledSize];

            string[] occupiedIndex = Console.ReadLine().Split();
            foreach (var ladyBugs in occupiedIndex)
            {
                int currentIndex = int.Parse(ladyBugs);
                if (currentIndex >= 0 && currentIndex < fieledSize)
                {
                    ladyBugField[currentIndex] = 1;
                }
            }
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                int currentIndex = int.Parse(commands[0]);
                bool isFirst = true;
                while (currentIndex >= 0 && currentIndex < fieledSize && ladyBugField[currentIndex] != 0)
                {
                    if (isFirst)
                    {
                        ladyBugField[currentIndex] = 0;
                        isFirst = false;
                    }

                    string direction = commands[1];
                    int flightLength = int.Parse(commands[2]);
                    if (direction == "left")
                    {
                        currentIndex -= flightLength;
                        if (currentIndex >= 0 && currentIndex < fieledSize)
                        {
                            if (ladyBugField[currentIndex] == 0)
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flightLength;
                        if (currentIndex >= 0 && currentIndex < fieledSize)
                        {
                            if (ladyBugField[currentIndex] == 0)
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }
                            
                        }
                    }

                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", ladyBugField));
        }
    }
}
