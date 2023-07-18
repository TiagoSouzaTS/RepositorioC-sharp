﻿using System;
using Project9.Entities;

namespace Project9.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay) {

            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental) {

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment;
            if (duration.TotalHours <= 12) {

                basicPayment = Math.Ceiling(duration.TotalHours) * PricePerHour;
            } else {

                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}