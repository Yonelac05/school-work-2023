using System;

namespace TUT2_Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numStudents = 10;
            string[] names = new string[numStudents];
            int[] scores = new int[numStudents];

            // Read in test scores and student names
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter {i + 1} student's name (or -1 to exit): ");
                names[i] = Console.ReadLine();

                Console.Write("Enter test mark (as integer percentage): ");
                int mark = int.Parse(Console.ReadLine());

                // Check if wanted to terminate
                if (mark < 0)
                {
                    break;
                }

                // Check if mark doesn't exist
                if (Array.IndexOf(scores, mark) != -1)
                {
                    Console.WriteLine("Mark is already in the array. Try again!");
                    i--;
                    continue;
                }

                scores[i] = mark;
            }

            // Determine highest and lowest scores and their corresponding names
            int highestScore = 0, lowestScore = 100;
            string highestScorerName = "", lowestScorerName = "";
            for (int i = 0; i < numStudents; i++)
            {
                int score = scores[i];
                string name = names[i];

                if (score == 0)
                {
                    continue;
                }

                if (score > highestScore)
                {
                    highestScore = score;
                    highestScorerName = name;
                }
                if (score < lowestScore)
                {
                    lowestScore = score;
                    lowestScorerName = name;
                }
            }

            // Output highest and lowest scores and their corresponding names
            Console.WriteLine($"The highest mark was {highestScore}% obtained by {highestScorerName}.");
            Console.WriteLine($"The lowest mark was {lowestScore}% obtained by {lowestScorerName}.");
        }
    }
}
