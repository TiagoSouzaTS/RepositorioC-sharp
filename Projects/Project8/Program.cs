using System;
using System.IO;

namespace Project8 {
    internal class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\jiraya\Documents\file1.txt"; //utilizado um @ para poder colocar só uma \ para o caminho. 

            FileStream fs = null; 
            StreamReader sr = null;

            try {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine($"{line}");
            } catch (IOException apelido) {

                Console.WriteLine($"An error accurred");
                Console.WriteLine($"{apelido.Message}");
            }
            finally {

                if (sr != null) sr.Close();
                if ( fs != null ) fs.Close();
                
            }
        }
    }
}
