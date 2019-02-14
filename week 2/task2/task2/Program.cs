using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime(int x) //Funtion to check for Prime
            {
                int crt = 0;
                for (int i = 1; i <= x; i++)
                {
                    if (x%i==0)
                    {
                        crt++;
                    }
                }
                if (crt == 2) return true; // Return true if there are 2 division of number
                return false;
            }
            StreamReader sr = new StreamReader("input.txt"); //File to read data
            StreamWriter sw = new StreamWriter("output.txt"); //File to save the outputs 
            string[] arr = sr.ReadLine().Split(' '); //Creating string array 
            for (int i = 0; i < arr.Length; i++)
            {
                int x = int.Parse(arr[i]);
                if (isPrime(x) == true)
                {         
                    sw.Write(x + " "); //Saving only prime numbers in streamwriter file
                }
            }
            sr.Close(); //Closing the streamreader
            sw.Close(); //Closing the streamwriter
            
        }
    }
}
