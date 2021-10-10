using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;
            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                apartment = 77;
            }

            double totalPriceForStudio = studio * numberOfNights;
            double totalPriceForApartment = apartment * numberOfNights;
            if ((numberOfNights > 7 && numberOfNights <= 14) && (month == "May" || month == "October")) // (numberOfNights > 7 && numberOfNights <= 14) instead (numberOfNights > 7 && numberOfNights < 14) & Order of operations - undefined priority of  parentheses
            {
                totalPriceForStudio *= 0.95;
            }
            else if (numberOfNights > 14 && (month == "May" || month == "October")) // Order of operations - undefined priority of parentheses
            {
                totalPriceForStudio *= 0.70;
            }

            if (numberOfNights > 14 && (month == "June" || month == "September"))// Order of operations - undefined priority of  parentheses
            {
                totalPriceForStudio *= 0.80;
            }

            if (numberOfNights > 14)
            {
                totalPriceForApartment *= 0.90;
            }

            Console.WriteLine($"Apartment: {totalPriceForApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceForStudio:f2} lv.");
        }
    }
}