using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Lesson_6_App_1
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
        static StringBuilder catalog = new StringBuilder($"Дерево файлов и вложенных папок начиная с каталога:\n");

        static void Main(string[] args)
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); // консоль на весь экран

            string filename = "catalog.txt";
            string path = @"C:\aaa";
            catalog.Append(path + Environment.NewLine);
            DirectoryInfo dir = new DirectoryInfo(path);
            GetDirectoriesAndFilesList(dir);
            File.WriteAllText(filename, catalog.ToString());
            Console.WriteLine(catalog);

            Console.ReadLine();
        }
        static void GetDirectoriesAndFilesList(DirectoryInfo path, string prefix = "")
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            files = path.GetFiles("*.*"); // перебираем файлы
            if (files != null)
            {
                Console.ForegroundColor = ConsoleColor.White;
                foreach (FileInfo file in files.Take(files.Length - 1))
                {
                    catalog.Append($"{prefix}├── {file.Name}\n");
                }
                if (files.LastOrDefault() != null)
                {
                    catalog.Append($"{prefix}└── {files.LastOrDefault().Name}\n");
                }
            }

            subDirs = path.GetDirectories(); // перебираем папки
            if (subDirs != null)
            {
                foreach (DirectoryInfo directory in subDirs.Take(subDirs.Length - 1))
                {
                    catalog.Append($"{prefix}├── {directory.Name}\n");
                    GetDirectoriesAndFilesList(directory, prefix + "│   ");
                }
                if (subDirs.LastOrDefault() != null)
                {
                    catalog.Append($"{prefix}└── {subDirs.LastOrDefault().Name}\n");
                    GetDirectoriesAndFilesList(subDirs.LastOrDefault(), prefix + "    ");
                }
            }
        }
    }
}