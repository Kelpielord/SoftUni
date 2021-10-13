using System;

namespace Numbers1_NWithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nums; i+= 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}