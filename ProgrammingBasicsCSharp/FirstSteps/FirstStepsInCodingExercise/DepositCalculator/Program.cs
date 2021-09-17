using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositMonth = int.Parse(Console.ReadLine());
            double yearlyInterest = double.Parse(Console.ReadLine());

            double yearInterestSum = depositSum * (yearlyInterest / 100);
            double interestForOneMonth = yearInterestSum / 12;
            double sum = depositSum + depositMonth * interestForOneMonth;
            Console.WriteLine(sum);
        }
    }
}
