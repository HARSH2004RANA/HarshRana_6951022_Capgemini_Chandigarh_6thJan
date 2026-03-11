using System;
using System.Collections.Generic;
namespace PatientList
{
    

    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patientList = new List<Patient>();
            int noOfPatients, i;
            string name, city, illness;
            int age;

            Console.WriteLine("Enter the number of patients");
            noOfPatients = int.Parse(Console.ReadLine());

            for (i = 0; i < noOfPatients; i++)
            {
                Console.WriteLine("Enter patient " + (i + 1) + " details:");
                Console.WriteLine("Enter the name");
                name = Console.ReadLine();

                Console.WriteLine("Enter the age");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the illness");
                illness = Console.ReadLine();

                Console.WriteLine("Enter the city");
                city = Console.ReadLine();

                Patient patient = new Patient(name, age, illness, city);
                patientList.Add(patient);
            }

            int choice;
            PatientBO patientBO = new PatientBO();
            string opt;

            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1)Display Patient Details");
                Console.WriteLine("2)Display Youngest Patient Details");
                Console.WriteLine("3)Display Patients from City");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter patient name:");
                        name = Console.ReadLine();
                        patientBO.DisplayPatientDetails(patientList, name);
                        break;

                    case 2:
                        Console.WriteLine("The Youngest Patient Details");
                        patientBO.DisplayYoungestPatientDetails(patientList);
                        break;

                    case 3:
                        Console.WriteLine("Enter city");
                        city = Console.ReadLine();
                        patientBO.DisplayPatientsFromCity(patientList, city);
                        break;
                }

                Console.WriteLine("Do you want to continue(Yes/No)?");
                opt = Console.ReadLine();

            } while (opt.Equals("Yes"));
        }
    }

}
