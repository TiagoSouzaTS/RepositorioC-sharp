using Project9.Entities;
using System.Globalization;
using System;
using Project9.Services;

namespace Project9 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine($"Enter rental data");
            Console.Write($"Car model: ");
            Vehicle modelCar = new Vehicle(Console.ReadLine());
            Console.Write($"Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write($"Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental c1 = new CarRental(start, finish, modelCar);

            Console.Write($"Enter price per Hour: ");
            double hour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Enter price per Day: ");
            double day = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalService r1 = new RentalService(hour, day);

            r1.ProcessInvoice(c1);

            Console.WriteLine($"INVOICE: ");
            Console.WriteLine($"{c1.Invoice}");
        }
    }
}
