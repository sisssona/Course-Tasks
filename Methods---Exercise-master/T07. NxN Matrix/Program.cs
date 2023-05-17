using System;

namespace T07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives a single integer n and prints an NxN matrix using this number as a filler.
            int n = int.Parse(Console.ReadLine());
            NxnMatrix(n);
        }
        static void NxnMatrix(int n)
        {
            for (int i = 0; i <= n-1; i++)
            {               
                for (int j = 1; j <= n-1; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine(n);
            }
            
        }
    }
}
