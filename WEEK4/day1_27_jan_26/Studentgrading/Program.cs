using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGrading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> students = new Dictionary<int, double>()
            {
                {101, 72},
                {102, 45},
                {103, 88},
                {104, 39},
                {105, 60}
            };

            Func<Dictionary<int, double>, double> averageGrade = dict =>
            {
                return dict.Values.Average();
            };

            Predicate<double> isAtRisk = grade => grade < 50;

            Console.WriteLine("Initial Student Grades:");
            DisplayStudents(students);
           
            Console.WriteLine("\nAverage Grade: " + averageGrade(students));

      
            Console.WriteLine("\nStudents at Risk (Grade < 50):");
            foreach (var student in students)
            {
                if (isAtRisk(student.Value))
                {
                    Console.WriteLine($"Roll No: {student.Key}, Grade: {student.Value}");
                }
            }

            Console.WriteLine("\nEnter Roll Number to update grade:");
            int roll = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new grade:");
            double newGrade = double.Parse(Console.ReadLine());

            if (students.ContainsKey(roll))
            {
                students[roll] = newGrade;
                Console.WriteLine("Grade updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            Console.WriteLine("\nUpdated Student Grades:");
            DisplayStudents(students);

            Console.WriteLine("\nStudents at Risk After Update:");
            foreach (var student in students)
            {
                if (isAtRisk(student.Value))
                {
                    Console.WriteLine($"Roll No: {student.Key}, Grade: {student.Value}");
                }
            }

            Console.ReadLine();
        }

        static void DisplayStudents(Dictionary<int, double> students)
        {
            foreach (var s in students)
            {
                Console.WriteLine($"Roll No: {s.Key}, Grade: {s.Value}");
            }
        }
    }
}
