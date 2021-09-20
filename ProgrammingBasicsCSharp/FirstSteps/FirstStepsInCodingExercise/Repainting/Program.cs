using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int naelon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double naelonCost = 1.50;
            double paintCost = 14.50;
            double diluentCost = 5.00;
            double bagCost = 0.40;

            double naelonCalc = (naelon + 2) * naelonCost;
            double paintPlusTenPercent = paint + paint * (10 / 100.0);
            double paintCalc = paintPlusTenPercent * paintCost;
            double diluentCalc = diluent * diluentCost;
            double cost = naelonCalc + paintCalc + diluentCalc + bagCost;
            double professionalCost = cost * (30 / 100.0) * hours;
            double finalCost = cost + professionalCost;
            Console.WriteLine(finalCost);
        }
    }
}
