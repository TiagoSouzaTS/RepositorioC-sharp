using Project1.Entities;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Collections.Generic;


namespace Project1 {
 
    class Program {
        static void Main(string[] args) {

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));

            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));

            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));

            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));
            double sum = 0.0;

            foreach(Account account in list) {

                sum += account.Balance;
            }
            Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
