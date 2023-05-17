using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',');
            string missingNums = "";

            for (int currentNumber = 1; currentNumber <= input.Length; currentNumber++)
            {
                bool isFound = false;
                foreach (string item in input)
                {
                    if (currentNumber == int.Parse(item))
                    {
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    if (missingNums.Length > 0)
                    {
                        missingNums += ',';
                    }
                    missingNums += currentNumber;
                }
            }
            Console.WriteLine(missingNums);
        }
    }
}

