using System.Globalization;
using System;

namespace Project12.Entities {
    internal class Employee : IComparable {

        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) {

            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }


        public override string ToString() {

            return $"{Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj) {

            if (!(obj is Employee)) { //If para se certificar que o objeto passado seja do tipo Employee.

                throw new ArgumentException("Comparing error: argument is not an Employee");      
            }

            Employee other = (Employee)obj; //realizando downcasting de obj para Employee.

            return Name.CompareTo(other.Name);
        }
    }
}
