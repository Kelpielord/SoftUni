using System;

namespace _04_PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minDigits = 6;
            int maxDigits = 10;
            int minAmountOfDigits = 2;

            string password = Console.ReadLine();
            bool isValid = true;
            if (!PasswordIsBetween(password, minDigits, maxDigits))
            {
                isValid = false;
                Console.WriteLine($"Password must be between {minDigits} and {maxDigits} characters");
            }
            if (!PasswordHasOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (!PasswordHasMinDigits(password, minAmountOfDigits))
            {
                Console.WriteLine($"Password must have at least {minAmountOfDigits} digits");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool PasswordIsBetween(string password, int minChars, int maxChars)
        {
            if (password.Length >= minChars && password.Length <= maxChars)
            {
                return true;
            }
            return false;
        }

        static bool PasswordHasOnlyLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                bool isSmallLetter = password[i] >= 'a' && password[i] <= 'z';
                bool isUpperCaseLetter = password[i] >= 'A' && password[i] <= 'Z';
                bool isNumber = password[i] >= '0' && password[i] <= '9';
                if (!isSmallLetter && !isUpperCaseLetter && !isNumber)
                {
                    return false;
                }
            }
            return true;
        }

        static bool PasswordHasMinDigits(string password, int minDigits)
        {
            int currentDigitCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                bool isNumber = password[i] >= '0' && password[i] <= '9';
                if (isNumber)
                {
                    currentDigitCount++;
                }
            }

            if (currentDigitCount >= minDigits)
            {
                return true;
            }

            return false;
        }
    }
}
