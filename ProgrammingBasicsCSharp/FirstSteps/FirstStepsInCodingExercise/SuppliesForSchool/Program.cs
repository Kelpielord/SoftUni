using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {

            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaningAgent = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double packOfPens = 5.80;
            double packOfMarkers = 7.20;
            double litreOfcleaningAgent = 1.20;

            double pensSum = pens * packOfPens;
            double markersSum = markers * packOfMarkers;
            double cleaningAgentSum = cleaningAgent * litreOfcleaningAgent;
            double sumAll = pensSum + markersSum + cleaningAgentSum; 
            double finalDiscount = sumAll * discount / 100; 
            double sumWithDiscount = sumAll - finalDiscount;

            Console.WriteLine(sumWithDiscount);



        }
    }
}
