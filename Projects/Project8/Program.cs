using System;
using System.IO;

namespace Project8 {
    internal class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\jiraya\Documents\file1.txt"; //utilizado um @ para poder colocar só uma \ para o caminho. 

            
            StreamReader sr = null;

            try {
                
                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine($"{line}");
                }
            } catch (IOException apelido) {

                Console.WriteLine($"An error accurred");
                Console.WriteLine($"{apelido.Message}");
            }
            finally {

                if (sr != null) sr.Close();
                
                
            }
        }
    }
}
