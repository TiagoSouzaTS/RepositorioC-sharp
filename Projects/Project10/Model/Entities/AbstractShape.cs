using Project10.Model.Enums;

namespace Project10.Model.Entities {
    abstract class AbstractShape : IShape {

        public Coloor Color { get; set; }

        public abstract double Area(); //Em C# a interface obriga a implementação do contrato mesmo em uma class abstrata.
    }
}
