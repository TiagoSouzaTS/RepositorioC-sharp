using Project14.Entities;
using Project14.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Project14 {
    internal class Program {
        static void Main(string[] args) {

           List<Product> list = new List<Product>();

            Console.Write($"Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = Convert.ToDouble(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine($"Max: {max}");
        }
    }
}
