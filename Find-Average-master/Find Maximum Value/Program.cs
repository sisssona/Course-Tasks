using System;

namespace Find_Maximum_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (maxNumber < numbers)
                {
                    maxNumber = numbers;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
