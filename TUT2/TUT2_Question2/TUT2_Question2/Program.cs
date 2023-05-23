using System;

namespace TUT2_Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get department code  
            Console.Write("Enter department code (A, B or other): ");
            string depCode = Console.ReadLine();
            //Get annual salary
            Console.Write("Enter annual salary: ");
            float annualSalary = float.Parse(Console.ReadLine());

            // Initialize variables
            float increase;
            string depName;


            if (depCode == "A")
            {
                increase = 5.2f;
                depName = "Department A";
            }
            else
            {
                if (depCode == "B")
                {
                    increase = 4.8f;
                    depName = "Department B";
                }
                else
                {
                    increase = 4.3f;
                    depName = "Other Department";
                }
            }

            // Calculate increased monthly salary and display result
            float oldMonthSalary = annualSalary / 12.0f;
            // oldSalary + (oldSalary * (increase /100))
            float increasedMonthlySalary = oldMonthSalary * (1.0f + (increase / 100.0f));
            Console.WriteLine("Department: " + depName);
            Console.WriteLine("Anual salary: " + annualSalary);
            Console.WriteLine("New monthy salary: " + increasedMonthlySalary);

        }

    }
}
