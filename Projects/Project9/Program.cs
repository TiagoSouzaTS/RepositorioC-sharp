using Project9.Entities;
using System.Globalization;
using System;

namespace Project9 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine($"Enter rental data");
            Console.Write($"Car model: ");
            Vehicle modelCar = new Vehicle(Console.ReadLine());
            Console.Write($"Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = Convert.ToDateTime(Console.ReadLine());
            Console.Write($"Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = Convert.ToDateTime(Console.ReadLine());

            CarRental c1 = new CarRental(start, finish, modelCar);


        }
    }
}
