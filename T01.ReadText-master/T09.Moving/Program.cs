using System;

namespace T09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpace = width * length * height;

            string command = Console.ReadLine();

            while (command != "Done")
            {
                freeSpace -= int.Parse(command);

                if (freeSpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Done")
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
            
        }
    }
}
