using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();

            double serialTime = double.Parse(Console.ReadLine());
            double breakTime = double.Parse(Console.ReadLine());

            double lunchTime = breakTime / 8;
            double coffeeTime = breakTime / 4;

            double timeLeft = breakTime - (lunchTime + coffeeTime);
            double neededTime = Math.Abs(timeLeft - serialTime);

            Console.WriteLine(timeLeft >= serialTime
                ? $"You have enough time to watch {serialName} and left with {Math.Ceiling(neededTime)} minutes free time."
                : $"You don't have enough time to watch {serialName}, you need {Math.Ceiling(neededTime)} more minutes.");
        }
    }
}
