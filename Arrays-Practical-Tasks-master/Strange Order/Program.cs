using System;
using System.Collections.Generic;
using System.Linq;

namespace Strange_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> negative = new List<int>();
            List<int> zero = new List<int>();
            List<int> positive = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    negative.Add(numbers[i]);
                }
                if (numbers[i] == 0)
                {
                    zero.Add(numbers[i]);
                }
                if (numbers[i] > 0)
                {
                    positive.Add(numbers[i]);
                }
            }
            var sumLists = negative.Concat(zero).Concat(positive).ToList();

                    Console.Write(string.Join(",", sumLists));
            
        }
    }
}
