using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Newspaper.Models
{
    public class Student
    {
        private int iD;
        private string name;
        private string className;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string ClassName { get => className; set => className = value; }

        public Student()
        {
        }

        public Student(int id, string name, string className)
        {
            ID = id;
            Name = name;
            ClassName = className;
        }
    }
}