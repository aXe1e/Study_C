using System;

namespace Lesson_003
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.a Написать программу, выводящую элементы двумерного массива по диагонали.
            /*
            int maxChar = 0;
            int[,] a2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14 ,15 } };
            for (int i = 0; i < a2.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    Console.WriteLine($"{a2[i, j]}");
                    maxChar++;
                    for (int k = 0; k < maxChar; k++)
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.ReadKey();
            */


            //1.b Написать программу, выводящую элементы двумерного массива по диагонали.
            /*
            int[,] a2 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            for (int i = 0; i < a2.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine($"{a2[i, j]}");
                    }                    
                }
            }
            Console.ReadKey();
            */

            //2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, 
            //второй — номер телефона/email.
            /*
            string[,] arr = { { "Алексеев Алексей Алексеевич", "+7-922-44-44-44" }, 
                              { "Петров Петр Петрович", "+7-922-55-55-55" },
                              { "Дмитриев Дмитрий Дмитриевич", "ddd02@mail.ru" },
                              { "Иванов Иван Иванович", "iii01@yandex.ru" },
                              { "Сидоров Сидр Сидорович", "+7-922-11-11-11" } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"{arr[i, 0]}\t{arr[i, 1]}");                   
            }
            Console.ReadKey();
            */

            //3.Написать программу, выводящую введённую пользователем строку в обратном порядке(olleH вместо Hello).
            /*
            string str = "";
            Console.Write("Введите любую строку: ");
            str = Console.ReadLine();
            Console.Write("В обратном порядке: ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write($"{str[i]}");
            }
            Console.ReadKey();
            */

            //*«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
            /*
            char[,] field = { { 'O', 'X', 'X', 'X', 'X', 'O', 'X', 'X', 'X', 'O' },
                              { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                              { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                              { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                              { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                              { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                              { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                              { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                              { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                              { 'O', 'X', 'X', 'O', 'X', 'O', 'X', 'X', 'X', 'O' } };
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write($"{field[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            //4.доп.ДЗ Написать программу, которой на вход подается одномерный массив и число n(может быть положительным, или отрицательным), 
            //  при этом программа должена сместить все элементы массива на n позиций.Для усложнения задачи нельзя пользоваться вспомогательными массивами.
            /*
            string str = "";
            int shift = 0;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            
            Console.Write("Введите величину смещения: ");
            shift = int.Parse(Console.ReadLine());

            char[] arrChars = str.ToCharArray();
            
            if (shift >= 0)
            {
                for (int i = arrChars.Length - 1; i >= 0; i--)
                {
                    if (i - shift < 0)
                    {
                        arrChars[i] = ' ';
                    }
                    else
                    {
                        arrChars[i] = arrChars[i - shift];
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrChars.Length; i++)
                {
                    if (i - shift > arrChars.Length - 1)
                    {
                        arrChars[i] = ' ';
                    }
                    else
                    {
                        arrChars[i] = arrChars[i - shift];
                    }
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write($"{arrChars[i]}");
            }
            Console.ReadKey();
            */
        }
    }
}
