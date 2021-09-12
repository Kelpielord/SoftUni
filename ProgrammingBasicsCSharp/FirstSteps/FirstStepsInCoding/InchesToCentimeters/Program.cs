using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double conversionRate = 2.54;
            double result = inches * conversionRate;
            Console.WriteLine(result);
        }
    }
}
