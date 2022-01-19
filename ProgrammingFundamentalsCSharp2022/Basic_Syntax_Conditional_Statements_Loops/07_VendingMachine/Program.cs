using System;
using System.Collections.Generic;

namespace _07_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> validCoins = new List<double>() { 0.1, 0.2, 0.5, 1, 2};
            Dictionary<string, double> products = new Dictionary<string, double>() 
            {
                { "Nuts", 2.0 },
                { "Water", 0.7 },
                { "Crisps", 1.5 },
                { "Soda", 0.8 },
                { "Coke", 1.0 },
            };
            double userCoins = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                double coin = double.Parse(input);
                if (validCoins.Contains(coin))
                {
                    userCoins += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }

            while (true)
            {
                string input = Console.ReadLine(); // "Nuts"
                if (input == "End")
                {
                    break;
                }

                if (!products.ContainsKey(input))
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }

                double price = products[input];
                
                if (userCoins < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                    continue;
                }

                userCoins -= price;
                Console.WriteLine($"Purchased {input.ToLower()}");
            }
            Console.WriteLine($"Change: {userCoins:F2}");
        }
    }
}
