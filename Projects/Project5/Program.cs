using System;
using System.Collections.Generic;
using Project5.Entities;
using Project5.Entities.Enums;

namespace Project5
{
    class Program
    {    
        static void Main(string[] args)
        {
;           Order order = new Order {Id = 1080, Moment =  DateTime.Now, Status = OrderStatus.PendingPayment};

            Console.WriteLine($"{order}");

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine($"{txt}");
            Console.WriteLine($"{os}");
        }
    }
}
