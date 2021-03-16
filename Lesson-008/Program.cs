using System;
using System.Diagnostics;
using SayHelloLib;

namespace Lesson_008
{
    class Proc
    {
        static Process[] process { get; set; }

        static void GetProcessList()
        {
            process = Process.GetProcesses();
        }

        static void PrintProcessList()
        {
            Console.Clear();
            string Header = "PID      Имя процесса                   \n-------- -------------------------------";
            Console.WriteLine($"{Header}");
            
            foreach (Process p in process)
            {
                Console.WriteLine($"{p.Id}\t {p.ProcessName}");
            }
        }
                
        static void KillProcess(string pname)
        {
            int pid = -1;
            try
            {
                pid = Int32.Parse(pname);
            }
            catch (Exception)
            {
                //продолжаем работать
            }
            
            foreach (Process p in process)
            {
                if (p.ProcessName == pname || p.Id == pid)
                {
                    p.Kill();
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            /*
            //1. Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
            //Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
            string pname = String.Empty;
            GetProcessList();
            PrintProcessList();
            Console.WriteLine("Введите ID процесса или наименование для его завершения. Для выхода введите -1.");
            do
            {
                pname = Console.ReadLine();
                if (pname != "-1")
                {
                    KillProcess(pname);
                }                             
            } while (pname != "-1");
            */

            /*
            //2. Создать библиотеку с методом привествия, создать второе консольное приложение, которое выводит это приветствие.
            Class1.SayHello();
            */
        }
    }
}
