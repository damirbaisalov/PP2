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

        static void PrintSpaces(int level)
        {
            for (int i= 0;i < level;i++)
            {
                Console.Write(" ");
            }
        }

        static void Tree(DirectoryInfo directory, int level)
        {
            
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (FileInfo file in files)
            {
                PrintSpaces(level);
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo d in directories)
            {
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                Tree(d, level + 1);
            }
        }
            static void Main(string[] args)
        {
            string path = @"C:\Users\Lenovo\Desktop\ExDir";
            DirectoryInfo d = new DirectoryInfo(path);
            Tree(d,0);
            Console.ReadKey();
        }
       
    }
}
