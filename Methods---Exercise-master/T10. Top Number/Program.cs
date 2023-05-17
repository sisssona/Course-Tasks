using System;

namespace T10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNumber(n);
        }
        static void TopNumber(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (IsDigitSumDivisibleBy8(i) && HasOddDigit(i))
                    Console.WriteLine(i);               
            }
        }
        private static bool HasOddDigit(int n)
        {
            while (n > 0)
            {
                if ((n % 10) % 2 == 1)
                    return true;
                n /= 10;
            }
            return false;
        }
        private static bool IsDigitSumDivisibleBy8(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
            
        }
    }
}
