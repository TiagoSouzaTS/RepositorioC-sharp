﻿using System;
using Project11.Devices;

namespace Project11 {
    internal class Program {
        static void Main(string[] args) {

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Console.WriteLine($"----------------------------------");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            Console.WriteLine($"----------------------------------");

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc($"My dissertation");
            c.Print($"My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
