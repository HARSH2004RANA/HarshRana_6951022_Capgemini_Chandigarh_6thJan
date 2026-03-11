using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    class Professor : Person
    {
        public string EmployeeId { get; set; }
        public List<Course> AssignedCourses { get; set; } = new List<Course>();

        public override void ShowProfile()
        {
            Console.WriteLine($"Professor -> Name: {Name}, ID: {EmployeeId}");
            Console.WriteLine("Assigned Courses:");
            foreach (var c in AssignedCourses)
                Console.WriteLine($" - {c.CourseName}");
        }
    }
}
