using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());

            Console.WriteLine(dogs * 2.50 + animals * 4 + " lv.");
            
        }
    }
}
