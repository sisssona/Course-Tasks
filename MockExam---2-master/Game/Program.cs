using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            int firstNum = input / 100;
            int secondNum = (input / 10) % 10;
            int thirdNum = input % 10;

            int firstResult = firstNum + secondNum + thirdNum;
            int secondResult = firstNum * secondNum * thirdNum;
            int thirdResult = firstNum + secondNum * thirdNum;
            int fourthResult = firstNum * secondNum + thirdNum;
            

            List<int> nums = new List<int>() { firstResult, secondResult, thirdResult, fourthResult};

            int max = nums.Max();

            Console.WriteLine(max);
            
        }
    }
}
