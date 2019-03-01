using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class FarManager
    {
        public int cursor;
        public int sz;
        private string e;
        bool ok;
        public bool insert = false;

        public FarManager()
        {
            cursor = 0;
            ok = true;
        }

        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }

        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }


        public void Color(FileSystemInfo fs, int index)
        {
            if (index == cursor)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }

        public void Show(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] fileSystemInfos = directory.GetFileSystemInfos();
            sz = fileSystemInfos.Length;

            int index = 0;
            int num = 1;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(path);

            foreach (FileSystemInfo fs in fileSystemInfos)
            {
                if (ok && fs.Name.StartsWith("."))
                {
                    sz--;
                    continue;
                }

                Color(fs, index);
                Console.Write(num + ". ");
                num++;

                Console.WriteLine(fs.Name);

                index++;
            }
            if (insert == true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(); Console.Write("Vvdeite nazvanie: ");
                string znak = @"\"; e = znak + Console.ReadLine();
            }


        }

        public void Start(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            FileSystemInfo fs = null;
            while (consoleKey.Key != ConsoleKey.Escape)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                consoleKey = Console.ReadKey();

                if (consoleKey.Key == ConsoleKey.Delete)
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
                        try
                        {
                            DirectoryInfo dirInfo = new DirectoryInfo(fs.FullName);
                            dirInfo.Delete(true);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                        File.Delete(fs.FullName);
                }

                if (consoleKey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    directory = directory.Parent;
                    path = directory.FullName;

                }
                if (consoleKey.Key == ConsoleKey.UpArrow)
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow)
                    ok = false;
                if (consoleKey.Key == ConsoleKey.LeftArrow)
                    ok = true;
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    insert = false;
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

                    else
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        string[] s = File.ReadAllLines(fs.FullName); //в файле несколько строк, одна строка - один элемент массива
                        Console.WriteLine(string.Join("\n", s));
                        Console.ReadLine();

                    }
                }


                if (consoleKey.Key == ConsoleKey.Insert)
                {
                    insert = true;
                    int g = 0;
                    for (int i = 0; i < directory.GetFileSystemInfos().Length; i++)
                    {
                        if (ok && directory.GetFileSystemInfos()[i].Name.StartsWith("."))
                            continue;
                        if (cursor == g)
                        {
                            fs = directory.GetFileSystemInfos()[i];
                            break;
                        }
                        g++;

                    }
                    if (fs.GetType() == typeof(DirectoryInfo))
                    {

                        directory = new DirectoryInfo(path);
                        string source = directory.Parent.FullName;
                        string newPath = source + e;
                        if (directory.Exists && Directory.Exists(newPath) == false)
                        {
                            directory.MoveTo(newPath);
                        }
                    } /*else
                        {
                        
                        path = fs.FullName;
                        string newFile = path + e;
                        File.Move(fs.FullName, newFile);
                        } */


                }


            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            FarManager farManager = new FarManager();
            farManager.Start(@"C:\Users\Lenovo\Desktop\PP2");
        }
    }
}