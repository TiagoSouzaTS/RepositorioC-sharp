using Project7.Entities;
using System;
using Project7.Entities.Exceptions;

namespace Project7 {
    class Program {

        static void Main(string[] args) {

            try {

                Console.Write($"Room number: ");
                int roomNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write($"Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation r1 = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine($"{r1}");

                Console.WriteLine();

                Console.WriteLine($"Enter data to update the reservation: ");
                Console.Write($"Check-in date (dd/MM/yyyy): ");
                DateTime checkInUpdate = DateTime.Parse(Console.ReadLine());
                Console.Write($"Check-out date (dd/MM/yyyy): ");
                DateTime checkOutUpdate = DateTime.Parse(Console.ReadLine());

                r1.UpdateDates(checkInUpdate, checkOutUpdate);

                Console.WriteLine();

                Console.WriteLine($"{r1}");

            } catch(DomainException apelido) {

                Console.WriteLine($"Error inr reservation: {apelido.Message}");
            } catch(FormatException apelido1) {

                Console.WriteLine($"Format error: {apelido1.Message}");
            } catch(Exception apelido2) {

                Console.WriteLine($"Unexpected error: {apelido2.Message}");
            } 
        }
    }
}
