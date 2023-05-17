using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Sort(input);

            int rows = int.Parse(Console.ReadLine());
            string wordToCompareWith = string.Join(string.Empty, input);

            
            for (int i = 0; i < rows; i++)
            {
                char[] newWord = Console.ReadLine().ToCharArray();
                Array.Sort(newWord);
                string currentWord = string.Join(string.Empty, newWord);

                if (currentWord == wordToCompareWith)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }

        }
    }
}
