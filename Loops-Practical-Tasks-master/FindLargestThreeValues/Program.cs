using System;

namespace FindLargestThreeValues
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;
            

            for (int i = 0; i < n; i++)
            {
                int numberValues = int.Parse(Console.ReadLine());
                
                if (numberValues > first)
                {
                    third = second;
                    second = first;
                    first = numberValues;                   
                }                               
                else if (numberValues > second)
                {
                    third = second;
                    second = numberValues;
                }
                else if (numberValues > third)
                {
                    third = numberValues;
                }
               

            }
            Console.WriteLine($"{first}, {second} and {third}");
        }
    }
}
