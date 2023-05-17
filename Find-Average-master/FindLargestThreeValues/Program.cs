using System;

namespace FindLargestThreeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int largestNumber = 0;
            int secondLargestNum = 0;
            int thirdLargestNum = 0;

            for (int i = 0; i < n; i++)
            {
                int numberValues = int.Parse(Console.ReadLine());
                if (numberValues >= -500 && numberValues <= 500 && n >= 3 && n <= 20)
                {
                    if (largestNumber <= numberValues)
                    {
                        thirdLargestNum = secondLargestNum;
                        secondLargestNum = largestNumber;
                        largestNumber = numberValues;

                    }
                    else if (secondLargestNum <= numberValues)
                    {
                        thirdLargestNum = secondLargestNum;
                        secondLargestNum = numberValues;

                    }
                    else if (thirdLargestNum <= numberValues)
                    {
                        thirdLargestNum = numberValues;

                    }
                    
                }
                

               

            }
            Console.Write($"{largestNumber}, {secondLargestNum} and {thirdLargestNum}");
        }
    }
}

   
               
