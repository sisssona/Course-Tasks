using System;

namespace T02.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double spaceshipWidth = double.Parse(Console.ReadLine());
            double spaceshipLength = double.Parse(Console.ReadLine());
            double spaseshipHeight = double.Parse(Console.ReadLine());
            double astronautsAverageHeight = double.Parse(Console.ReadLine());

            double spaceshipVolume = spaceshipWidth * spaceshipLength * spaseshipHeight;
            double astronautRoom = 2 * 2 * (astronautsAverageHeight + 0.40);
            int astronauts = (int)Math.Floor(spaceshipVolume / astronautRoom);

            if (astronauts >= 3 && astronauts <=10)
            {
                Console.WriteLine($"The spacecraft holds {astronauts} astronauts.");
            }
            else if (astronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronauts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }


        }
    }
}
