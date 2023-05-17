using System;
using System.Collections.Generic;

namespace Merging_and_Squashing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] previousNum = Console.ReadLine().ToCharArray();
            List<string> mergedNums = new List<string>();
            List<string> squashedNums = new List<string>();


            for (int i = 0; i < n - 1; i++)
            {
                char[] currentNum = Console.ReadLine().ToCharArray();

                mergedNums.Add($"{previousNum[1]}{currentNum[0]}");

                int firstNum = int.Parse(previousNum[1].ToString());
                int secondNum = int.Parse(currentNum[0].ToString());
                int result = firstNum + secondNum;

                if (result >= 10)
                {
                    int numToBeInserted = result % 10;
                    squashedNums.Add($"{previousNum[0]}{numToBeInserted}{currentNum[1]}");
                }
                else
                {
                    squashedNums.Add($"{previousNum[0]}{result}{currentNum[1]}");
                }

                previousNum = currentNum;

            }
            Console.WriteLine(string.Join(" ", mergedNums));
            Console.WriteLine(string.Join(" ", squashedNums));
        }
    }
}
