using System;

namespace _3._Maximum_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];

            for (int i = 0; i < a; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // Създават се три променливи: counter, max и element. Променливата counter се инициализира с 1, а не с 0,
            // защото, към един вече съществуващ елемент се прибавят еднаквите му,
            // а max ще пази най-дългата поредица от повтарящи се елементи. Променливата element ще покаже кой точно
            // елемент се повтаря
            int counter = 1;
            int max = 0;
            int element = 0;
            //Използваме for цикъл, приключващ до дължината на масива – 1, тъй като индексът на последния елемент е дължината
            //на масива – 1 (защото позициите се броят от 0). Променливата counter се увеличава, щом срещне два или повече
            //еднакви елемента
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
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
                    element = arr[i];
                }
            }
            Console.WriteLine($"{0}");
        }
    }
}
