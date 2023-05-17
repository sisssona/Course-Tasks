using System;

namespace _1._Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstarr = new int[n];
            int[] secondarr = new int[n];
            bool isEqual = true;


            for (int i = 0; i < n; i++)
            {
                firstarr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                secondarr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < firstarr.Length; i++)
            {
                if (firstarr[i] == secondarr[i])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                }
                
            }
            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else 
            {
                Console.WriteLine("Not equal");
            }
            
        }
    }
}
