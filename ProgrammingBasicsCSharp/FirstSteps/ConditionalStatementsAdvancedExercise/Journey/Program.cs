using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = string.Empty;

            double priceForTrip = 0;
            string typeOfTrip = string.Empty;

            if (season == "summer")
            {
                if (budget <= 100)
                {
                    priceForTrip = budget * 0.3;
                    destination = "Bulgaria";
                    typeOfTrip = "Camp";
                }

                else if (budget <= 1000)
                {
                    priceForTrip = budget * 0.4;
                    destination = "Balkans";
                    typeOfTrip = "Camp";
                }

                else if (budget > 1000)
                {
                    priceForTrip = budget * 0.9;
                    destination = "Europe";
                    typeOfTrip = "Hotel";
                }
            }
            else if (season == "winter")
            {
                if (budget <= 100)
                {
                    priceForTrip = budget * 0.7;
                    destination = "Bulgaria";
                    typeOfTrip = "Hotel";
                }
                else if (budget <= 1000)
                {
                    priceForTrip = budget * 0.8;
                    destination = "Balkans";
                    typeOfTrip = "Hotel";
                }
                else if (budget > 1000)
                {
                    priceForTrip = budget * 0.9;
                    destination = "Europe";
                    typeOfTrip = "Hotel";
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfTrip} - {priceForTrip:F2}");
        }
    }
}