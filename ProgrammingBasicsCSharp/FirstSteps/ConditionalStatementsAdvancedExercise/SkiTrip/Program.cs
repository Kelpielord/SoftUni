using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string typeRoom = Console.ReadLine();
            string revew = Console.ReadLine();
            double roomPrice = 0;
            double totalPrice = 0;
            double discount = 0;

            switch (typeRoom)
            {
                case "room for one person":
                    roomPrice = 18;
                    break;

                case "apartment":
                    roomPrice = 25;
                    totalPrice = roomPrice * days; 

                    if (days < 10)
                    {
                        discount = totalPrice * 0.30;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = totalPrice * 0.35;
                    }
                    else if (days > 15)
                    {
                        discount = totalPrice * 0.50;
                    }
                    break;

                case "president apartment":
                    roomPrice = 35;

                    totalPrice = roomPrice * days; 

                    if (days < 10)
                    {
                        discount = totalPrice * 0.10;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = totalPrice * 0.15;
                    }
                    else if (days > 15)
                    {
                        discount = totalPrice * 0.20;
                    }
                    break;
            }
            totalPrice = days * roomPrice - discount;
            double finalSum = 0;

            if (revew == "positive")
            {
                finalSum = totalPrice + (totalPrice * 0.25);
            }
            else
            {
                finalSum = totalPrice - (totalPrice * 0.10);
            }
            Console.WriteLine($"{finalSum:f2}");
        }
    }
}