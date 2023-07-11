using Project2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Project2 {

    class Program {
        
        static void Main(string[] args) {

            Console.Write($"Enter the number of employees: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Employee> employee = new List<Employee>();

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Employee #{i} data:");
                Console.Write($"Outsourced (y/n)? ");
                char outsourced = Convert.ToChar(Console.ReadLine());
                if (outsourced == 'y') {
                    Console.Write($"Name: ");
                    string name = Console.ReadLine();
                    Console.Write($"Hours: ");
                    int hours = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Value per hour: ");
                    double valueperhour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write($"Additional charge: ");
                    double additionalCharge = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee.Add(new OutSourceEmployee { Name = name, Hours = hours, ValuePerHour = valueperhour, AdditionalCharge = additionalCharge});
                }
                else {
                    Console.Write($"Name: ");
                    string name = Console.ReadLine();
                    Console.Write($"Hours: ");
                    int hours = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Value per hour: ");
                    double valueperhour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee.Add(new Employee { Name = name, Hours = hours, ValuePerHour = valueperhour });
                }

            }

            Console.WriteLine($"PAYMENTS: ");
            foreach (Employee obj in employee) {
                Console.WriteLine($"{obj}");
            }

        }
    }
}
