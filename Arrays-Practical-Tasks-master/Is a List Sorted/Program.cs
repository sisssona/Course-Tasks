using System;
using System.Collections.Generic;
using System.Linq;

namespace Is_a_List_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();
            bool isSorted = true;
            string[] result = new string[n];

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(',').Select(int.Parse).ToList();
                for (int j = 0; j < input.Count - 1; j++)
                {
                    if (input[j] <= input[j + 1])
                    {
                        isSorted = true;

                    }
                    else
                    {
                        isSorted = false;
                    }
                    result[i] = (Convert.ToString(isSorted)).ToLower();

                }
                Console.WriteLine(result[i]);
            }

        }

    }

}