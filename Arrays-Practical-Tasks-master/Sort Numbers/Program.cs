using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();
            Console.Write(string.Join(", ", numbers));

        }
    }
}
