using System;
using System.Linq;

namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfWagons = int.Parse(Console.ReadLine());
            int[] passengers = new int[numOfWagons];

            for (int i = 0; i < passengers.Length; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ", passengers));
            Console.WriteLine(passengers.Sum());
        }
    }
}
