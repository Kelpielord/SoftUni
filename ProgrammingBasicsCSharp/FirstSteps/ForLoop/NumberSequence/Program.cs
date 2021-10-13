using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int MaxNum = int.MinValue;
            int MinNum = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > MaxNum)
                {
                    MaxNum = num;
                }

                if (num < MinNum)
                {
                    MinNum = num;
                }
            }
            Console.WriteLine($"Max number: {MaxNum}");
            Console.WriteLine($"Min number: {MinNum}");
        }
    }
}