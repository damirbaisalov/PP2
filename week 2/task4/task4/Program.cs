using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo\Desktop\path\example1.txt"); //Creating .txt file 
            sw.Write(3242);
            sw.Close();
            string path =( @"C:\Users\Lenovo\Desktop\path\example1.txt"); //Creating directory1
            

            string path1 = (@"C:\Users\Lenovo\Desktop\path1\example1.txt"); //Creating directory2
            File.Copy(path,path1); //Copying file from directory1 to directory2
            File.Delete(path); //Deleting the original file in directory1
        
            sw.Close(); 
        }
    }
}
