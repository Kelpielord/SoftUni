using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesForOneHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hoursNeeded = numberOfPages / pagesForOneHour;
            int hoursADay = hoursNeeded / days;

            Console.WriteLine(hoursADay);
        }
    }
}
