using System.Collections.Generic;
using System.IO;

namespace Question2
{
	internal class StudentRecords
	{
		// The filepath where the data will be stored
		private readonly string filepath = "exam.txt";

		// The list to hold the student records
		private readonly List<Student> marksRecords = new List<Student>();

		// Default constructor
		public StudentRecords() { }

		// Method to add a new student record to the list
		public void AddNewStudent(Student student)
		{
			marksRecords.Add(student);
		}

		// Method to get the list of student records
		public List<Student> GetRecords()
		{
			return marksRecords;
		}

		// Method to save the student records to the file
		public void SaveToFile()
		{
			// Open a StreamWriter and write each student record to the file
			using (StreamWriter writer = new StreamWriter(filepath, true))
			{
				foreach (Student student in marksRecords)
				{
					writer.WriteLine($"{student.studentNumber};{student.testMarks};{student.assignmentMarks};{student.examMarks};{student.finalMarks}");
				}
			}
		}

		// Method to load the student records from the file
		public void LoadFromFile()
		{
			// Clear the list before loading the data
			marksRecords.Clear();

			// Open a StreamReader and read each line from the file
			using (StreamReader reader = new StreamReader(filepath))
			{
				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();

					// Split the line by semicolon to get the individual data points
					string[] data = line.Split(';');

					// Create a new student object and populate it with the data from the file
					Student student = new Student
					{
						studentNumber = data[0],
						testMarks = double.Parse(data[1]),
						assignmentMarks = double.Parse(data[2]),
						examMarks = double.Parse(data[3]),
						finalMarks = double.Parse(data[4])
					};

					// Add the student record to the list
					marksRecords.Add(student);
				}
			}
		}
	}
}
