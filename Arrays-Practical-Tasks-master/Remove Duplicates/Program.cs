using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> duplicates = Console.ReadLine().Split(',').ToList();
            List<string> noDuplicates = duplicates.Distinct().ToList();

            Console.Write(string.Join(",", noDuplicates));

            Console.ReadLine();          
        }
    }
}
