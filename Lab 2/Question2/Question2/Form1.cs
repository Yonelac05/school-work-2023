using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Question2
{
	public partial class Form1 : Form
	{
		// Declare private variables to hold student's marks and details
		private double assignmentMarks, testMarks, examMarks, finalMarks;
		private string studentNumber, code;

		// Create an instance of the Student class to hold the student's details
		private readonly Student student = new Student();

		// Create an instance of the StudentRecords class to manage the student records
		private readonly StudentRecords dataRecords = new StudentRecords();

		public Form1()
		{
			InitializeComponent();
		}

		private void computeBTN_Click(object sender, EventArgs e)
		{
			// Get the student's details from the text boxes
			studentNumber = stuNumText.Text;
			assignmentMarks = double.Parse(assgnmentTXT.Text);
			testMarks = double.Parse(testTXT.Text);
			examMarks = double.Parse(examText.Text);

			// Compute the final marks based on the weightage of each assessment
			finalMarks = ((assignmentMarks / 100 * 0.2) + (testMarks / 100 * 0.3) + (examMarks / 100 * 0.5)) * 100;

			// Display the final marks in the text box
			finalTXT.Text = finalMarks.ToString();

			// Save the student's details in the Student instance
			student.testMarks = testMarks;
			student.examMarks = examMarks;
			student.finalMarks = finalMarks;
			student.studentNumber = studentNumber;
			student.assignmentMarks = assignmentMarks;
		}

		private void addBTN_Click(object sender, EventArgs e)
		{
			// Add the student's details to the StudentRecords instance
			dataRecords.AddNewStudent(student);

			// Display a message box to inform the user that the student has been added
			_ = MessageBox.Show("New student added!");
		}

		private void displayBTN_Click(object sender, EventArgs e)
		{
			// Clear the display box to remove any previous records
			displayTXT.Items.Clear();

			// Get the list of student records from the StudentRecords instance
			List<Student> records = dataRecords.GetRecords();

			// Loop through each student record and display their details in the display box
			foreach (Student student in records)
			{
				// Determine whether the student has passed or failed based on their final marks
				code = student.finalMarks >= 59 ? "Pass" : "Fail";

				// Add the student's details to the display box
				_ = displayTXT.Items.Add($"{student.studentNumber}     {student.finalMarks}      {code}");
			}
		}

		private void writeBTN_Click(object sender, EventArgs e)
		{
			// Save the student records to a text file using the StudentRecords instance
			dataRecords.SaveToFile();

			// Display a message box to inform the user that the student records have been saved
			_ = MessageBox.Show("Saved to text file!");
		}

		private void clearBTN_Click(object sender, EventArgs e)
		{
			// Clear all the text boxes and the display box
			stuNumText.Clear();
			assgnmentTXT.Clear();
			examText.Clear();
			finalTXT.Clear();
			testTXT.Clear();
			displayTXT.Items.Clear();
		}

		private void extBTN_Click(object sender, EventArgs e)
		{
			// Exit the application
			Environment.Exit(0);
		}

	}
}
