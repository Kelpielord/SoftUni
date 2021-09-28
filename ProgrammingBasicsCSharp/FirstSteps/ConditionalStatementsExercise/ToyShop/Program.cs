using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int soldPuzzels = int.Parse(Console.ReadLine());
            int soldDolls = int.Parse(Console.ReadLine());
            int soldTeddybears = int.Parse(Console.ReadLine());
            int soldMinions = int.Parse(Console.ReadLine());
            int soldTrucks = int.Parse(Console.ReadLine());

            double puzzelsMoney = soldPuzzels * 2.60;
            double dollsMoney = soldDolls * 3;
            double teddybearsMoney = soldTeddybears * 4.1;
            double minionsMoney = soldMinions * 8.2;
            double trucksMoney = soldTrucks * 2;

            double total = puzzelsMoney + dollsMoney + minionsMoney + teddybearsMoney + trucksMoney;

            int soldToys = soldPuzzels + soldDolls + soldTeddybears + soldTrucks + soldMinions;

            if (soldToys >= 50)
            {
                total = total * 0.75;
            }
            total = total * 0.9;

            if (total >= travelPrice)
            {
                double remaining = total - travelPrice;
                Console.WriteLine($"Yes! {remaining:f2} lv left.");
            }
            else
            {
                double neededMoney = travelPrice - total;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }
        }
    }
}
