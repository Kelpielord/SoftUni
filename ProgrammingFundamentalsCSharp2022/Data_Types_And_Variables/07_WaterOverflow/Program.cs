using System;

namespace _07_WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int waterTankCapacity = 255;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                result += liters;
                if (result > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    result -= liters;
                    continue;
                }
            }
            Console.WriteLine(result);
        }
    }
}
