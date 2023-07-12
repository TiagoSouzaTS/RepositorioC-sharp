using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Project4.Entities.Enums;

namespace Project4.Entities {
    internal class Circle : Shape {

        public double Radius { get; set; }

       
        public Circle(double radius, Coloor color) : base(color) {

            Radius = radius;
        }

        public override double Area() {

            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
