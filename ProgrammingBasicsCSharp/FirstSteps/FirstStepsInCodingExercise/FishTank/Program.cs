using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquariumSize = lenght * width * height;
            double aquariumSizeInLitre = aquariumSize / 1000;
            double aquariumPercent = percent / 100;
            double neededLitre = aquariumSizeInLitre * (1 - aquariumPercent);

            Console.WriteLine(neededLitre);
        }
    }
}
