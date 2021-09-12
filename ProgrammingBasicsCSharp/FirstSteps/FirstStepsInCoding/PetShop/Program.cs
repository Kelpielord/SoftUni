using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {

            int dogFoodToBuy = int.Parse(Console.ReadLine());
            int catFoodToBuy = int.Parse(Console.ReadLine());

            double dogFood = 2.50;
            double catfood = 4;
            double finalPrice = dogFoodToBuy * dogFood + catFoodToBuy * catfood;

            Console.WriteLine($"{finalPrice} lv.");
        }
    }
}
