using System;
using System.Linq;

namespace _5._Find_Two_Biggest_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int firstBigger = 0;
            int secondBigger = 0;

                for (int i = 1; i < arr.Length - 1; i++)
                {
                    int current = arr[i];
                    if (firstBigger < current)
                    {
                        secondBigger = firstBigger;
                        firstBigger = current;
                    }
                    else if (secondBigger < current)
                    {
                        secondBigger = current;
                    }

                }
                Console.WriteLine($"{firstBigger} {secondBigger}");
            }
        }
    }

