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
            char[] first = firstArrayString.ToCharArray();
            char[] second = secondArrayString.ToCharArray();


            foreach (var item in first)
            {

            }
            foreach (var item in second)
            {

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

