﻿using System;

namespace T02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            CountVowels(word);
        }
        static int CountVowels(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' ||
                    word[i] == 'u' || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' ||
                    word[i] == 'U')
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            return count;
        }
    }
}
