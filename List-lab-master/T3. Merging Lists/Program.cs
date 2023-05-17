using System;
using System.Collections.Generic;
using System.Linq;

namespace T3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstListNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondListNumber = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mergedList = new List<int>();
            int biggerListCount = Math.Max(firstListNumbers.Count, secondListNumber.Count);
            if (biggerListCount < secondListNumber.Count)
            {
                biggerListCount = secondListNumber.Count;
            }

            for (int i = 0; i < biggerListCount; i++)
            {
                if (firstListNumbers.Count > i)
                {
                    mergedList.Add(firstListNumbers[i]);
                }
                if (secondListNumber.Count > i)
                {
                    mergedList.Add(secondListNumber[i]);
                }

            }
            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
