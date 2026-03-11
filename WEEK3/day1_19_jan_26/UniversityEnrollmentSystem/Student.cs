using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    class Student : Person
    {
        public int RollNo { get; set; }
        public List<Course> EnrolledCourses { get; set; } = new List<Course>();

        public override void ShowProfile()
        {
            Console.WriteLine($"Student -> Name: {Name}, Roll No: {RollNo}, Age: {Age}");
            Console.WriteLine("Enrolled Courses:");
            foreach (var c in EnrolledCourses)
                Console.WriteLine($" - {c.CourseName}");
        }
    }
}
