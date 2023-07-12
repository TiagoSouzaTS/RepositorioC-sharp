using System;
using System.Collections.Generic;
using System.Text;
using Project4.Entities.Enums;

namespace Project4.Entities {
    internal class Rectangle : Shape {

        public double Width { get; set; }
        public double Height { get; set; }

        
        public Rectangle(double width, double height, Coloor color) : base(color) {

            Width = width;
            Height = height;

        }

        public override double Area() {
            
            return Width * Height;
        }
    }
}
