using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double usdToBgnConversionRate = 1.79549;
            double bgn = usd * usdToBgnConversionRate;

            Console.WriteLine(bgn);

        }
    }
}
