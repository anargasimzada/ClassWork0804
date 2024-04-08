using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork0804.Moduls
{
    internal class Group
    {
        public static Group[] Groups;
        public static int GroupCount;
        public int GroupId;
        public string GroupName;
        public Student[] Students;

        public string GetGroupInfo()
        {
            string info = $"GroupId: {GroupId}, GroupName: {GroupName}\n";
            foreach (Student student in Students)
            {
                info += $"{student.GetInfo()}\n";
            }
            return info;
        }
        public Student GetStudent(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                    return student;
            }
            return null;
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
    }
}
