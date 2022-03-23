using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTask.Models
{
    public class Group
    {
        Student[] Students = new Student[0];
        private string groupNo;
        public string GroupNo
        {
            get
            {
                return groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    groupNo = value;
                }
            }
        }
        private int studentLimit;
        public int StudentLimit
        {
            get
            {
                return studentLimit;
            }
            set
            {
                if (value > 4 && value < 19)
                {
                    studentLimit = value;
                }
            }
        }
        public bool CheckGroupNo(string GroupNo)
        {
            if (Char.IsNumber(GroupNo[0]) || Char.IsNumber(GroupNo[1])) return false;
            if (Char.IsLower(GroupNo[0]) || Char.IsLower(GroupNo[1])) return false;
            if (!Char.IsNumber(GroupNo[2]) || !Char.IsNumber(GroupNo[3]) || !Char.IsNumber(GroupNo[4])) return false;
            return true;
        }
        public void AddStudent(string FullName, int point)
        {
            if ((Students.Length + 1) <= StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = new Student(FullName, point);
            }
            else
            {
                Console.WriteLine("Qrup doludur!");
            }
        }
        public void GetStudent(int? Id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == Id)
                {
                    Console.WriteLine($"FullName:{Students[i].FullName} point: {Students[i].point}");
                }
            }
        }
        public void GetAllStudent()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"ID: {Students[i].Id} FullName:{Students[i].FullName} point: {Students[i].point}");

            }
        }
        public Group(string GroupNo, int StudentLimit)
        {
            this.StudentLimit = studentLimit;
            this.GroupNo = GroupNo;
        }
    }
}
