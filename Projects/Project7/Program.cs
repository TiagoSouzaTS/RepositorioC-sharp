using System;

namespace Project7 {
    class Program {

        static void Main(string[] args) {

            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine($"{result}");
            } catch (DivideByZeroException apelido) {

                Console.WriteLine($"Error! {apelido.Message}");

            } catch (FormatException apelido2) {

                Console.WriteLine($"Format error {apelido2.Message}");
            }
            

        }  
    }
}
