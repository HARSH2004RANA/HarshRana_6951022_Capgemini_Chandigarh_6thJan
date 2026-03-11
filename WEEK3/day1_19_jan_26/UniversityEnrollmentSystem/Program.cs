namespace UniversityEnrollmentSystem
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<Professor> professors = new List<Professor>();
        static List<Staff> staffs = new List<Staff>();
        static List<Course> courses = new List<Course>();

        static void Main()
        {
            // Predefined courses
            courses.Add(new Course { CourseId = "C101", CourseName = "Data Structures" });
            courses.Add(new Course { CourseId = "C102", CourseName = "Machine Learning" });
            courses.Add(new Course { CourseId = "C103", CourseName = "Database Systems" });

            while (true)
            {
                Console.WriteLine("\n==== University Enrollment System ====");
                Console.WriteLine("1. Register Student");
                Console.WriteLine("2. Register Professor");
                Console.WriteLine("3. Register Staff");
                Console.WriteLine("4. Assign Course to Professor");
                Console.WriteLine("5. Enroll Student in Course");
                Console.WriteLine("6. View All Profiles");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: RegisterStudent(); break;
                    case 2: RegisterProfessor(); break;
                    case 3: RegisterStaff(); break;
                    case 4: AssignCourseToProfessor(); break;
                    case 5: EnrollStudentInCourse(); break;
                    case 6: ViewProfiles(); break;
                    case 7: return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        // ---------------- FEATURES ----------------

        static void RegisterStudent()
        {
            Student s = new Student();

            Console.Write("Enter Student Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            s.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Roll Number: ");
            s.RollNo = int.Parse(Console.ReadLine());

            students.Add(s);
            Console.WriteLine("Student Registered Successfully!");
        }

        static void RegisterProfessor()
        {
            Professor p = new Professor();

            Console.Write("Enter Professor Name: ");
            p.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            p.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee ID: ");
            p.EmployeeId = Console.ReadLine();

            professors.Add(p);
            Console.WriteLine("Professor Registered Successfully!");
        }

        static void RegisterStaff()
        {
            Staff s = new Staff();

            Console.Write("Enter Staff Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            s.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Department: ");
            s.Department = Console.ReadLine();

            staffs.Add(s);
            Console.WriteLine("Staff Registered Successfully!");
        }

        static void AssignCourseToProfessor()
        {
            if (professors.Count == 0)
            {
                Console.WriteLine("No professors available.");
                return;
            }

            Console.WriteLine("Select Professor:");
            for (int i = 0; i < professors.Count; i++)
                Console.WriteLine($"{i + 1}. {professors[i].Name}");

            int pIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Select Course:");
            for (int i = 0; i < courses.Count; i++)
                Console.WriteLine($"{i + 1}. {courses[i].CourseName}");

            int cIndex = int.Parse(Console.ReadLine()) - 1;

            professors[pIndex].AssignedCourses.Add(courses[cIndex]);
            Console.WriteLine("Course Assigned to Professor!");
        }

        static void EnrollStudentInCourse()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            Console.WriteLine("Select Student:");
            for (int i = 0; i < students.Count; i++)
                Console.WriteLine($"{i + 1}. {students[i].Name}");

            int sIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Select Course:");
            for (int i = 0; i < courses.Count; i++)
                Console.WriteLine($"{i + 1}. {courses[i].CourseName}");

            int cIndex = int.Parse(Console.ReadLine()) - 1;

            students[sIndex].EnrolledCourses.Add(courses[cIndex]);
            Console.WriteLine("Student Enrolled in Course!");
        }

        static void ViewProfiles()
        {
            Console.WriteLine("\n--- Students ---");
            foreach (var s in students)
            {
                s.ShowProfile();
                Console.WriteLine();
            }

            Console.WriteLine("\n--- Professors ---");
            foreach (var p in professors)
            {
                p.ShowProfile();
                Console.WriteLine();
            }

            Console.WriteLine("\n--- Staff ---");
            foreach (var st in staffs)
            {
                st.ShowProfile();
                Console.WriteLine();
            }
        }
    }
}
