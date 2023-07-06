using System;
using Project5.Entities.Enums;

namespace Project5.Entities {
    internal class Order {

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {

            return ($"{Id}, {Moment}, {Status}");
        }
    }
}
