using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordInput = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";

            if (passwordInput == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
