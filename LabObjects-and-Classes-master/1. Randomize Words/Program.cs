using System;
using System.Linq;

namespace RandomSwapWords
{
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < text.Length - 1; pos1++)
            {
                int pos2 = rnd.Next(text.Length);

                string c = text[pos1];
                text[pos1] = text[pos2];
                text[pos2] = c;


            }
            Console.WriteLine(string.Join(Environment.NewLine, text));

        }
    }
}


