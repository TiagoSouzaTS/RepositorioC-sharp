using System;
using System.IO;
using System.Net.WebSockets;

namespace Project8 {
    internal class Program {
        static void Main(string[] args) {

            string sourcePath = @"C:\Users\jiraya\Documents\file1.txt"; //utilizado um @ para poder colocar só uma \ para o caminho. 
            string targetPath = @"C:\Users\jiraya\Documents\file2.txt";

            try {

                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) {

                    foreach (string line in lines) {

                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException apelido) {
                Console.WriteLine($"An error ocurred");
                Console.WriteLine(apelido.Message);
            }
        }
    }
}
