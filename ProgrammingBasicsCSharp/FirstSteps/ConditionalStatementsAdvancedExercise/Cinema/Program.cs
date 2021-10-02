using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double cost = 0;

            switch (type)
            {
                case "Premiere":
                    cost = rows * columns * 12.00;
                    break;
                case "Normal":
                    cost = rows * columns * 7.50;
                    break;
                case "Discount":
                    cost = rows * columns * 5.00;
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }

            Console.WriteLine($"{cost:F2} leva");
        }
    }
}