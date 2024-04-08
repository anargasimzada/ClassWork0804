using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork0804.Moduls
{
    internal class Student
    {
        public static int count;
        public int _id;
        public string _name;
        public string _surname;

        private static int Count = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public static string Capitalize(string name, string surname)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();

        }

        public Student(string name, string surname)
        {
            Id = ++Count;
            Name = char.ToUpper(name[0]) + name.Substring(1);
            Surname = char.ToUpper(surname[0]) + surname.Substring(1);
        }
        public string GetInfo()
        {
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}";
        }

    }
}
