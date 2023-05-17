using System;

namespace T02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            switch (time)
            {
                case "Morning":
                    if (10 <= degrees && degrees <= 18)
                    { 
                        Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                    }
                    else if (18 < degrees && degrees <= 24)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                    }
                    else if (degrees >= 25)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                    }
                    break;
                case "Afternoon":
                    if (10 <= degrees && degrees <= 18)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                    }
                    else if (18 < degrees && degrees <= 24)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                    }
                    else if (degrees >= 25)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
                    }
                    break;
                case "Evening":
                    if (10 <= degrees && degrees <= 18)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                    }
                    else if (18 < degrees && degrees <= 24)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                    }
                    else if (degrees >= 25)
                    {
                        Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                    }
                    break;
            }

        }
    }
}
