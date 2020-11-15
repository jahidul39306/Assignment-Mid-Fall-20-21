using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Course
    {
        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private Section[] sections;
        private Faculty[] faculties;

        private int sectionCount;
        private int facultiesCount;
        public int SectionCount
        {
            get { return sectionCount; }
            set { sectionCount = value; }
        }

        private int weeklyHour;

        public int WeeklyHour
        {
            get { return weeklyHour; }
            set { weeklyHour = value; }
        }



        public Course(string courseName, string code, int weeklyHour)
        {
            this.courseName = courseName;
            this.code = code;
            this.weeklyHour = weeklyHour;
            sections = new Section[100];
            faculties = new Faculty[100];
        }

        public void AddSection(Section s)
        {
            sections[sectionCount++] = s;
            s.SecCourse = this;
            s.SecWeeklyHour = weeklyHour;
        }

        public void AddFaculty(Faculty f)
        {   
            faculties[facultiesCount++] = f;    
        }

        public void SecDetails()
        {
            Console.WriteLine("Section Details Under Course: " + courseName);
            Console.WriteLine("---------------------------------");
            for(int i = 0; i < sectionCount; i++)
            {
                sections[i].SecInfo();
                Console.WriteLine("**************************************");
            }
        }
        public void FacDetails()
        {
            Console.WriteLine("Faculty Details Under Course: " + courseName);
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < facultiesCount; i++)
            {
                faculties[i].FacultyInfo();
                Console.WriteLine("**************************************");
            }
        }

    }
}
