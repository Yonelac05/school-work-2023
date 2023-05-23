using System;

namespace TUT2_Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());

            computePercentage(num1, num2);
            computePercentage(num2, num1);

            Console.ReadKey();
        }

        static void computePercentage(double num1, double num2)
        {
            double percentage = num1 / num2 * 100;
            Console.WriteLine($"{num1:F1} is {percentage:F1}% of {num2:F1}");
        }
    }
}
