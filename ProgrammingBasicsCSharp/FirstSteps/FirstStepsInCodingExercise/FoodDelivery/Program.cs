using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chikenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chikenMenuCost = 10.35;
            double fishMenuCost = 12.40;
            double vegetarianMenuCost = 8.15;
            double shipping = 2.50;

            double chikenFinal = chikenMenu * chikenMenuCost;
            double fishFinal = fishMenu * fishMenuCost;
            double vegetarianFinal = vegetarianMenu * vegetarianMenuCost;
            double allFoodCount = chikenFinal + fishFinal + vegetarianFinal;
            double desert = allFoodCount * (20 / 100.0);
            double finalCount = allFoodCount + desert + shipping;

            Console.WriteLine(finalCount);
        }
    }
}
