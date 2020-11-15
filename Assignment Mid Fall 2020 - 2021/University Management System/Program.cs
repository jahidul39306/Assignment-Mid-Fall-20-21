using System;

namespace University_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Department d1 = new Department("CSE", 85);

            Faculty f1 = new Faculty("Sakib", 45);
            Faculty f2 = new Faculty("Nayamut", 89);
            Faculty f3 = new Faculty("Jahid", 88);

            Section s1 = new Section("B");
            Section s2 = new Section("A");
            Section s3 = new Section("C");
            Section s4 = new Section("D");
            Section s5 = new Section("E");

            Course c1 = new Course("C++", "C563", 5);
            Course c2 = new Course("Java", "J253", 5);
            Course c3 = new Course("DataStructure", "D453", 18);

            d1.AddCourse(c1);
            d1.AddCourse(c2);
            d1.AddCourse(c3);

            c1.AddSection(s1);
            c1.AddSection(s3);
            c1.AddSection(s2);
            c2.AddSection(s4);
            c3.AddSection(s5);

            s1.AddFaculty(f2);
            s2.AddFaculty(f1);
            s5.AddFaculty(f1);
            s3.AddFaculty(f3);
            s4.AddFaculty(f3);

            c1.SecDetails();
            c1.FacDetails();
            c2.FacDetails();
            c3.FacDetails();
            f3.ShowFacultySec();
            Console.WriteLine("----------------------------------");

        }
    }
}
