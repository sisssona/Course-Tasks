using System;

namespace Prime_Factors
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            while (n % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                n /= 2;
            }

            // n must be odd at this point. So we can
            // skip one element (Note i = i +2)
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                // While i divides n, print i and divide n
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n /= i;
                }
            }

            // This condition is to handle the case whien
            // n is a prime number greater than 2
            if (n > 2)
                Console.WriteLine(n);
        }

       
    }
    
}
