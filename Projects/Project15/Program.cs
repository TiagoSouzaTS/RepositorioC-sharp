using System;
using Project15.Entities;
namespace Project15 {
    internal class Program {
        static void Main(string[] args) {

            Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com"};
            Console.WriteLine(a.Equals(b)); // Vai dar True
            Console.WriteLine(a == b); // Vai dar False
            Console.WriteLine(a.GetHashCode()); // vai dar o mesmo código.
            Console.WriteLine(b.GetHashCode());
        }
    }
}
