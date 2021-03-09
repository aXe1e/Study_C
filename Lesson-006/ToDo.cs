using System;

namespace Lesson_006
{
    [Serializable]
    class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public ToDo()
        {
            Title = string.Empty;
            IsDone = false;
        }
        public ToDo(string title)
        {
            Title = title;
            IsDone = false;
        }

        public void PrintToDo()
        {
            if (IsDone)
            {
                Console.WriteLine($"[x] {Title}");
            }
            else
            {
                Console.WriteLine(Title);
            }
        }
    }
}
