using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    class Department
    {
        public string DeptName { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
