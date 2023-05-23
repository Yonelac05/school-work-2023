using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TUT3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		// Init global variables
		string name, surname, email, idNo;
		int age;
		BusinesLayer rules = new BusinesLayer();

		private void createBTN_Click(object sender, EventArgs e)
		{
			// Get data from the form
			name = nameTXT.Text;
			surname = surnameTXT.Text;
			idNo = idNoTXT.Text;

			// Perform business rules
			email = rules.getEmail(name, surname);
			age = rules.getAge(idNo);

			// Display back to the form
			ageLBL.Text = age.ToString();
			emailLBL.Text = email.ToString();
		}

		private void saveBTN_Click(object sender, EventArgs e)
		{
			rules.saveToFile(name, surname, email, age);
			MessageBox.Show("Added to file!");
			clearForm();
		}

		private void readBTN_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();

			List<string> data = rules.readFromFile();
			foreach (var item in data)
			{
				listBox1.Items.Add($"{item}");
			}
		}

		private void exitBTN_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void clearBTN_Click(object sender, EventArgs e)
		{
			clearForm();
		}

		public void clearForm()
		{
			name = surname = email = idNo = "";
			age = 0;
			nameTXT.Clear();
			surnameTXT.Clear();
			ageLBL.Text = string.Empty;
			emailLBL.Text = string.Empty;
			idNoTXT.Clear();
		}


	}
}
