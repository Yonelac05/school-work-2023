using DataLayer;
using System;
using System.Collections.Generic;

namespace LogicLayer
{
    public class LogicLayerClass
    {
        DataLayerClass dataLayer = new DataLayerClass();

        //two methods to save and read file
        //other to determine age.
        public int GetAge( string idNo)
        {
            int birthYear=0;
            int century;
            int age;
            int fullYear;
            
            int year;
         
            
            if (birthYear < 22)
            {
                century = 2000;
            }
            else
            {
                century = 1900;
            }

            //the first two numbers represent the year
             year =int.Parse( $"{idNo.Substring(0, 2)}");

             fullYear = birthYear - century;

            age= DateTime.Now.Year - fullYear;
            
            return age;
           
            
        }
        public void SaveToFile(string name, int age)
        {
            dataLayer.WriteToTxt($"{name},{age}");
        }
        //method to read from the file
        public string[] ReadFromFile()
        {
            List<string> readDetails = new List<string>();
            foreach (string line in readDetails)
            {
                List<string> readline = dataLayer.ReadTxt();
                readDetails.Add(line);
            }
            return readDetails.ToArray();
        }
    }
}

