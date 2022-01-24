using System;

namespace _10_RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount= 0;
            var result = 0.0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }

                if (i % 3 == 0)
                {
                    mouseCount++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }
                }
            }

            result = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;
            Console.WriteLine($"Rage expenses: {result:F2} lv.");

        }
    }
}
