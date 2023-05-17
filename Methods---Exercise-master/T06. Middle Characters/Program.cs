using System;

namespace T06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a single string. Create a method that prints the character found at its middle.
            //If the length of the string is even there are two middle characters.
            string word = Console.ReadLine();
            PrintMiddleCharacter(word);
        }
        private static void PrintMiddleCharacter(string word)
        {
            if (word.Length % 2 != 0)
            {
                Console.WriteLine(word[word.Length / 2]);
            }
            else
            {
                Console.Write(word[(word.Length / 2) - 1]);
                Console.Write(word[word.Length / 2]);
            }
            Console.WriteLine();
        }
    }
}
