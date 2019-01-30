using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); //Creating new string variable for the length of array 
            int n = int.Parse(s); //Converting the variable 's' from string to integer
            string e = "[*]"; //Creating the variable 'e' - [*] as a string
            string[,] arr = new string[n,n]; //Announcing new two-dimensional string array
            for (int i = 0; i < n; i++) //Using loop 'for' to create the array by row from i to n
            {
                for (int j = 0; j <= i; j++) // Using loop 'for' to create the array by column from j to i
                {
                    arr[i, j] = e; //Inserting the variable 'e' as a element of array
                }
            }

            for (int i = 0; i < n; i++) //Using loop 'for' to create the array by row from i to n
            {
                for (int j = 0; j<n ; j++) // Using loop 'for' to create the array by column from j to i
                {
                    Console.Write(arr[i, j]); //Showing the elemnts of array using 'Write'
                }
                Console.WriteLine(); //Making the array 2-dimensional by using 'WriteLine'
            }

            Console.ReadKey(); //Closing the console by pressing any key with using the function 'ReadKey'
        }
    }
}
