using System;
using System.Linq;

namespace _10._Repeating_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the repeating number. All other numbers occur only once.
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int element = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                        element = arr[i];
                    }
                    else
                    {
                        counter = 1;
                    }
                }             
            }
            Console.WriteLine($"{element}");
        }
    }
}
