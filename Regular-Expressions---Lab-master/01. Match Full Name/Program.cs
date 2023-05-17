using System.Text.RegularExpressions;
using System;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string names = Console.ReadLine();

            MatchCollection validNames = Regex.Matches(names, regex);
            foreach (Match name in validNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}