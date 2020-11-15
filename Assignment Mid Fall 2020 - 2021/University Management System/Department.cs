using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Department
    {
        private int courseCount;

        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }

        private int dCode;

        public int DCode
        {
            get { return dCode; }
            set { dCode = value; }
        }

        private Course[] courses;

        public Course[] Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public void AddCourse(Course c)
        {
            courses[courseCount++] = c;
        }

        public Department(String departmentName, int dCode)
        {
            this.departmentName = departmentName;
            this.dCode = dCode;
            courses = new Course[100];
        }
        
        public void DepartmentInfo()
        {
            Console.WriteLine("Department Name: " + departmentName);
            Console.WriteLine("Department Code: " + dCode);
            Console.WriteLine("Department Courses: " + courses);
        }



    }
}
