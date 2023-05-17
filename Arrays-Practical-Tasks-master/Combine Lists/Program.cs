using System;
using System.Collections.Generic;
using System.Linq;

namespace Combine_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> merged = new List<int>();

            if (input1.Count >= input2.Count)
            {
                for (int i = 0; i < input1.Count; i++)
                {
                    if (i < input2.Count)
                    {
                        merged.Add(input1[i]);
                    }
                    merged.Add(input2[i]);
                }
            }
            else
            {
                for (int i = 0; i < input2.Count; i++)
                {
                    if (i < input1.Count)
                    {
                        merged.Add(input2[i]);
                    }
                    merged.Add(input1[i]);
                }
            }
            
                Console.WriteLine(string.Join(",", merged));
            

        }
    }
}
