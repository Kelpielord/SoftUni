using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double grades = double.Parse(Console.ReadLine());

            if (grades >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
