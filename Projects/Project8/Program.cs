using System;
using System.IO;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace Project8 {
    internal class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\jiraya\Documents\myfolder"; //utilizado um @ para poder colocar só uma \ para o caminho. 
            
            try {

                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine($"FOLDERS: ");
                foreach ( string item in folders ) {
                    Console.WriteLine(item);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine($"FILES: ");
                foreach (string item in files) {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + @"\newfolder");
                Directory.CreateDirectory(@"C:\Users\jiraya\Documents\myfolder\newfolder");
            }
            catch (IOException apelido) {
                Console.WriteLine($"An error ocurred");
                Console.WriteLine(apelido.Message);
            }
        }
    }
}
