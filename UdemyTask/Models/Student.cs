using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyTask.Models
{
    public class Student
    {
        private static int _id = 1;
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string FullName { get; set; }
        public int point { get; set; }
        public Student(string FullName, int point)
        {
            this.FullName = FullName;
            this.point = point;
            _id++;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"FullName {FullName} point {point}");
        }
    }
}
