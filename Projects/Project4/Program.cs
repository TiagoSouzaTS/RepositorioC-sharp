using Project4.Entities.Enums;
using System;
using Project4.Entities;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Transactions;
using System.Collections.Generic;

namespace Project4
{
    class Program
    {   
        static void Main(string[] args)
        {

            Console.Write($"Enter the number of shapes: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            List<Shape> shape = new List<Shape>();

            for (int i = 1; i <= n1; i++) {

                Console.WriteLine($"Shape #{i} data: ");
                Console.Write($"Rectangle or Circle (r/c)? ");
                char RecOuCir = Convert.ToChar(Console.ReadLine());

                if (RecOuCir == 'r') {

                    Console.Write($"Color (Black/Blue/Red): ");
                    Coloor color = Enum.Parse<Coloor>(Console.ReadLine());
                    Console.Write($"Width: ");
                    double width = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write($"Height: ");
                    double height = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shape.Add(new Rectangle(width, height, color));

                } else {

                    Console.Write($"Color (Black/Blue/Red): ");
                    Coloor color = Enum.Parse<Coloor>(Console.ReadLine());
                    Console.Write($"Radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shape.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine($"Shape Areas: ");
            foreach (Shape obj in shape) {

                double area = obj.Area();
                Console.WriteLine($"{area.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
