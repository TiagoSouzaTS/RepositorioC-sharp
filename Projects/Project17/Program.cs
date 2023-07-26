using System;
using System.Collections.Generic;

namespace Project17 {
    internal class Program {
        static void Main(string[] args) {

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            cookies["user"] = "99771133";

            Console.WriteLine($"{cookies["email"]}");

            cookies.Remove("email");

            Console.WriteLine($"Phone number: {cookies["phone"]}");

            if (cookies.ContainsKey("email")) {
                Console.WriteLine($"Email: {cookies["cookies"]}");
            }
            else {
                Console.WriteLine($"There is not 'email' key");
            }

            Console.WriteLine($"Size: {cookies.Count}");

            Console.WriteLine($"ALL COOKIES: ");

            foreach (KeyValuePair<string, string> apelido in cookies) {

                Console.WriteLine($"{apelido.Key}: {apelido.Value}");
            }
        }
    }
}
