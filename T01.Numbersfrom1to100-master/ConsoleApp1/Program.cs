using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 2147483647;
            int min = -2147483648;

            int number = 0;

            for (int i = 0; i <= n; i++)
            {
                if (number > max)
                {
                    number = max;
                }
                Console.WriteLine($"Max number: {number}"); 
            }
            for (int i = 0; i >= n; i++)
            {
                if (number < min)
                {
                    number = min;
                }
                Console.WriteLine($"Min number: {number}");
            }
                
                
                
            
        }
    }
}
