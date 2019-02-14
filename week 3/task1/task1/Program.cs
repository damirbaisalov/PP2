using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class FarManager //Creating Far manager Class
    {
        public int cursor; //Cursor for moving in console between files and directories
        public int sz; //Size of the directory
        bool ok; //Hide or Show the hidden files and directories
        

        public FarManager()
        {
            cursor = 0;
            ok = true;
        }

        public void Up() //Move up
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }

        public void Down() //Move down
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }

        public void Color(FileSystemInfo fs, int index) //Function to set colors in console
        {
            if (index == cursor) //If the cursor on the particular directory then the color will be red and white
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (fs.GetType() == typeof(DirectoryInfo)) //Generally in console the color of directories
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else //Otherwise if its files the color will be another
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }
        public void Show(string path) //Creating function to show the directories and files
        {
            DirectoryInfo directory = new DirectoryInfo(path); //New directory with path
            FileSystemInfo[] fileSystemInfos = directory.GetFileSystemInfos(); //Array of files and directories
            sz = fileSystemInfos.Length; //the length of fs
            
            int index = 0;
            int num = 1; //Numeration of directories and files
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(path);
            foreach (FileSystemInfo fs in fileSystemInfos) //Loop for files and directories
            {
                if (ok && fs.Name.StartsWith(".")) //Show the hidden files or not
                {
                    sz--;
                    continue;
                }

                Color(fs, index); //Setting colors 
                Console.Write(num + ". "); //Numerating files and directories
                num++;
               
                Console.WriteLine(fs.Name); //Showing the name of files and directories in console with the give "Path"
                index++;
            }
        }
        public void Start(string path) //Function for Keys
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            FileSystemInfo fs = null;
            while (consoleKey.Key != ConsoleKey.Escape) //Escape end the programm
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path); //Showing the names of directories and files always
                consoleKey = Console.ReadKey();
               
                if (consoleKey.Key == ConsoleKey.Backspace) //Helps to go parent directories
                {
                    cursor = 0;
                    directory = directory.Parent;
                    path = directory.FullName;
             
                }
                if (consoleKey.Key == ConsoleKey.UpArrow) //Move up
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow) //Move down
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow) //Shows the hidden files
                    ok = false;
                if (consoleKey.Key == ConsoleKey.LeftArrow) //hides the secret files
                    ok = true;
                if (consoleKey.Key == ConsoleKey.Enter) //Allows to open the directory
                {
                    int k = 0;
                    for (int i = 0; i < directory.GetFileSystemInfos().Length; i++)
                    {
                        if (ok && directory.GetFileSystemInfos()[i].Name.StartsWith("."))
                            continue;
                        if (cursor == k)
                        {
                            fs = directory.GetFileSystemInfos()[i];
                            break;
                        }
                        k++;
                     
                    }
                    if (fs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        directory = new DirectoryInfo(fs.FullName);
                        path = fs.FullName;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {    
            FarManager farManager = new FarManager(); //Creating new exemplar
            farManager.Start(@"C:\Users\Lenovo\Desktop\PP2"); //Giving starting path for far manager
        }
    }
}
