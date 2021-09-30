using System;

namespace SwimmingWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceInMetters = double.Parse(Console.ReadLine());
            double timeForMetter = double.Parse(Console.ReadLine());
            double delay = 0;

            if (distanceInMetters >= 15)
            {
                delay = Math.Floor(distanceInMetters / 15) * 12.5;
            }
            double finalTime = distanceInMetters * timeForMetter + delay;

            if (finalTime < recordSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(finalTime - recordSeconds):f2} seconds slower.");
            }
        }
    }
}
