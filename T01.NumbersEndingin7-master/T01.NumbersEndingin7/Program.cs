using System;

namespace T01.NumbersEndingin7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int iterator = 0; iterator < 1000; iterator++)
            {
                if (iterator % 10 == 7)
                {
                    Console.WriteLine(iterator);
                }
            }
        }
    }
}
