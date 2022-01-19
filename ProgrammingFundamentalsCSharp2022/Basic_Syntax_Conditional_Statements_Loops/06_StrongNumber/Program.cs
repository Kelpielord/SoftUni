using System;

namespace _06_StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            double sum = 0;
            double currentDigit = 0;
            foreach (var c in n)
            {
                double factorialResult = 1;

                var convertChar = char.GetNumericValue(c);
                for (double i = convertChar; i >= 1; i--)
                {
                    factorialResult *= i;
                }
                sum += factorialResult;
            }
            
            if (sum == int.Parse(n))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
