using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            int value = 0;
            List<int> numbersSorted = new List<int>(numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                value = numbers[i];
                if (value != 0)
                {
                    numbersSorted.Add(value);
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                value = numbers[i];
                if (value == 0)
                {
                    int zeroValue = value;
                    numbersSorted.Add(zeroValue);
                }
            }
            Console.WriteLine(string.Join(",", numbersSorted));

        }
    }
}
