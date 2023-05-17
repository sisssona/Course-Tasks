using System;

namespace T04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordLengthValid = PasswordLength(password);
            bool isPasswordContainsValidSymbols = PasswordText(password);
            bool isDigitInPasswordAtLeastTwo = PasswordDigit(password);

            if (!isPasswordLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordContainsValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isDigitInPasswordAtLeastTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPasswordLengthValid && isPasswordContainsValidSymbols && isDigitInPasswordAtLeastTwo)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool PasswordLength(string text)
        {
            return text.Length >= 6 && text.Length <= 10;              
        }
        static bool PasswordText(string text)
        {
            bool checker = true;
            foreach (char character in text)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }               
            }
            return checker;
        }
        static bool PasswordDigit(string text)
        {
            int countDigit = 0;
            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    countDigit++;
                }               
            }
            return countDigit >= 2;
        } 
    }
}
