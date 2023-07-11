﻿using Project1.Entities;
using System;
using System.Globalization;
using System.Runtime.InteropServices;


namespace Project1 {
 
    class Program {
        static void Main(string[] args) {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            BusinessAccount acc4 = (BusinessAccount)acc2;
            if (acc3 is BusinessAccount) {

                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine($"Loan!");
            }

            if (acc3 is SavingsAccount) {

                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine($"Update!");
            }
            

        }
    }
}
