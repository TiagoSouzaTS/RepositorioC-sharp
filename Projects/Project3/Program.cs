using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Security.Cryptography;

namespace Project3
{

    class Program
    {     // Exemplo de como funciona membros estáticos. 

        static void Main(string[] args)
        {

            Console.Write($"Entre com o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"A circunferencia é: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"O volume é: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de é: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
