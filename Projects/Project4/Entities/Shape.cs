using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Drawing;
using Project4.Entities.Enums;

namespace Project4.Entities
{
    abstract class Shape {

        public Coloor Color { get; set; }

        public Shape() {


        }
        
        public Shape(Coloor color) {

            Color = new Coloor();
        }

        public abstract double Area();
    }
}
