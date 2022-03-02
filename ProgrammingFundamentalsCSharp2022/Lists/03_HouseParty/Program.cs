using System;
using System.Collections.Generic;

namespace _03_HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] guestGoing = Console.ReadLine().Split();
                string guest = guestGoing[0];
                string command = string.Join(" ", guestGoing, 1, guestGoing.Length - 1);

                if (command == "is going!")
                {
                    AddToGuestList(guestList, guest);
                }
                else if (command == "is not going!")
                {
                    RemoveFromGuestList(guestList, guest);
                }
            }
            Console.WriteLine(string.Join("\n", guestList));
        }

        private static void AddToGuestList(List<string> guestList, string guest)
        {
            if (guestList == null || guest == null || guest == String.Empty)
            {
                return;
            }
            if (guestList.Contains(guest))
            {
                Console.WriteLine($"{guest} is already in the list!");
                return;
            }

            guestList.Add(guest);
        }

        private static void RemoveFromGuestList(List<string> guestList, string guest)
        {
            if (guestList == null || guest == null || guest == String.Empty)
            {
                return;
            }

            if (!guestList.Contains(guest))
            {
                Console.WriteLine($"{guest} is not in the list! ");
                return;
            }

            guestList.Remove(guest);
        }
    }
}
