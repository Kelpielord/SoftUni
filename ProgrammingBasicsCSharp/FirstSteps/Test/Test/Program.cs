using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int location = int.Parse(Console.ReadLine());
            for (int i = 0; i < location; i++)
            {
                double averageExtraction = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double sumExtraction = 0.0;
                for (int j = 0; j < days; j++)
                {
                    double extraction = Double.Parse(Console.ReadLine());
                    sumExtraction += extraction;
                }

                double averageGold = sumExtraction / days;
                if (averageGold >= averageExtraction)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGold:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {(averageExtraction - averageGold):f2} gold.");
                }
            }
        }
    }
}