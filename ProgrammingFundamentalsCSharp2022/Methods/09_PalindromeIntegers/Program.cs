using System;

namespace _09_PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetPalindrome();
        }

        static void GetPalindrome()
        {
            while (true)
            {
                string palindrome = Console.ReadLine();
                if (palindrome == "END")
                {
                    break;
                }
                
                if (IsPalindrome(palindrome))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        private static bool IsPalindrome(string palindromes)
        {
            int paldinromeLength = palindromes.Length - 1;
            for (int i = 0; i < palindromes.Length; i++)
            {
                if (palindromes[i] != palindromes[paldinromeLength - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
