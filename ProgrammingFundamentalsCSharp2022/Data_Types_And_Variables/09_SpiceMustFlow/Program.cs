using System;

namespace _09_SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int yieldDecrease = 10;
            int day = 0;
            int currentSpice = 0;
            int spiceEatenFromWorkers = 26;

            while (yield >= 100)
            {
                
                currentSpice += yield;
                if(spiceEatenFromWorkers <= currentSpice)
                {
                    currentSpice -= spiceEatenFromWorkers;
                }
                yield -= yieldDecrease;
                day++;
            }

            if (spiceEatenFromWorkers <= currentSpice)
            {
                currentSpice -= spiceEatenFromWorkers;
            }

            Console.WriteLine(day);
            Console.WriteLine(currentSpice);

        }
    }
}
