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

        public Student(string name,string id) //Constructor 'Student' with 2 parameters
        {
            this.name = name; //1st parameter - name
            this.id = id; //2nd parameter - id 
           
        }

        public void Print() //Function 'Print' to show the data in console
        {
            Console.WriteLine(name + " " + id + " " + year); //Showing name,id,year in console
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Damir", "18BD11043"); //Creating new exemplar of class 'Student'
            st1.year = 2018; //Setting year of studying - 2018
            while (st1.year<2022) //Using loop 'while' till year=2022
            {
                st1.year++; //Incrementing the year by 1
                st1.Print(); //Using function 'Print' to show data in console
            }
            Console.ReadKey(); //Using function 'ReadKey' to close the console by pressing the any key
        }
    }
}
