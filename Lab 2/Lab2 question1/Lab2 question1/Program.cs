using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2_question1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//reading file 
			string filepath = "dataset.txt";

			//storing data in data structure /to hold the data from txt file.
			List<string> dataset = new List<string>();

			using (var reader = new StreamReader(filepath))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					dataset.Add(line);

				}

			}

			for (int i = 1; i < 5; i++)
			{
				Console.WriteLine("************************************************************");
				Console.WriteLine("*                  BIG DATA APPLICTAION                    *");
				Console.WriteLine("************************************************************");
				Console.WriteLine("Select an option from the menu below: \n" +
					"1:Display all data from the dataset \n " +
					"2:Display all the data based on the given year(2001-2021" +
					") \n" +
					"3:Display all the data based on the level(1-4) " + "\n " +
					"0:Exit........");

				int option = int.Parse(Console.ReadLine());

				//conditional statements based on option selected
				//option 1 must display all the data within the textfile



				if (option == 1)
				{
					foreach (var item in dataset)
					{
						Console.WriteLine(item);
					}
				}
				//option two displays the data based on the year.(2001-2021)
				else if (option == 2)
				{
					Console.WriteLine("Enter a year:");
					int year = int.Parse(Console.ReadLine());

					foreach (var line in dataset)
					{

						string[] years = line.Split(',');
						if (int.Parse(years[0]) == year)
						{

							Console.WriteLine(line);
						}
					}

				}
				//option three displays the data based on level(1-4)
				else if (option == 3)
				{
					Console.WriteLine("Enter level:");
					int level = int.Parse(Console.ReadLine());

					foreach (var line in dataset)
					{

						string[] levels = line.Split(',');
						if (int.Parse(levels[1].Split(' ')[1]) == level)
						{

							Console.WriteLine(line);
						}
					}
				}

				//option zero must terminate the program
				else if (option == 0)
				{
					Console.WriteLine("Program terminated.Thanks Goodbye");
					break;
				}
			}
			Console.ReadKey();

		}

	}

}
