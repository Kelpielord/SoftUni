using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main()
        {
            double temperatura = double.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string shoes = string.Empty;
            string outfit = string.Empty;

            if (timeOfDay == "Morning")
            {
                if (temperatura >= 10 && temperatura <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (temperatura >= 18 && temperatura <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperatura >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            if (timeOfDay == "Afternoon")
            {
                if (temperatura >= 10 && temperatura <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperatura > 18 && temperatura <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temperatura >= 25)
                {
                    outfit = "Swimsuit";
                    shoes = "Barefoot";
                }
            }
            if (timeOfDay == "Evening")
            {
                if (temperatura >= 10)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temperatura} degrees, get your {outfit} and {shoes}.");
        }
    }
}