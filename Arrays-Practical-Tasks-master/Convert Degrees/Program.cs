using System;
using System.Collections.Generic;
using System.Linq;

namespace Convert_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> celsiusDegreeTemp = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            //T(°F) = T(°C) × 1.8 + 32
            double convertedTemp = 0;
            foreach (int item in celsiusDegreeTemp)
            { 
                convertedTemp = item * 1.8 + 32;
                Console.WriteLine(Math.Round(convertedTemp));
            }
            
        }
    }
}
