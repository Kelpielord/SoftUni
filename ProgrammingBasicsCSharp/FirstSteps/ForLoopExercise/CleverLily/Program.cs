using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double money = 0;
            double leftoverMoney = 0;
            double moneyForPrime = 10;
            for (int i = 0; i < age; i++)
            {
                if (i % 2 == 0 )
                {
                    money += p;
                }
                else
                {
                    money += moneyForPrime - 1;
                    moneyForPrime += 10;
                }
            }

            if (money >= washingMachine)
            {
                leftoverMoney = money - washingMachine;
                Console.WriteLine($"Yes! {leftoverMoney:f2}");
            }
            else
            {
                leftoverMoney = washingMachine - money;
                Console.WriteLine($"No! {leftoverMoney:f2}");
            }

        }
    }
}