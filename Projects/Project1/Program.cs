using System;
using System.Globalization;
using System.Runtime.InteropServices;


namespace Project1 {
 // Exemplo de programa que verifica os lados de dois triângulos, cálcula área de ambos e diz qual dos dois tem a maior área ou se são iguais, utilizando POO.
    class Program {
        static void Main(string[] args) {

            Triangulo n1 = new Triangulo();
            Triangulo n2 = new Triangulo();

            Console.WriteLine("Entre com as medidas primeiro triângulo: ");
            Console.Write("Primeira medida: ");
            n1.A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segunda medida: ");
            n1.B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Terceira medida: ");
            n1.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"--------------------------------------------");

            Console.WriteLine("Entre com as medidas do segundo triângulo: ");
            Console.Write("Primeira medida: ");
            n2.A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segunda medida: ");
            n2.B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Terceira medida: ");
            n2.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"--------------------------------------------");

            double areaX = n1.Area();
            double areaY = n2.Area();

            Console.WriteLine($"{areaX}");
            Console.WriteLine($"{areaY}");


        }
    }
}
