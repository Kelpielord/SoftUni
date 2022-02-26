using System;

namespace _08_FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double factorielOfNum1 = GetFactoriel(num1);
            double factorielOfNum2 = GetFactoriel(num2);

            double resultOfDivision = factorielOfNum1 / factorielOfNum2;
            Console.WriteLine($"{resultOfDivision:f2}");
        }

        static double GetFactoriel(double num)
        {
            double factoriel = 1;
            for (double i = 1; i <= num; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
