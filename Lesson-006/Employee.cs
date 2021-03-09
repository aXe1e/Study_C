using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_006
{
    class Employee
    {
        public string FIO { get; }
        public string Post { get; }
        public string Email { get; }
        public string Phone { get; }
        public int Salary { get; }
        public byte Age { get; }

        public Employee(string fio, string post, string email, string phone, int salary, byte age)
        {
            FIO = fio;
            Post = post;
            Email = email;
            Phone = phone;
            Salary = salary;
            Age = age;
        }
        public void PrintEmpInfo()
        {
            Console.WriteLine($"{FIO}\t{Post}\t{Email}\t{Phone}\t{Salary}\t{Age}");
        }
    }
}
