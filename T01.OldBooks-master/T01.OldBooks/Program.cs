using System;

namespace T01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int countedBooks = 0;
            string book = Console.ReadLine();

            while (book != searchedBook)
            {
                countedBooks++;
                book = Console.ReadLine();
                if (book == "No more books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {countedBooks} books.");
                    break;
                }
            }

            if (searchedBook == book)
            {
                Console.WriteLine($"You checked {countedBooks} books and found it.");
            }
        }
    }
}
