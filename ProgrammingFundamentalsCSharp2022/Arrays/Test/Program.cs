using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            int battleCounter = 0;
            double sum = 0;


            for (int i = 0; i < countOfBattles; i++)
            {
                double experiencePerBattle = double.Parse(Console.ReadLine());
                battleCounter++;
                if (battleCounter % 3 == 0)
                {
                    sum += experiencePerBattle + (experiencePerBattle * 15 / 100);
                }
                else if (battleCounter % 5 == 0)
                {
                    sum += experiencePerBattle - (experiencePerBattle * 10 / 100);
                }
                else if (battleCounter % 15 == 0)
                {
                    sum += experiencePerBattle + (experiencePerBattle * 5 / 100);
                }
                else
                {
                    sum += experiencePerBattle;
                }

                if (sum >= neededExperience)
                {
                    break;
                }
            }
            if (sum >= neededExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battleCounter} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {Math.Abs(neededExperience - sum):f2} more needed.");
            }
        }
    }
}
