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

            StreamReader sr = new StreamReader("input.txt");
            string s = sr.ReadLine();
            
            char[] arr = s.ToCharArray(); 
             Array.Reverse(arr);
            string b = new string(arr);
            if (s == b) Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadKey();
          
            
        }
    }
}
