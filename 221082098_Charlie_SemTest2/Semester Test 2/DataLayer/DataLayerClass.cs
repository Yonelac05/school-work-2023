using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DataLayer
{
    public class DataLayerClass
    {
        string filepath = "People.txt";
        //method to read the file.

        List<string> data = new List<string>();
       
        public List<string> ReadTxt()
        {
            using(StreamReader sr= new StreamReader(filepath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    data.Add(line);
                }
               return data;
            }
        }

        //method to write to the text file
        public void WriteToTxt(string details)
        {
            using(StreamWriter sw =new StreamWriter(filepath))
            {
               
                File.AppendAllText(filepath, details);
            }
        }
       
    }
}
