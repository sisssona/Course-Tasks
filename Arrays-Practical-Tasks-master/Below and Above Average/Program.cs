using System;
using System.Collections.Generic;
using System.Linq;

namespace Below_and_Above_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            double sum = 0;
            double average = 0;
            int below = 0;
            int above = 0;
            List<int> belowList = new List<int>();
            List<int> aboveList = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {

                sum += numbers[i];

            }
            average = sum / numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < average)
                {
                    below = numbers[i];
                    belowList.Add(below);
                    
                    
                    
                    
                }
                else if (numbers[i] > average)
                {
                    above = numbers[i];
                    aboveList.Add(above);

                }
            }
            Console.WriteLine($"avg: {average:f2}");
            Console.Write("below: ");
            Console.WriteLine(string.Join(",", belowList));
            Console.Write("above: ");
            Console.WriteLine(string.Join(",", aboveList));
        }
    }
}

