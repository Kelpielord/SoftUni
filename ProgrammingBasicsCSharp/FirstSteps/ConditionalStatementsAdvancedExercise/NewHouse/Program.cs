using System;

namespace NewHouse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var flowerType = Console.ReadLine();
            var numberOfFlowers = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());

            double totalSum = 0;

            switch (flowerType)
            {
                case "Roses":
                    totalSum = numberOfFlowers * 5;

                    if (numberOfFlowers > 80) totalSum *= 0.9;

                    break;
                case "Dahlias":
                    totalSum = numberOfFlowers * 3.8;

                    if (numberOfFlowers > 90) totalSum *= 0.85;

                    break;
                case "Tulips":
                    totalSum = numberOfFlowers * 2.8;

                    if (numberOfFlowers > 80) totalSum *= 0.85;

                    break;
                case "Narcissus":
                    totalSum = numberOfFlowers * 3;

                    if (numberOfFlowers < 120) totalSum *= 1.15;

                    break;
                case "Gladiolus":
                    totalSum = numberOfFlowers * 2.5;

                    if (numberOfFlowers < 80) totalSum *= 1.2;

                    break;
            }

            if (budget >= totalSum)
                Console.WriteLine(
                    $"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {budget - totalSum:f2} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {totalSum - budget:f2} leva more.");
        }
    }
}