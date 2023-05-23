using System.IO;

namespace DataLayer
{
	public class DataLayer
	{
		private static readonly string filePath = "Staff.txt";

		public void SaveData(string data)
		{
			using (StreamWriter writer = new StreamWriter(filePath, true))
			{
				writer.WriteLine(data);
			}
		}
		public string ReadData()
		{
			using (StreamReader reader = new StreamReader(filePath))
			{
				return reader.ReadToEnd();
			}
		}
	}
}
