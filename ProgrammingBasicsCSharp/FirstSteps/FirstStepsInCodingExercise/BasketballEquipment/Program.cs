using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearlyCosts = int.Parse(Console.ReadLine());

            double trainersPrice = yearlyCosts - 0.4 * yearlyCosts;
            double clothesPrice = trainersPrice - 0.2 * trainersPrice;
            double ballPrice = clothesPrice / 4;
            double accPrice = ballPrice / 5;

            double finalPrice = yearlyCosts + trainersPrice + clothesPrice + ballPrice + accPrice;
            Console.WriteLine(finalPrice);
        }
    }
}
