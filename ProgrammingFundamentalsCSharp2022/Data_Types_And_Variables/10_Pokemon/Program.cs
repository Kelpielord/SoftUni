using System;

namespace _10_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int oldPokePower = pokePowerN;
            int pokeDistanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int targetsPoked = 0;

            while (pokePowerN >= pokeDistanceM)
            {
                pokePowerN -= pokeDistanceM;
                targetsPoked++;
                if (pokePowerN == oldPokePower / 2 && pokePowerN >= exhaustionFactorY && exhaustionFactorY != 0)
                {
                    pokePowerN /= exhaustionFactorY;
                }
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(targetsPoked);
        }
    }
}
