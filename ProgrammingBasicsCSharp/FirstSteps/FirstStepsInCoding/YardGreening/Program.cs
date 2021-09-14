using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardSize = double.Parse(Console.ReadLine());
            double yardGreeningPrice = 7.61;
            double discount = 0.18;

            double priceCalc = yardSize * yardGreeningPrice;
            double finalDiscount = discount * priceCalc;
            double finalPrice = priceCalc - finalDiscount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {finalDiscount} lv.");

        }
    }
}
