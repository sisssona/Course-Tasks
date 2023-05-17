using System;
using System.Linq;

namespace RandomSwap
{
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < text.Length-1; pos1++)
            {
                int pos2 = rnd.Next(text.Length);
                
            }
            Console.WriteLine(string.Join(Environment.NewLine, text));

        }
    }
}
