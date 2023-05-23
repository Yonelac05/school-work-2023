using System;
using System.Collections.Generic;

namespace BusinessLayer
{
	public class BusinesLayer
	{
		DataLayer.DataLayer data = new DataLayer.DataLayer();

		List<string> dataToPresent = new List<string>();
		public string getEmail(string name, string surname)
		{
			name = name.ToLower();
			surname = surname.ToLower();

			string email = $"{name.Substring(0, 1)}{surname}.uj.ac.za";
			return email;
		}
		public int getAge(string idNo)
		{
			int birthYear = int.Parse(idNo.Substring(0, 2));
			int century; // assume 1900 for birth years from 22 and above
			if (birthYear < 22)
			{
				century = 2000;
			}
			else
			{
				century = 1900;
			}

			int fullYear = century + birthYear;
			int age = DateTime.Now.Year - fullYear;
			return age;
		}

		public void saveToFile(string name, string surname, string email, int age)
		{
			string record = $"{name} {surname} {email} {age}";
			data.SaveData(record);
		}

		public List<string> readFromFile()
		{
			string rawData = data.ReadData();
			string[] result = rawData.Split('\n');
			foreach (string record in result)
			{
				dataToPresent.Add(record);
            }
            return dataToPresent;

		}
	}
}
