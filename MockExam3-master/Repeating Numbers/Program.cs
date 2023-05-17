using System;
using System.Linq;

namespace _10._Repeating_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int counter = 1;
            int longestOccurance = 0;
            int repeatingNumber = 0;


            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr); //след това сравняваме i с i+1  и затова повтарящите се числа трябва да са едно след друго
            if (n == 1)
            {
                repeatingNumber = arr[0];
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > longestOccurance)
                {
                    longestOccurance = counter;
                    repeatingNumber = arr[i];
                }

            }
            Console.WriteLine(repeatingNumber);

        }
    }
}