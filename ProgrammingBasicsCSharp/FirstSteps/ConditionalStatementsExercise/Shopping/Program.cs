using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int proccesors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videoCardsCost = videoCards * 250;
            double proccesorsCost = 0.35 * videoCardsCost;
            double proccesorsSum = proccesors * proccesorsCost;
            double ramCost = 0.10 * videoCardsCost;
            double ramSum = ram * ramCost;

            double finalSum = videoCardsCost + proccesorsSum + ramSum;
            if (videoCards > proccesors)
            {
                finalSum -= finalSum * 0.15;
            }
            if (finalSum <= budget)
            {
                double sum = budget - finalSum;
                Console.WriteLine($"You have {sum} leva left!");
            }
            else
            {
                double sum = finalSum - budget;
                Console.WriteLine($"Not enough money! You need {sum:F2} leva more!");

            }

        }
    }
}
