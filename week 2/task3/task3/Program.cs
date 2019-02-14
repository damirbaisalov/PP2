using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace task3
{
    class Program
    {

        static void PrintSpaces(int level) //Level for tree
        {
            for (int i= 0;i < level;i++)
            {
                Console.Write(" ");
            }
        }

        static void Tree(DirectoryInfo directory, int level)
        {
            
            FileInfo[] files = directory.GetFiles(); //Getting  array of files
            DirectoryInfo[] directories = directory.GetDirectories(); //Getting array of directories

            foreach (FileInfo file in files) //Every name of file outputs in console with level
            {
                PrintSpaces(level);
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo d in directories) //Every name of directory outputs in console with level
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                Tree(d, level + 1); //Recursion to get to the next level
            }
        }
            static void Main(string[] args)
        { 
            string path = @"C:\Users\Lenovo\Desktop\ExDir"; //Setting the following directory
            DirectoryInfo d = new DirectoryInfo(path);
            Tree(d,0); //Calling the function to be performed
            Console.ReadKey();
        }
       
    }
}
