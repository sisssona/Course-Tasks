using System;
using System.Collections.Generic;
using System.Linq;

namespace T11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    arr = ExchangedArr(arr, int.Parse(command[1]));
                }
                else if (command[0] == "max" || command[0] == "min")
                {
                    FindMinMax(arr, command[0], command[1]);
                }
                else
                {
                    FindNumbers(arr, command[0], int.Parse(command[1]), command[2]);
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }
        static int[] ExchangedArr(int[] currentArray, int splitIndex)
        {
            if (splitIndex >= currentArray.Length || splitIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return currentArray;
            }
            int[] exchangedArray = new int[currentArray.Length];
            int index = 0;
            for (int currentIndex = splitIndex+1; currentIndex < currentArray.Length; currentIndex++)
            {
                exchangedArray[index] = currentArray[currentIndex];
                index++;
            }
            for (int currIndex = 0; currIndex <= splitIndex; currIndex++)
            {
                exchangedArray[index] = currentArray[currIndex];
                index++;
            }
            return exchangedArray;
        }
        static void FindMinMax(int[] currArray, string minOrMax, string evenOrOdd)
        {
            int index = -1;
            int min = int.MaxValue;
            int max = int.MinValue;

            int resultOddEven = 1;
            if (evenOrOdd == "even") resultOddEven = 0;
            for (int currIndex = 0; currIndex < currArray.Length; currIndex++)
            {
                if (currArray[currIndex] % 2 == resultOddEven)
                {
                    if (minOrMax == "min" && min >= currArray[currIndex])
                    {
                        min = currArray[currIndex];
                        index = currIndex;
                    }
                    else if (minOrMax == "max" && max <= currArray[currIndex])
                    {
                        max = currArray[currIndex];
                        index = currIndex;
                    }
                }

            }
            if (index > -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void FindNumbers(int[] currArray, string position, int numbersCount, string evenOdd)
        {
            if (numbersCount > currArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (numbersCount == 0)
            {
                Console.WriteLine("[]");
                return;
            }
            int resultEvenOdd = 1;
            if (evenOdd == "even") resultEvenOdd = 0;

            int count = 0;
            List<int> nums = new List<int>();
            if (position == "first")
            {
                foreach (var num in currArray)
                {
                    if (num % 2 == resultEvenOdd)
                    {
                        count++;
                        nums.Add(num);
                    }
                    if (count == numbersCount) break;                                     
                }

            }
            else
            {
                for (int currIndex = currArray.Length-1; currIndex >= 0; currIndex--)
                {
                    if (currArray[currIndex] % 2 == resultEvenOdd)
                    {
                        count++;
                        nums.Add(currArray[currIndex]);
                    }
                    if (count == numbersCount) break;
                }
                nums.Reverse();
            }
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}
