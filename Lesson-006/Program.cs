using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


namespace Lesson_006
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.

            string workPath = @"C:\aaa";
            File.WriteAllText(workPath + @"\resultTree.txt", FileTreeRecurse(workPath, 0));
            */

            /*
            //2.Список задач(ToDo - list):
            //    написать приложение для ввода списка задач;
            //    задачу описать классом ToDo с полями Title и IsDone;
            //    на старте, если есть файл tasks.json / xml / bin(выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
            //    если задача выполнена, вывести перед её названием строку «[x]»;
            //    вывести порядковый номер для каждой задачи;
            //    при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
            //    записать актуальный массив задач в файл tasks.json / xml / bin.

            string filename = "tasks.json";
            int numTask = 0;

            ToDo[] FullList = ReadFJ(filename);
            if (FullList != null)
            {
                PrintFullList(FullList);
            }

            Console.WriteLine("Введите номер выполненной задачи из списка или напишите новую:");

            string inputToDo = Console.ReadLine();
            try
            {
                numTask = Convert.ToInt32(inputToDo);
            }
            catch
            {
                numTask = 0;                
            }

            if (numTask > 0 && numTask <= FullList.Length)
            {
                FullList[numTask - 1].IsDone = true;
                FullList[numTask - 1].PrintToDo();
                WriteAllFJ(filename, FullList);
            }
            else
            {
                AppendFJ(filename, inputToDo);
            }
            */

            /*
            //3.Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4,
            //при подаче массива другого размера необходимо бросить исключение MyArraySizeException.
            //Далее метод должен пройтись по всем элементам массива, преобразовать в int, и просуммировать.
            //Если в каком - то элементе массива преобразование не удалось
            //(например, в ячейке лежит символ или текст вместо числа), должно быть брошено исключение MyArrayDataException, с детализацией в какой именно ячейке лежат неверные данные.
            //В методе main() вызвать полученный метод, обработать возможные исключения MySizeArrayException и MyArrayDataException, и вывести результат расчета.

            string[,] arr = { { "1", "3", "5", "7" }, { "1", "3", "5", "7" }, { "1", "3", "5", "7" }, { "1", "3", "5", "7" }, { "1", "3", "5", "7" } };
            try
            {
                Console.WriteLine(Array4x4(arr));
            }
            catch (MyArraySizeException)
            {
                Console.WriteLine("Некорректная размерность массива!");
            }

            string[,] arr1 = { { "1", "3", "5", "7" }, { "1", "3", "5", "7" }, { "l", "3", "5", "7" }, { "1", "3", "5", "7" } };

            try
            {
                Console.WriteLine(Array4x4(arr1));
            }
            catch (MyArrayDataException ae)
            {
                Console.WriteLine($"Некорректные данные в строке {ae.Row} и столбце {ae.Col}");
            }

            string[,] arr2 = { { "1", "3", "5", "7" }, { "1", "3", "5", "7" }, { "1", "3", "5", "7" }, { "1", "3", "5", "7" } };
            try
            {
                Console.WriteLine(Array4x4(arr2));
            }
            catch (MyArraySizeException)
            {
                Console.WriteLine("Некорректная размерность массива!");
            }
            catch (MyArrayDataException ae1)
            {
                Console.WriteLine($"Некорректные данные в строке {ae1.Row} и столбце {ae1.Col}");
            }
            */

            /*
            //4.Создать класс "Сотрудник" с полями: ФИО, должность, email, телефон, зарплата, возраст;
            //    Конструктор класса должен заполнять эти поля при создании объекта;
            //    Внутри класса «Сотрудник» написать метод, который выводит информацию об объекте в консоль;
            //    Создать массив из 5 сотрудников

            //    Пример:
            //        Person[] persArray = new Person[5]; // Вначале объявляем массив объектов
            //        persArray[0] = new Person("Ivanov Ivan", "Engineer", "ivivan@mailbox.com", "892312312", 30000, 30); // потом для каждой ячейки массива задаем объект
            //        persArray[1] = new Person(...);
            //        ...
            //        persArray[4] = new Person(...);

            //    С помощью цикла вывести информацию только о сотрудниках старше 40 лет;
            
            Employee[] empArray = new Employee[5];
            empArray[0] = new Employee("Иванов Иван Иванович", "Начальник отдела", "aa1@mailbox.com", "892312312", 100000, 50);
            empArray[1] = new Employee("Сидоров Петр Семенович", "Ведущий специалист", "aa2@mailbox.com", "892212322", 75000, 37);
            empArray[2] = new Employee("Петров Антон Васильевич", "Ведущий специалист", "aa3@mailbox.com", "892332313", 70000, 41);
            empArray[3] = new Employee("Ибрагимов Абдула Аглы", "Главный специалист", "aa4@mailbox.com", "892352352", 90000, 45);
            empArray[4] = new Employee("Иваськов Максим Федорович", "Специалист 11-й категории", "aa5@mailbox.com", "892372372", 30000, 23);

            foreach (var item in empArray)
            {
                if (item.Age > 40)
                {
                    item.PrintEmpInfo();
                }
            }

            */

        }

        //Формирование дерева каталогов и файлов по заданному пути с помощью рекурсии
        static string FileTreeRecurse(string path, int level)
        {
            if (Directory.Exists(path))
            {
                string[] arrDir = Directory.GetDirectories(path);
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                string s = dirInfo.Name;
                string shiftT = string.Empty;
                for (int i = 0; i < level + 1; i++)
                {
                    shiftT += "   ";
                }
                if (arrDir.Length != 0)
                {
                    foreach (var Dir in dirInfo.GetDirectories())
                    {
                        s += $"\n" + shiftT + FileTreeRecurse(Dir.FullName, level + 1);
                    }
                }
                foreach (var File in dirInfo.GetFiles())
                {
                    s += $"\n" + shiftT + File.Name;
                }
                return s;
            }
            else
            {
                return $"Каталог '{path}' не доступен!";
            }

        }

        //Считывает из файла массив задач
        static ToDo[] ReadFJ(string filename)
        {
            if (File.Exists(filename))
            {
                string[] arrJson = File.ReadAllLines(filename);
                ToDo[] ListToDo = new ToDo[arrJson.Length];
                for (int i = 0; i < arrJson.Length; i++)
                {
                    try
                    {
                        ListToDo[i] = JsonSerializer.Deserialize<ToDo>(arrJson[i]);
                    }
                    catch
                    {

                        Console.WriteLine("Файл поврежден");
                        continue;
                    }

                }
                return ListToDo;
            }
            return null;
        }

        //Добавляет новую задачу в файл
        static void AppendFJ(string filename, string inputToDo)
        {
            ToDo newTask = new ToDo(inputToDo);
            string json = JsonSerializer.Serialize(newTask);
            if (File.Exists(filename))
            {
                File.AppendAllText(filename, Environment.NewLine + json);
            }
            else
            {
                File.AppendAllText(filename, json);
            }
        }

        //Сохраняет массив задач в файл
        static void WriteAllFJ(string filename, ToDo[] list)
        {
            string[] json = new string[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                json[i] = JsonSerializer.Serialize(list[i]);
            }
            File.WriteAllLines(filename, json);
        }

        //Выводит на экран массив задач
        static void PrintFullList(ToDo[] list)
        {
            Console.Clear();
            Console.WriteLine("Список задач:");
            for (int i = 0; i < list.Length; i++)
            {

                Console.Write($"{i + 1} ");
                list[i].PrintToDo();
            }
            Console.WriteLine();
        }

        //Суммирует строковый массив 4х4
        static int Array4x4(string[,] arr)
        {
            int arrLength0 = arr.GetLength(0);
            int arrLength1 = arr.GetLength(1);
            int maxLength = 4;
            int sum = 0;

            if (arrLength0 != maxLength || arrLength1 != maxLength)
            {
                throw new MyArraySizeException();
            }
            for (int i = 0; i < arrLength0; i++)
            {
                for (int j = 0; j < arrLength1; j++)
                {
                    try
                    {
                        sum += Convert.ToInt32(arr[i, j]);
                    }
                    catch
                    {
                        throw new MyArrayDataException(i,j);
                    }
                }
            }
            return sum;
        }
    }
}