using System;
using System.Collections.Generic;
namespace HospitalManagementSystem
{

    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public virtual void ShowProfile()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // ---------------- DERIVED CLASSES ----------------
    class Patient : Person
    {
        public int PatientId { get; set; }
        public List<MedicalRecord> MedicalHistory { get; set; } = new List<MedicalRecord>();

        public override void ShowProfile()
        {
            Console.WriteLine($"Patient -> ID: {PatientId}, Name: {Name}, Age: {Age}");
        }
    }

    class Doctor : Person
    {
        public int DoctorId { get; set; }
        public string Specialization { get; set; }

        public override void ShowProfile()
        {
            Console.WriteLine($"Doctor -> ID: {DoctorId}, Name: {Name}, Specialization: {Specialization}");
        }
    }

    class Nurse : Person
    {
        public int NurseId { get; set; }
        public string Shift { get; set; }

        public override void ShowProfile()
        {
            Console.WriteLine($"Nurse -> ID: {NurseId}, Name: {Name}, Shift: {Shift}");
        }
    }
    class MedicalRecord
    {
        private string diagnosis;
        private string treatment;
        private DateTime date;

        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }

        public string Treatment
        {
            get { return treatment; }
            set { treatment = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public void ShowRecord()
        {
            Console.WriteLine($"Date: {Date.ToShortDateString()}, Diagnosis: {Diagnosis}, Treatment: {Treatment}");
        }
    }

    class Appointment
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AppointmentDate { get; set; }

        public void ShowAppointment()
        {
            Console.WriteLine($"Appointment -> Patient: {Patient.Name}, Doctor: {Doctor.Name}, Date: {AppointmentDate}");
        }
    }

    class Program
    {
        static List<Patient> patients = new List<Patient>();
        static List<Doctor> doctors = new List<Doctor>();
        static List<Nurse> nurses = new List<Nurse>();
        static List<Appointment> appointments = new List<Appointment>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n====== Hospital Management System ======");
                Console.WriteLine("1. Register Patient");
                Console.WriteLine("2. Register Doctor");
                Console.WriteLine("3. Register Nurse");
                Console.WriteLine("4. Schedule Appointment");
                Console.WriteLine("5. Add Medical Record");
                Console.WriteLine("6. View All Patients");
                Console.WriteLine("7. View All Doctors");
                Console.WriteLine("8. View Appointments");
                Console.WriteLine("9. View Patient Medical History");
                Console.WriteLine("10. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: RegisterPatient(); break;
                    case 2: RegisterDoctor(); break;
                    case 3: RegisterNurse(); break;
                    case 4: ScheduleAppointment(); break;
                    case 5: AddMedicalRecord(); break;
                    case 6: ViewPatients(); break;
                    case 7: ViewDoctors(); break;
                    case 8: ViewAppointments(); break;
                    case 9: ViewMedicalHistory(); break;
                    case 10: return;
                    default: Console.WriteLine("Invalid Choice!"); break;
                }
            }
        }


        static void RegisterPatient()
        {
            Patient p = new Patient();

            Console.Write("Enter Patient ID: ");
            p.PatientId = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            p.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            p.Age = int.Parse(Console.ReadLine());

            patients.Add(p);
            Console.WriteLine("Patient Registered Successfully!");
        }

        static void RegisterDoctor()
        {
            Doctor d = new Doctor();

            Console.Write("Enter Doctor ID: ");
            d.DoctorId = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            d.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            d.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Specialization: ");
            d.Specialization = Console.ReadLine();

            doctors.Add(d);
            Console.WriteLine("Doctor Registered Successfully!");
        }

        static void RegisterNurse()
        {
            Nurse n = new Nurse();

            Console.Write("Enter Nurse ID: ");
            n.NurseId = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            n.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            n.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Shift: ");
            n.Shift = Console.ReadLine();

            nurses.Add(n);
            Console.WriteLine("Nurse Registered Successfully!");
        }

        static void ScheduleAppointment()
        {
            if (patients.Count == 0 || doctors.Count == 0)
            {
                Console.WriteLine("Patients or Doctors not available.");
                return;
            }

            Console.WriteLine("Select Patient:");
            for (int i = 0; i < patients.Count; i++)
                Console.WriteLine($"{i + 1}. {patients[i].Name}");

            int pIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Select Doctor:");
            for (int i = 0; i < doctors.Count; i++)
                Console.WriteLine($"{i + 1}. {doctors[i].Name} ({doctors[i].Specialization})");

            int dIndex = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter Appointment Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Appointment ap = new Appointment
            {
                Patient = patients[pIndex],
                Doctor = doctors[dIndex],
                AppointmentDate = date
            };

            appointments.Add(ap);
            Console.WriteLine("Appointment Scheduled Successfully!");
        }

        static void AddMedicalRecord()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patients available.");
                return;
            }

            Console.WriteLine("Select Patient:");
            for (int i = 0; i < patients.Count; i++)
                Console.WriteLine($"{i + 1}. {patients[i].Name}");

            int index = int.Parse(Console.ReadLine()) - 1;

            MedicalRecord record = new MedicalRecord();

            Console.Write("Enter Diagnosis: ");
            record.Diagnosis = Console.ReadLine();

            Console.Write("Enter Treatment: ");
            record.Treatment = Console.ReadLine();

            record.Date = DateTime.Now;

            patients[index].MedicalHistory.Add(record);
            Console.WriteLine("Medical Record Added Successfully!");
        }

        static void ViewPatients()
        {
            Console.WriteLine("\n--- Patients List ---");
            foreach (var p in patients)
            {
                p.ShowProfile();
            }
        }

        static void ViewDoctors()
        {
            Console.WriteLine("\n--- Doctors List ---");
            foreach (var d in doctors)
            {
                d.ShowProfile();
            }
        }

        static void ViewAppointments()
        {
            Console.WriteLine("\n--- Appointments ---");
            foreach (var a in appointments)
            {
                a.ShowAppointment();
            }
        }

        static void ViewMedicalHistory()
        {
            Console.WriteLine("Select Patient:");
            for (int i = 0; i < patients.Count; i++)
                Console.WriteLine($"{i + 1}. {patients[i].Name}");

            int index = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine($"\nMedical History of {patients[index].Name}:");
            foreach (var r in patients[index].MedicalHistory)
            {
                r.ShowRecord();
            }
        }
    }

}
