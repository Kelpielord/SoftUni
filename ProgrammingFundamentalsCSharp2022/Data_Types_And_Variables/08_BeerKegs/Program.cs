using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> kegs = new Dictionary<string, double>();
            double result = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                result = Math.PI * Math.Pow(radius, 2) * height;
                kegs.Add(model, result);

            }
            kegs = kegs.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine(kegs.Last().Key);
            
        }
    }
}
