using System;

namespace _2._Compare_Character_Arrays_Lexicographically
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstArrayString = Console.ReadLine();
            string secondArrayString = Console.ReadLine();
            //convert string to char array


            for (int i = 0; i < Math.Min(firstArrayString.Length, secondArrayString.Length); i++)
            {
                char[] first = firstArrayString.ToCharArray();

                char[] second = secondArrayString.ToCharArray();
            }

            if (string.Compare(firstArrayString, secondArrayString) == 0)
            {
                Console.WriteLine("Equal");
            }
            else if (string.Compare(firstArrayString, secondArrayString) > 0)
            {
                Console.WriteLine("Second");
            }
            else if (string.Compare(firstArrayString, secondArrayString) < 0)
            {
                Console.WriteLine("First");
            }







        }






    }
}

