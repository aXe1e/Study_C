using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_006
{
    [Serializable]
    public class MyArrayDataException : Exception
    {
        public int Row { get; }
        public int Col { get; }
        public MyArrayDataException(int row, int col)
        {
            Row = row;
            Col = col;
        }
    }
}
