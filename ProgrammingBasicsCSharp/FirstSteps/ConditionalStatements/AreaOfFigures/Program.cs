using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a:f3}");
            }

            if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b:f3}");
            }

            if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"{r * r*Math.PI:f3}");
            }

            if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double result = (a * ha) / 2;
                Console.WriteLine($"{result:f3}");
            }
        }
    }
}
