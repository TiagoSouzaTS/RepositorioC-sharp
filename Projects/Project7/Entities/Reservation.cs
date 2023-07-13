using System;
using Project7.Entities.Exceptions;

namespace Project7.Entities {
    internal class Reservation {

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {

            DateTime now = DateTime.Now;

            if (CheckIn < now || checkOut < now) {

                throw new DomainException("Reservation dates for must be future dates");

            }
            if (checkOut <= checkIn) {

                throw new DomainException("Check-out date must be after ");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() {

            TimeSpan duration = CheckOut.Subtract(CheckIn); //pegando a diferença da data de saída para a data de entrada.

            return (int)duration.TotalDays; // retornando a diferença em dias, como duration é um double foi necessário realizar um casting. 
        }

        public void UpdateDates(DateTime chekIn, DateTime checkOut) {

            DateTime now = DateTime.Now;

            if (CheckIn < now || checkOut < now) {

                throw new DomainException("Reservation dates for update must be future dates");

            } 
            if (checkOut <= CheckIn) {

                throw new DomainException("Check-out for update must be after");
            }

            CheckIn = chekIn;
            CheckOut = checkOut;
        }

        public override string ToString() {

            return ($"Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights");
        }
    }
}
