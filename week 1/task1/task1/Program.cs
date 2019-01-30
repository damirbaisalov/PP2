using System;
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
             bool Prime(int x) // Dedicated function to find prime numbers
            {
                int crt = 0; // Counter of number dividers
                for (int i = 1; i <= x; i++) // Using Loop 'for' to identify prime numbers
                {
                    if((x % i) == 0) crt++;//Special condition to count dividers of the number
                }  
                if (crt==2) return true; // if the number has 2 dividers then the number prime and function return true
                return false; // if the number is not prime then it return false
            }

            string s = Console.ReadLine(); // We can't insert integers , so we have to read this variable as string
            int n = int.Parse(s); // Converting string to integer
            int[] array = new int[n];// Creating a one dimension array with the lenght - n
            int cnt = 0; // Creating new variable as a counter of prime numbers
            string[] arr = Console.ReadLine().Split(' '); // Creating string array and inserting the numbers using the function 'Split' in order to separate the numbers
            for (int i = 0; i < n; i++) // Loop to input elements from string array to integer array
            {
                int x = int.Parse(arr[i]); // Converting from string to integer
                array[i] = x;// Adding every element to integer array
               
            }
            
            for (int i = 0; i < n; i++) // Using a loop 'for' to find the amount of prime numbers in array
            {
                if (Prime(array[i])) cnt++;// Using the function 'Prime' to count quantity of prime numbers
              
            }
            Console.WriteLine(cnt);//Showing the amount of prime numbers in console

            for (int i = 0; i < n; i++) // Using a loop 'for' to output prime numbers in array
            {

                if (Prime(array[i])) // Condition 'if the element is prime', if this condition performs then it shows the certain number in console
                        Console.Write(array[i] + " " ); // Showing the elemnt of array in console

            }

            Console.ReadKey();// Closing the console by pressing any key with using the function 'ReadKey'
        }
       
    }
}
