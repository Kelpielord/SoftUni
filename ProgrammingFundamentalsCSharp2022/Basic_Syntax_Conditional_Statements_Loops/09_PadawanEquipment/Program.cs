using System;

namespace _09_PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            float lightsabersPrice = float.Parse(Console.ReadLine());
            float robesPrice = float.Parse(Console.ReadLine());
            float beltsPrice = float.Parse(Console.ReadLine());
            double bonusLightsabers = Math.Ceiling(studentCount + (studentCount * 0.10));
            var result = 0.0;
            var freeBelts = 0.0;
            

            for (int i = 1; i <= studentCount; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }

            }

            result = lightsabersPrice * bonusLightsabers + robesPrice * studentCount + beltsPrice * (studentCount - freeBelts);
            if (budget >= result)
            {
                Console.WriteLine($"The money is enough - it would cost {result:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(result - budget):F2}lv more.");
            }
        }
    }
}
