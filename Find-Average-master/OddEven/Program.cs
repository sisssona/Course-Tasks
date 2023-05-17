using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int oddOrEvenNum = 0;
            int oddProduct = 1;
            int evenProduct = 1;
            

            for (int i = 1; i <= n; i++)
            {
                
                int number = int.Parse(Console.ReadLine());
                oddOrEvenNum = number;
                if (i % 2 != 0)
                {
                    int oddLine = i;
                    oddProduct *= number;
                }   
                else if (i % 2 == 0)
                {
                    int evenLine = i;
                    evenProduct *= number;
                }
            }           
            if (oddProduct == evenProduct)
            {
                Console.WriteLine($"yes {oddProduct}");
            }
            else
            {
                Console.WriteLine($"no {oddProduct} {evenProduct}");
            }
        }
    }
}
