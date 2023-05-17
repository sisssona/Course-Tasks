using System;
using System.Linq;

namespace _4._Is_Array_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool isSorted = true;


            for (int i = 1; i < arr.Length; i++)
            {
                
                if (arr[i-1] > arr[i])
                {
                    isSorted = false;    
                }
                else 
                {
                    isSorted = true;
                }
            }
            if (isSorted)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
           
        }
    }
}
