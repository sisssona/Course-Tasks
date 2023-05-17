using System;
using System.Linq;

namespace _7._Is_Array_in_Wave_Form
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool wave = true;

            for (int i = 0; i < array.Length-1; i += 2)
            {
                if (array[i+1] < array[i])
                {
                    wave = true;
                }
                else if (array[i+1] > array[i])
                {
                    wave = false;
                }
            }
            if (wave)
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
