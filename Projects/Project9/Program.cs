using Project9.Entities;
using System.Globalization;
using System;

namespace Project9 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine($"Enter rental data");
            Console.Write($"Car model: ");
            string modelCar = Console.ReadLine();
            Console.Write($"Pickup (dd/MM/yyyy hh:mm): ");
            DateTime inicio = Convert.ToDateTime(Console.ReadLine());
            Console.Write($"Return (dd/MM/yyyy hh:mm): ");
            DateTime final = Convert.ToDateTime(Console.ReadLine());
            Console.Write($"Enter price per hour: ");
            double pricePerHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Enter price per day: ");
            double pricePerDay = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Locacao l1 = new Locacao(modelCar, inicio, final, pricePerHour, pricePerDay);
            Console.WriteLine($"INVOICE: ");

            double basicPayment = l1.BasicPayment(inicio, final);
            Console.WriteLine($"Basic Payment: {basicPayment.ToString("F2", CultureInfo.InvariantCulture)}");

            double tax = l1.CalculoImposto(basicPayment);
            Console.WriteLine($"Tax: {tax.ToString("F2", CultureInfo.InvariantCulture)}");
            
            double totalPayment = l1.TotalPayment(basicPayment, tax);
            Console.WriteLine($"Total payment: {totalPayment.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
