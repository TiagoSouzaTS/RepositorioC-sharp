using System;
using System.IO;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace Project8 {
    internal class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\jiraya\Documents\myfolder\file1.txt"; //utilizado um @ para poder colocar só uma \ para o caminho. 

            try {

                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                Console.WriteLine("GetExtension: " + Path.GetExtension(path));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            }
            catch (IOException apelido) {
                Console.WriteLine($"An error ocurred");
                Console.WriteLine(apelido.Message);
            }
        }
    }
}
