using System;
using System.Linq;

namespace _8._Negative_Positive_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    Console.Write(arr[i] + " ");
            }
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > 0)
                {
                    Console.Write(arr[j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}


   