using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;


namespace Semester_Test_2
{
    //Yonela Charlie
    class Program
    {
        static void Main(string[] args)
        {
            LogicLayerClass obj = new LogicLayerClass();
            string name, idNo;
            int age;
            int option;
            Console.WriteLine("Select an option from the menu:1-Enter your details and determine age.2-Save records to a file.3-Read recored from the file.0-To exit");
            option =int.Parse(Console.ReadLine());

                name = Console.ReadLine();
                idNo = Console.ReadLine();

                age= obj.GetAge(idNo);


            if (option == 1)
            {
                Console.WriteLine("Enter name :");

                Console.WriteLine("Enter ID number:");

                Console.WriteLine($"You are {age} years old");
            }
            else if (option == 2)
            {
                obj.SaveToFile(name,age);
                Console.WriteLine($"The selectd option is :{option}");
                Console.WriteLine("Written to file");
            }
            else if(option==3)
            {
                string[] rawData = { };
               
                foreach (var item in rawData )
                {
                    string[] display= obj.ReadFromFile();
                    
                }
                Console.WriteLine($"The selectd option is :{option}");
            }
            else if (option == 0)
            {
                
            }

            Console.ReadKey();

        }

        }
    }
