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
            StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo\Desktop\path\example1.txt");
            sw.Write(3242);
            sw.Close();
            string path =( @"C:\Users\Lenovo\Desktop\path\example1.txt");
            

            string path1 = (@"C:\Users\Lenovo\Desktop\path1\example1.txt");
            File.Copy(path,path1);
            File.Delete(path);
        
            sw.Close();
        }
    }
}
