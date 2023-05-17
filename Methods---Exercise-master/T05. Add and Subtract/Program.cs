using System;

namespace T05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            
            Console.WriteLine(SubtractThirdInteger(firstInt, secondInt, thirdInt));
        }
        static int SumFirstAndSecondInteger(int firstInt, int secondInt)
        {
            int sum = firstInt + secondInt;
            return sum;
        }
        static int SubtractThirdInteger(int firstInt, int secondInt, int thirdInt)
        {
            int sum = firstInt + secondInt;
            int result = sum - thirdInt;
            return result;
        }
    }
}
