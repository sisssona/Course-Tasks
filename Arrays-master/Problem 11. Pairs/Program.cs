using System;
using System.Linq;

namespace Problem_11._Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that find all pairs of integers whose sum is equal to a given number.
            //On the first line you will receive the target sum, on the second line - the array.
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (n == arr[i] + arr[j])
                    {
                        Console.WriteLine(arr[i] + ", " + arr[j]);
                    }
                }

            }
        }
    }
}
