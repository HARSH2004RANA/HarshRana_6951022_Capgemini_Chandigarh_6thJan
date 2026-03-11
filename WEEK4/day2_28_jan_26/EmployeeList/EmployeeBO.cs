using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeList
{
    internal class EmployeeBO
    {
        public void DisplayEmployeeDetails(List<Employee> employeeList, string name)
        {
            List<Employee> employees=(from e in employeeList
                                      where e.Name==name
                                      select e).ToList();
            int count=employees.Count;
            if (count == 0)
            {
                Console.WriteLine("Employee named {0} not found", name);
            }
            else
            {
                Console.WriteLine(string.Format("{0,-21}{1,-6}{2,-21}{3,-20}", "name", "age", "designation", "city"));
                foreach (Employee e in employees)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        public void DisplayYoungestEmployeeDetails(List<Employee> employeeList)
        {
            int min = (from e in employeeList
                       select e.Age).Min();
            var employees = (from e in employeeList
                                        where e.Age == min
                                        select e);
            Console.WriteLine(string.Format("{0,-21}{1,-6}{2,-21}{3,-20}", "name", "age", "designation", "city"));
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void DisplayEmployeesFromCity(List<Employee> employeeList, string cname)
        {
            List<Employee> employees = (from e in employeeList
                                        where e.City == cname
                                        select e).ToList();
            int count = employees.Count;
            if (count == 0)
            {
                Console.WriteLine("City named {0} not found", cname);
            }
            else
            {
                Console.WriteLine(string.Format("{0,-21}{1,-6}{2.-21}{3,-20}", "name", "age", "designation", "city"));
                foreach (Employee e in employees)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

    }
}
