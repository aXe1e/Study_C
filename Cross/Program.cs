using System;

namespace Level_1.Lesson_7
{
    class Cross
    {
        static int SIZE_WIN = 4; //кол-во заполненных подряд полей для победы
        static int SIZE_X = 5;
        static int SIZE_Y = SIZE_X;

        static char[,] field = new char[SIZE_Y, SIZE_X];

        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        static Random random = new Random();

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-----------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
        }

        private static void SetSym(int y, int x, char dot)
        {
            field[y, x] = dot;
        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void PlayerStep()
        {
            int x;
            int y;
            do
            {
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_Y);
                Console.WriteLine("Координат по строке ");
                x = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Координат по столбцу ");
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        private static void AiStep()
        {
            int x;
            int y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }

        private static bool CheckWin(char dot)
        {
            for (int y = 0; y < SIZE_Y; y++)
            {
                for (int x = 0; x < SIZE_X; x++)
                {
                    if (x + SIZE_WIN <= SIZE_X)
                    {
                        if (CheckLineHorisont(y, x, dot) >= SIZE_WIN) return true;
                        if (y - SIZE_WIN > -2)
                        {                            //вверх по диагонале
                            if (CheckDiaUp(y, x, dot) >= SIZE_WIN) return true;
                        }
                        if (y + SIZE_WIN <= SIZE_Y)
                        {                       //вниз по диагонале
                            if (CheckDiaDown(y, x, dot) >= SIZE_WIN) return true;
                        }
                    }
                    if (y + SIZE_WIN <= SIZE_Y)
                    {                       //по вертикале
                        if (CheckLineVertical(y, x, dot) >= SIZE_WIN) return true;
                    }
                }
            }
            return false;
        }
        
        //проверка заполнения всей линии по диагонале вверх
        private static int CheckDiaUp(int y, int x, char dot)
        {
            int count = 0;
            for (int i = 0; i < SIZE_WIN; i++)
            {
                if (field[y - i, x + i] == dot) count++;
            }
            return count;
        }
        
        //проверка заполнения всей линии по диагонале вниз
        private static int CheckDiaDown(int y, int x, char dot)
        {
            int count = 0;
            for (int i = 0; i < SIZE_WIN; i++)
            {
                if (field[y + i, x + i] == dot) count++;
            }
            return count;
        }

        //проверка заполнения всей линии по горизонтале
        private static int CheckLineHorisont(int y, int x, char dot)
        {
            int count = 0;
            for (int i = x; i < x + SIZE_WIN; i++)
            {
                if (field[y, i] == dot) count++;
            }
            return count;
        }
        //проверка заполнения всей линии по вертикале
        private static int CheckLineVertical(int y, int x, char dot)
        {
            int count = 0;
            for (int i = y; i < y + SIZE_WIN; i++)
            {
                if (field[i, x] == dot) count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            InitField();
            PrintField();

            do
            {
                PlayerStep();
                Console.WriteLine("Ваш ход на поле");
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("Player Win!");
                    break;
                }
                else if (IsFieldFull()) break;

                AiStep();
                Console.WriteLine("Ход Компа на поле");
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("Выиграли Комп");
                    break;
                }
                else if (IsFieldFull()) break;
            } while (true);
            Console.WriteLine("!Конец игры!");
        }
    }
}
