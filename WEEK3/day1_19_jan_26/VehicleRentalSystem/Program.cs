
    using System;
    using System.Collections.Generic;
    namespace VehicleRentalSystem
    {
        class Vehicle
    {
        private string vehicleNumber;
        private string model;
        private double ratePerDay;
        private bool isAvailable = true;

        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double RatePerDay
        {
            get { return ratePerDay; }
            set { ratePerDay = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public virtual double CalculateRent(int days)
        {
            return days * RatePerDay;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Vehicle No: {VehicleNumber}, Model: {Model}, Rate/Day: {RatePerDay}, Available: {IsAvailable}");
        }
    }

    class Car : Vehicle
    {
        public override double CalculateRent(int days)
        {
            return base.CalculateRent(days) + 500; 
        }
    }

    class Bike : Vehicle
    {
        public override double CalculateRent(int days)
        {
            return base.CalculateRent(days);
        }
    }

    class Truck : Vehicle
    {
        public override double CalculateRent(int days)
        {
            return base.CalculateRent(days) + 1000; 
        }
    }

    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
    }


    class RentalTransaction
    {
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public int Days { get; set; }
        public double TotalAmount { get; set; }

        public void ShowTransaction()
        {
            Console.WriteLine($"Customer: {Customer.Name}");
            Console.WriteLine($"Vehicle: {Vehicle.Model}");
            Console.WriteLine($"Days: {Days}");
            Console.WriteLine($"Total Rent: {TotalAmount}");
        }
    }

    // ---------------- MAIN PROGRAM ----------------
    class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();
        static List<Customer> customers = new List<Customer>();
        static List<RentalTransaction> rentals = new List<RentalTransaction>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n===== Vehicle Rental System =====");
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. View Vehicles");
                Console.WriteLine("3. Add Customer");
                Console.WriteLine("4. Rent Vehicle");
                Console.WriteLine("5. Return Vehicle");
                Console.WriteLine("6. View Rental Transactions");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddVehicle(); break;
                    case 2: ViewVehicles(); break;
                    case 3: AddCustomer(); break;
                    case 4: RentVehicle(); break;
                    case 5: ReturnVehicle(); break;
                    case 6: ViewTransactions(); break;
                    case 7: return;
                    default: Console.WriteLine("Invalid Choice!"); break;
                }
            }
        }

        // ---------------- FEATURES ----------------

        static void AddVehicle()
        {
            Console.WriteLine("Select Vehicle Type: 1.Car  2.Bike  3.Truck");
            int type = int.Parse(Console.ReadLine());

            Vehicle v = null;

            if (type == 1) v = new Car();
            else if (type == 2) v = new Bike();
            else if (type == 3) v = new Truck();
            else
            {
                Console.WriteLine("Invalid Type!");
                return;
            }

            Console.Write("Enter Vehicle Number: ");
            v.VehicleNumber = Console.ReadLine();

            Console.Write("Enter Model: ");
            v.Model = Console.ReadLine();

            Console.Write("Enter Rate per Day: ");
            v.RatePerDay = double.Parse(Console.ReadLine());

            vehicles.Add(v);
            Console.WriteLine("Vehicle Added Successfully!");
        }

        static void ViewVehicles()
        {
            Console.WriteLine("\n--- Vehicles List ---");
            foreach (var v in vehicles)
                v.ShowDetails();
        }

        static void AddCustomer()
        {
            Customer c = new Customer();

            Console.Write("Enter Customer ID: ");
            c.CustomerId = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            c.Name = Console.ReadLine();

            customers.Add(c);
            Console.WriteLine("Customer Added Successfully!");
        }

        static void RentVehicle()
        {
            if (customers.Count == 0 || vehicles.Count == 0)
            {
                Console.WriteLine("Customers or Vehicles not available.");
                return;
            }

            Console.WriteLine("Select Customer:");
            for (int i = 0; i < customers.Count; i++)
                Console.WriteLine($"{i + 1}. {customers[i].Name}");

            int cIndex = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Available Vehicles:");
            List<Vehicle> availableVehicles = vehicles.FindAll(v => v.IsAvailable);

            if (availableVehicles.Count == 0)
            {
                Console.WriteLine("No vehicles available for rent.");
                return;
            }

            for (int i = 0; i < availableVehicles.Count; i++)
                Console.WriteLine($"{i + 1}. {availableVehicles[i].Model}");

            int vIndex = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter number of days: ");
            int days = int.Parse(Console.ReadLine());

            Vehicle selectedVehicle = availableVehicles[vIndex];
            selectedVehicle.IsAvailable = false;

            double rent = selectedVehicle.CalculateRent(days);

            RentalTransaction rt = new RentalTransaction
            {
                Customer = customers[cIndex],
                Vehicle = selectedVehicle,
                Days = days,
                TotalAmount = rent
            };

            rentals.Add(rt);

            Console.WriteLine("Vehicle Rented Successfully!");
            Console.WriteLine($"Total Rent: {rent}");
        }

        static void ReturnVehicle()
        {
            Console.WriteLine("Rented Vehicles:");
            var rentedVehicles = rentals.FindAll(r => !r.Vehicle.IsAvailable);

            if (rentedVehicles.Count == 0)
            {
                Console.WriteLine("No rented vehicles.");
                return;
            }

            for (int i = 0; i < rentals.Count; i++)
                Console.WriteLine($"{i + 1}. {rentals[i].Vehicle.Model} - {rentals[i].Customer.Name}");

            int index = int.Parse(Console.ReadLine()) - 1;

            rentals[index].Vehicle.IsAvailable = true;
            Console.WriteLine("Vehicle Returned Successfully!");
        }

        static void ViewTransactions()
        {
            Console.WriteLine("\n--- Rental Transactions ---");
            foreach (var r in rentals)
            {
                r.ShowTransaction();
                Console.WriteLine();
            }
        }
    }

}
