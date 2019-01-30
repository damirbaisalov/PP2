using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); //Creating string variable for length of an array and inputting data using 'ReadLine'
            int n = int.Parse(s); //Converting string to integer
            int[] array = new int[n]; //Announcing integer array with the length - n

            int d = 2 * n; //Multyplying n to 2 in order to create the length of a second array

            int[] doublearray = new int[d]; //Announcing second integer array with length - d
            string[] arr = Console.ReadLine().Split(' '); //Inputing numbers, creating string array and separating number by using 'Split'

            for (int i = 0; i < n; i++) //Using loop 'for' in order to fill the array
            {
                int x = int.Parse(arr[i]); //Converting string to integer
                array[i] = x; //Adding elements to array
            }

            int q = 0; //Announcing new variable  'q'
            for (int i = 0; i < d; i += 2) //Making loop 'for' to fill a second array with duplicate elements
            {
                doublearray[i] = array[q]; //Adding elemnt of first array to a second array
                doublearray[i + 1] = array[q]; //Duplicating the number 
                q = q + 1; // Increasing the counter by 1
            }

            for (int j = 0; j < d; j++) // Using loop 'for' to show the elements of second array in console
            {
                Console.Write(doublearray[j]); //Showing the element of array by using 'Write'

            }
            Console.ReadKey(); //Closing the console by pressing any key with using the function 'ReadKey'
        }
    }
}
