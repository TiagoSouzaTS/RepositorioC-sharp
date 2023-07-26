using System;
using Project18.Extensions;

namespace Project18 {
    internal class Program {
        static void Main(string[] args) {

            DateTime dt = new DateTime(2023, 07, 26, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime()); // Método de extensão do struct DateTime. 
        }
    }
}
