using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            char operat = char.Parse(Console.ReadLine());
            // "+", "-", "*", "/", "%"
            double result = 0;
            bool chekZero = false;

            switch (operat)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    if (num2 == 0)
                    {
                        chekZero = true;
                    }
                    break;
                case '%':
                    result = num1 % num2;
                    if (num2 == 0)
                    {
                        chekZero = true;
                    }
                    break;
                default:
                    break;
            }

            if (operat == '+' || operat == '-' || operat == '*')
            {
                string eventResult = "";
                if (result % 2 == 0)
                {
                    eventResult = "even";
                }
                else
                {
                    eventResult = "odd";
                }
                Console.WriteLine($"{num1} {operat} {num2} = {result} - {eventResult}");
            }
            else if (operat == '/')
            {
                if (!chekZero)
                {
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }
            else if (operat == '%')
            {
                if (!chekZero)
                {
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }
        }
    }
}