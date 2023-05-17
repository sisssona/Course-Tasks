using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Print_Maximum_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int longestSeq = 0;
            int counter = 0;
            int endIndex = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] < input[i])
                {
                    counter++;
                }
                else
                {
                    if (counter > longestSeq)
                    {
                        longestSeq = counter;
                        endIndex = i - 1;
                    }
                    counter = 0;
                }
                if (i == input.Length - 1)
                {
                    if (counter > longestSeq)
                    {
                        longestSeq = counter;
                        endIndex = i;
                    }
                }
            }
            for (int i = endIndex - longestSeq; i <= endIndex; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}













