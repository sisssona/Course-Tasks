using System;

namespace _9._Play_with_Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Please enter an int:" );
                    int input1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(input1 + 1);
                    break;
                case "2":
                    Console.WriteLine("Please enter a double:");
                    double input2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(input2 + 1);
                    break;
                case "3":
                    Console.WriteLine("Please enter a string:");
                    string input3 = Console.ReadLine();
                    Console.WriteLine($"{input3}*");
                    break;
            }
        }
    }
}
