using System;
using System.IO;
using System.Collections.Generic;
using Project12.Entities;

namespace Project12 {
    internal class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\jiraya\Documents\myfolder\file1.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); //método para ordenar a lista.
                    foreach (Employee emp in list) {
                        Console.WriteLine($"{emp}");
                    }
                }
            }
            catch (IOException apelido){
                Console.WriteLine($"An error occurred");
                Console.WriteLine($"{apelido.Message}");
            }
        }
    }
}
