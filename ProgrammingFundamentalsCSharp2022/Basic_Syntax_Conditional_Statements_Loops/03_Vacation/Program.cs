using System;
using System.Collections.Generic;

namespace _0_3Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double priceForStay = 0;
            double finalSum = 0;

            if (groupType == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        priceForStay = 8.45;
                        break;
                    case "Saturday":
                        priceForStay = 9.80;
                        break;
                    case "Sunday":
                        priceForStay = 10.46;
                        break;
                    default:
                        break;
                }
                if (groupCount >= 30)
                {
                    finalSum = groupCount * priceForStay * 0.85;
                }
            }
            else if (groupType == "Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        priceForStay = 10.90;
                        break;
                    case "Saturday":
                        priceForStay = 15.60;
                        break;
                    case "Sunday":
                        priceForStay = 16;
                        break;
                    default:
                        break;
                }
                if (groupCount >= 100)
                {
                    finalSum = (groupCount - 10) * priceForStay;
                }
            }
            else if (groupType == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        priceForStay = 15;
                        break;
                    case "Saturday":
                        priceForStay = 20;
                        break;
                    case "Sunday":
                        priceForStay = 22.50;
                        break;
                    default:
                        break;
                }
                if (groupCount >= 10 && groupCount <= 20)
                {
                    finalSum = groupCount * priceForStay * 0.95;
                }
            }

            if (finalSum == 0)
            {
                finalSum = groupCount * priceForStay;
            }

            Console.WriteLine($"Total price: {finalSum:F2}");
        }
    }
}
