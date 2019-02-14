using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student //Creating new class 'Student'
    {
        public string name; //1st parameter - Name of student
        public string id; //2nd parameter - id of student
        public int year; //3rd parameter - year of studying

        public Student(string name, string id, int year) //Constructor 'Student' with 2 parameters
        {
            this.name = name; //1st parameter - name
            this.id = id; //2nd parameter - id 
            this.year = year; //3rd parameter - year
        }
        public Student() // Constructor with 0 parameter
        {
            string[] reading = Console.ReadLine().Split(); // Read the values by space 
            while (reading.Length != 3)
            { // Read untill 3 values will not be read
                Console.WriteLine("Wrong! Please input in correct form: Name ID Year");
                reading = Console.ReadLine().Split(); // Обновляем вводные данные
            }
            
            name = reading[0]; //Value of first parameter
            id = reading[1]; // Value of 2nd parameter
            year = Convert.ToInt32(reading[2]); // Value of 3d parameter
        }


        public void Print() //Function 'Print' to show the data in console
        {
            Console.WriteLine(name + " " + id + " " + (year+1)); //Showing name,id,year in console
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student("Damir", "18BD11043", 2018); //Creating new exemplar of class 'Student'

            st1.Print();
            st2.Print();
            Console.ReadKey(); //Using function 'ReadKey' to close the console by pressing the any key
        }
    }
}