using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabStaticMod
{
    class Student
    {
        public Student(string name, string surname, int age)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;
        }

        static Student()
        {
            Console.WriteLine("i am one");
        }
        public int Id;

        public string Name;

        public string Surname;

        public int Age;

        private static int _id = 0;

        //public string Fullname()
        //{
        //    return $"{Name} {Surname}";
        //}
        public override string ToString()
        {
            return Name + " " + Surname;
        }

        //public static void Test()
        //{
        //    Console.WriteLine("MERABA AQ");
        //}
    }
}
