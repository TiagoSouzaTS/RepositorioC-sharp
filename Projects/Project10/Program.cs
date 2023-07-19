using System;
using Project10.Model.Entities;
using Project10.Model.Enums;

namespace Project10 {
    internal class Program {
        static void Main(string[] args) {

            IShape s1 = new Circle() { Radius = 2.0, Color = Coloor.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Coloor.Black };

            Console.WriteLine($"{s1}");
            Console.WriteLine($"{s2}");
        }
    }
}
