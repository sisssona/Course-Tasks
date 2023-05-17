using System;
using System.Linq;

namespace _6._Is_Array_Symmetric
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bool symmetric = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }
            if (symmetric)
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
