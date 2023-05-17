using System;
using System.Collections.Generic;
using System.Linq;

namespace Alone_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());
            int biggerNum = 0;
            int[] targetArray = new int[array.Length];

            if (array[0] == 0)
            {
                targetArray[0] = target;
            }

            for (int i = 1; i <= array.Length - 2; i++)
            {
                if (array[i] == 0)
                {
                    targetArray[i] = target;
                    
                }
                
                
                    targetArray[0] = array[0];
                
               
                                       
                if (array[i] == target || array[i] == 0)
                {
                    if (array[i - 1] > array[i + 1])
                    {
                        biggerNum = array[i - 1];
                        targetArray[i] = biggerNum;
                    }
                    if (array[i - 1] < array[i + 1])
                    {
                        biggerNum = array[i + 1];
                        targetArray[i] = biggerNum;
                    }
                }
                else
                {
                    targetArray[i] = array[i];
                }
            }
            targetArray[array.Length - 1] = array[array.Length - 1];

            String seperator = ", ";
            string result = String.Join(seperator, targetArray);
            Console.WriteLine($"[{result}]");

        }
    }
}
