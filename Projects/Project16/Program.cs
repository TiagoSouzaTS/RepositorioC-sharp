using System;
using System.Collections.Generic;
using System.IO;
using Project16.Entities;

namespace Project16 {
    internal class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();


            Console.WriteLine($"Enter file full path: ");
            string path = @"C:\Users\jiraya\Documents\myfolder\file2.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant});

                    }
                    Console.WriteLine($"Total users: {set.Count}");
                }
            }
            catch (IOException apelido) {

                Console.WriteLine(apelido.Message);
            }
        }
    }
}
