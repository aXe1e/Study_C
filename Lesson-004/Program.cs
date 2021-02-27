using System;

namespace Lesson_004
{
    class Program
    {
        enum Seasons
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            /*
            //1. Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и 
            //возвращающий объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
            Console.WriteLine(GetFullName("Иванов", "Иван", "Иванович"));
            Console.WriteLine(GetFullName("Петров", "Петр", "Петрович"));
            Console.WriteLine(GetFullName("Алексеев", "Алексей", "Иванович"));
            Console.ReadKey();
            */

            /*
            //2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
            Console.Write("Введите строку чисел разделенную пробелом: ");
            string num = Console.ReadLine();
            Console.Write($"Сумма введенных чисел = { GetSum(num)}");
            Console.ReadKey();
            */

            /*
            //3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn.
            //Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень). 
            //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».

            Console.Write("Введите порядковый номер месяца (1 - 12): ");
            int NumMonth = Convert.ToInt32(Console.ReadLine());
            if (NumMonth >= 1 && NumMonth <= 12)
            {
                Console.Write($"Время года: {GetSeasonsRU(GetSeasons(NumMonth))}");
            } else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            Console.ReadKey();
            */

            /*
            //4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.
            Console.Write("Введите номер элемента числа Фиббоначи: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Число Фиббоначи для элемент n={n} равно: {NumFibbonachi(n)}");
            Console.ReadKey();
            */
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }
        
        static int GetSum(string num)
        {
            int i = 0;
            string[] StrNum = num.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in StrNum)
            {
                i+=Convert.ToInt32(s);
            }
            return i;
        }

        static Seasons GetSeasons(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return (Seasons)1;
                case 3:
                case 4:
                case 5:
                    return (Seasons)2;
                case 6:
                case 7:
                case 8:
                    return (Seasons)3;
                default:
                    return (Seasons)4;
            }
        }
        static string GetSeasonsRU(Seasons s)
        {
            switch (s)
            {
                case Seasons.Winter:
                    return "Зима";
                case Seasons.Spring:
                    return "Весна";
                case Seasons.Summer:
                    return "Лето";
               default:
                    return "Осень";
            }
        }
        static int NumFibbonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            } else if (n == 1)
            {
                return 1;
            } else if (n < 0)
            {
                return NumFibbonachi(n + 2) - NumFibbonachi(n + 1);
            } else
            {
                return NumFibbonachi(n - 1) + NumFibbonachi(n - 2);
            }
        }
    }
}
