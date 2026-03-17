using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Final
{
    internal class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course() { }

        public Course(string name, string code, int credit)
        {
            courseName = name;
            courseCode = code;
            courseCredit = credit;
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine(courseName + " (" + courseCode + ")");
        }
    }
}
