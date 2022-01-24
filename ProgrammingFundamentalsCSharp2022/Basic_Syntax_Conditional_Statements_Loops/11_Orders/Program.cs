using System;

namespace _11_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            double finalResult = 0;

            for (int i = 0; i < n; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());

                result = (days * capsules) * capsulePrice;
                Console.WriteLine($"The price for the coffee is: ${result:F2}");
                finalResult += result;
            }
            Console.WriteLine($"Total: ${finalResult:F2}");
        }
    }
}
