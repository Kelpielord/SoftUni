using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrived = int.Parse(Console.ReadLine());
            int minuteOfArrived = int.Parse(Console.ReadLine());

            int totalminuteOfExam = (hourOfExam * 60) + minuteOfExam;
            int totalminuteOfArrived = (hourOfArrived * 60) + minuteOfArrived;
            int different = totalminuteOfExam - totalminuteOfArrived;

            if (totalminuteOfArrived == totalminuteOfExam)
            {
                Console.WriteLine("On time");
            }
            else if (different >= 0 && different <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{different} minutes before the start");

            }
            else if (different > 30)
            {
                if (different < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{different} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    int hour = different / 60;
                    int minutes = different % 60;
                    Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
                }
            }
            else if (different < 0)
            {
                int differentAbs = Math.Abs(different);

                if (differentAbs < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{differentAbs} minutes after the start");
                }
                else
                {
                    int hour = differentAbs / 60;
                    int minutes = differentAbs % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
        }
    }
}