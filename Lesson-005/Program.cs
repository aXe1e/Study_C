using System;
using System.IO;

namespace Lesson_005
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            /*
            Console.WriteLine("Введите произвольный набор данных:");
            string s = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename, s);
            */
            
            /*
            //2.Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            File.AppendAllText("startup.txt", $"{DateTime.Now:T}\n");
            */

            /*
            //3.Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.
            string filename = "Numbers.bin";
            byte[] bForFile = new byte[5];
            
            Console.WriteLine("Введите с клавиатуры произвольный набор чисел(0...255).");
            for (int i = 0; i < bForFile.Length; i++)
            {
                bForFile[i] = Convert.ToByte(Console.ReadLine());
            }
            File.WriteAllBytes(filename, bForFile);

            byte[] bForFile1 = File.ReadAllBytes(filename);

            for (int i = 0; i < bForFile1.Length; i++)
            {
                Console.WriteLine($"{bForFile1[i]}");
            }
            Console.ReadKey();
            */
        }
    }
}
