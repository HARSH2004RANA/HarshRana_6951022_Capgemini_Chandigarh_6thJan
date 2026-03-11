using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeList
{
    internal class Employee
    {
        string _name;
        int _age;
        string _designation;
        string _city;
        public Employee()
        {

        }
        public Employee(string name, int age, string designation, string city)
        {
            _name = name;
            _age = age;
            _designation = designation;
            _city = city;
        }

        public string Name{
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                _designation = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0,-21}{1,-6}{2,-21}{3,-20}",
                this._name,this._age, this._designation,this._city
                );
        }
    }
}
