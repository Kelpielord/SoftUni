using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (day == "Sunday" || hour < 10 || hour > 18)
            {
                Console.WriteLine("closed");
                return;
            }

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("open");
                    break;
                case "Tuesday":
                    Console.WriteLine("open");
                    break;
                case "Wednesday":
                    Console.WriteLine("open");
                    break;
                case "Thursday":
                    Console.WriteLine("open");
                    break;
                case "Friday":
                    Console.WriteLine("open");
                    break;
                case "Saturday":
                    Console.WriteLine("open");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
    }
}