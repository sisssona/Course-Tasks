using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hey hello 2 4
            string[] arrOne = Console.ReadLine().Split(" ");
            // 10 hey 4 hello
            string[] arrTwo = Console.ReadLine().Split(" ");

            foreach (string elementsTwo in arrTwo)
            {
                for (int i = 0; i < arrOne.Length; i++)
                {
                    string elementOne = arrOne[i];
                    if (elementsTwo == elementOne)
                    {
                        Console.Write(elementOne + " ");
                        break;
                    }
                }

            }
           

        

        }
    }
}
