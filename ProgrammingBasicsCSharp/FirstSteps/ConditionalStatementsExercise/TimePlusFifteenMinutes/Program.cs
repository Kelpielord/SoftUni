using System;

namespace TimePlusFifteenMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int fifteenMinutes = 15;
            int totalMinutes = hours * 60 + minutes;
            int hoursCalc = (totalMinutes + fifteenMinutes) / 60;
            int minutesCalc = (totalMinutes + fifteenMinutes) % 60;

            if (hoursCalc == 24)
            {
                hoursCalc = 0;
            }
            Console.WriteLine($"{hoursCalc}:{minutesCalc:D2}");

        }
    }
}
