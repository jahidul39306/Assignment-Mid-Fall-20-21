using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Section
    {
        public Course SecCourse { get; set; }

        private string secNumber;

        public string SecNumber
        {
            get { return secNumber; }
            set { secNumber = value; }
        }

        private Faculty faculty;

        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public void AddFaculty(Faculty f)
        {
            if ((f.FacultyWeeklyHour + SecWeeklyHour) <= 21)
            {
                faculty = f;
                f.FacultyWeeklyHour = f.FacultyWeeklyHour + SecWeeklyHour;
                f.AddSection(this);
                SecCourse.AddFaculty(f);
                Console.WriteLine(f.FacultyName + " added to Course: " + SecCourse.CourseName + " Section: " + secNumber);
                Console.WriteLine("----------------------------------------------");
            }
            else
            {
                Console.WriteLine(f.FacultyName + " can not be added in section " + secNumber + " Course Name: " + SecCourse.CourseName);
                Console.WriteLine("----------------------------------------------");
            }     
        }

        //private int secWeeklyHour;

        public int SecWeeklyHour
        {
            get;
            set;
        }

        public Section(string secNumber)
        {
            this.secNumber = secNumber;      
        }

        public void SecInfo()
        {
            Console.WriteLine("Section Details");
            Console.WriteLine("---------------");
            Console.WriteLine("Section Number: " + secNumber);
            Console.WriteLine("Section Course Name: " + SecCourse.CourseName);
            Console.WriteLine("Faculty Name: " + faculty.FacultyName);
            Console.WriteLine("Section Weekly Hour: " + SecWeeklyHour);
            Console.WriteLine("**************************************");
        }
    }
}
