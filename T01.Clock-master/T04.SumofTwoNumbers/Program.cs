using System;

namespace T04.SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinationNum = 0;

            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    combinationNum++;
                    if (num1 + num2 == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationNum} ({num1} + {num2} = {magicNum})");
                        return;
                    }
                }

            }
            Console.WriteLine($"{combinationNum} combinations - neither equals {magicNum}");
        }
    }
}
