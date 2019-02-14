using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("input.txt"); //Reading from file
            string s = sr.ReadLine();
            
            char[] arr = s.ToCharArray(); //Creating array of char and inuputing string to char
             Array.Reverse(arr); //Reversing the char array
            string b = new string(arr); //Creating new array of string 
            if (s == b) Console.WriteLine("YES"); //If reversed=original then palindrome
            else
                Console.WriteLine("NO"); 
            Console.ReadKey();
          
            
        }
    }
}
