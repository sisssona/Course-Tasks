using System;
using System.Linq;

namespace _3._Maximum_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            // Създават се три променливи: counter, max и element. Променливата counter се инициализира с 1, а не с 0,
            // защото, към един вече съществуващ елемент се прибавят еднаквите му,
            // а max ще пази най-дългата поредица от повтарящи се елементи. Променливата element ще покаже кой точно
            // елемент се повтаря
            int counter = 1;
            int max = 0;
            int element = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                //max запазва най-дългата от всички поредици еднакви елементи. Когато срещне поредица от еднакви елементи
                //по-голяма от стойността на counter, max се инициализира с counter
                if (max < counter)
                {
                    max = counter;
                    element = input[i];
                }
            }
            Console.WriteLine($"{max}");
        }
    }
}

