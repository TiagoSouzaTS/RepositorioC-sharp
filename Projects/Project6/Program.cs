using Project6.Entities;
using System;
using System.Globalization;
using Project6.Entities.Enums;

namespace Project6 {
    class Program {

        static double Pi = 3.14;

        static void Main(string[] args) {

            Console.Write($"Enter department1s name: ");
            Department department = new Department(Console.ReadLine());

            Console.WriteLine($"Enter worker data: ");
            Console.Write($"Name: ");
            string name = Console.ReadLine();

            Console.Write($"Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write($"Base salary: ");
            double baseSalary = Convert.ToDouble(Console.ReadLine());

            Worker w1 = new Worker(name, level, baseSalary, department);

            Console.Write($"How many contracts to this worker? ");
            int contracts = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= contracts; i++) {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write($"Date (DD/MM/YYYY): ");
                DateTime d1 = Convert.ToDateTime(Console.ReadLine());
                Console.Write($"Value per hour: ");
                double valuePerHour1 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Duration (hours): ");
                TimeSpan t1 = TimeSpan.Parse(Console.ReadLine());
            }
            

            Console.Write($"Enter month and year to calculate income (MM/YYYY): ");
            DateTime d4 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"Name: {w1.Name}");
            Console.WriteLine($"Department: {department.Name}");
            Console.WriteLine($"Income for {d4}: {}");
        }
    }
}
