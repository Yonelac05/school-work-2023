using System;

namespace TUT2_Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            displayThreeTimesTheNumber(number);
            displayNumberPlusTen(number);
            displayNumberSquared(number);

            Console.ReadKey();
        }

        //Theses are procedures because they don't return a value
        private static void displayThreeTimesTheNumber(double number)
        {
            Console.WriteLine($"Three times {number} is {number * 3}");
        }

        private static void displayNumberPlusTen(double number)
        {
            Console.WriteLine($"{number} plus ten is {number + 10}");
        }

        private static void displayNumberSquared(double number)
        {
            Console.WriteLine($"{number} squared is {number * number}");
        }

    }
}
