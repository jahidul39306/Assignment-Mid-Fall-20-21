using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Faculty
    {
        private string facultyName;

        public string FacultyName
        {
            get { return facultyName; }
            set { facultyName = value; }
        }

        private int facId;

        public int FacId
        {
            get { return facId; }
            set { facId = value; }
        }

        private int facultyWeeklyHour;

        public int FacultyWeeklyHour
        {
            get { return facultyWeeklyHour; }
            set { facultyWeeklyHour = value; }
        }


        private Section[] sections;

        public Section[] Sections
        {
            get { return sections; }
            set { sections = value; }
        }

        private int sectionCount = 0;

        public int SectionCount
        {
            get { return sectionCount; }
            set { sectionCount = value; }
        }


        public void AddSection(Section s)
        {
            sections[sectionCount++] = s;
        }

        public Faculty(string facultyName, int facId)
        {
            this.facultyName = facultyName;
            this.facId = facId;
            sections = new Section[100];
        }


        public void FacultyInfo()
        {
            Console.WriteLine("Faculty Details");
            Console.WriteLine("---------------");
            Console.WriteLine("Faculty Name: " + facultyName);
            Console.WriteLine("Faculty ID: " + facId);
            Console.WriteLine("Faculty weekly hour: " + facultyWeeklyHour);
            Console.WriteLine("**************************************");
        }
        public void ShowFacultySec()
        {
            Console.WriteLine("Section Details Under " + facultyName);
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < sectionCount; i++)
            {
                sections[i].SecInfo();
                Console.WriteLine("**************************************");
            }
        }
    }
}
