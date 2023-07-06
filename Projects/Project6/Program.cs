using System;
using System.Globalization;

namespace Project6 {
    class Program {

        static double Pi = 3.14;

        static void Main(string[] args) {

            Console.Write($"Entre com o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"A circunferencia é: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"O volume é: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de é: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double Circunferencia(double r) {

            return 2.0 * Pi * r;
        }

        static double Volume(double r) {

            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
