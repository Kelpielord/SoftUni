using System;

namespace EvenPowersОf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            for (int i = 0; i <= nums; i+= 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}