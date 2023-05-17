using System;
using System.Collections.Generic;
using System.Linq;

namespace Rotate_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                numbers.Add(numbers[0]);
                numbers.Remove(numbers[0]);
            }

            Console.Write(string.Join(",", numbers));
        }
    }
}
