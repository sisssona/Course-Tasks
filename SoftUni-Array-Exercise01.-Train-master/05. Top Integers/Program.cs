﻿using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputArr.Length; i++)
            {
                bool isNumberBigger = true;
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] <= inputArr[j])
                    {
                        isNumberBigger = false;
                    }

                }
                if (isNumberBigger)
                {
                    Console.Write(inputArr[i] + " ");
                }

            }
        }
    }
}
