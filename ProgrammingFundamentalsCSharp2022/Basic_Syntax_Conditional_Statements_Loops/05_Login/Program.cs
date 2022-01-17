using System;

namespace _05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = userName;
            char[] passConvert = userName.ToCharArray();
            Array.Reverse(passConvert);
            string currentPassword = new string(passConvert);
            int attempts = 0;

            while (true)
            {
                string userInputPass = Console.ReadLine();
                attempts++;
                if (userInputPass.CompareTo(currentPassword) == 0)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else if (attempts == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");

                }
            }
        }
    }
}
