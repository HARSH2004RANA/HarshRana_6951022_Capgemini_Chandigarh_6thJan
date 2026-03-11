using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollmentSystem
{
    class Staff : Person
    {
        public string Department { get; set; }

        public override void ShowProfile()
        {
            Console.WriteLine($"Staff -> Name: {Name}, Department: {Department}");
        }
    }
}
