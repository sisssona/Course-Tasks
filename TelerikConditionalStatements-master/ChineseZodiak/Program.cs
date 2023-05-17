using System;

namespace ChineseZodiak
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string animal = "";
            int zodiak = input % 12;

            switch (zodiak)
            {
                case 0:
                    animal = "Monkey";
                    break;
                case 1:
                    animal = "Rooster";
                    break;
                case 2:
                    animal = "Dog";
                    break;
                case 3:
                    animal = "Pig";
                    break;
                case 4:
                    animal = "Rat";
                    break;
                case 5:
                    animal = "Ox";
                    break;
                case 6:
                    animal = "Tiger";
                    break;
                case 7:
                    animal = "Hare";
                    break;
                case 8:
                    animal = "Dragon";
                    break;
                case 9:
                    animal = "Snake";
                    break;
                case 10:
                    animal = "Horse";
                    break;
                case 11:
                    animal = "Sheep";
                    break;
                
            }
            Console.WriteLine(animal);
        }
    }
}
