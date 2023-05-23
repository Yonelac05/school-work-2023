using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT2_Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the number of students and tests
            const  int numberOfStudents = 4;
            const int numberOfTests = 3;

            // Declare an array to hold each student's final mark and a variable to hold the class average
            double[] studentMarks = new double[numberOfStudents];
            double classAverage = 0;

           
            for (int i = 0; i < numberOfStudents; i++)
            {
                //  sum of the student's test scores
                double scoresTotal = 0;

                
                for (int j = 0; j < numberOfTests; j++)
                {
                    // Prompt the user to enter the score for the current test and add it to the sum
                    Console.Write("Enter test score for student {0}, test {1}: ", i + 1, j + 1);
                    double testScore = double.Parse(Console.ReadLine());
                    scoresTotal += testScore;
                }

                // average score for the current student 
                double average = scoresTotal / numberOfTests;

                // Store the average score in the studentMarks array
                studentMarks[i] = average;

               
                Console.WriteLine("Student {0} average score: {1}", i + 1, average);
                Console.WriteLine("");
            }

            // Iterate through the studentMarks array to calculate the class average
            for (int i = 0; i < numberOfStudents; i++)
            {
                // Add each student's average score to the classAverage variable
                classAverage += studentMarks[i];
            }

            classAverage = classAverage / numberOfStudents;

            // Display the class average on the console
            Console.WriteLine("Class average score: {0}", classAverage);
        }
    }
}
