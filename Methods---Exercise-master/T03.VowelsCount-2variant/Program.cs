using System;

namespace T03.VowelsCount_2variant
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            SearchForVowels(inputText);
        }
        static void SearchForVowels(string text)
        {
            int count = 0;
            foreach (char vowels  in text)
            {
                if ("aeiou".Contains(vowels))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
