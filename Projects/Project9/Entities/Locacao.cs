using System;
using System.Collections.Generic;
using System.Text;

namespace Project9.Entities {
    internal class Locacao {

        public string Modelo { get; set; }
        public DateTime Inicial { get; set; }
        public DateTime Final { get; set; }
        public double ValuePerHour { get; set; }
        public double ValuePerDay { get; set; }

        public Locacao() { 
        
        }

        public Locacao(string modelo, DateTime inicial, DateTime final, double valuePerHour, double valuePerDay) {
            Modelo = modelo;
            Inicial = inicial;
            Final = final;
            ValuePerHour = valuePerHour;
            ValuePerDay = valuePerDay;
        }

        public double BasicPayment(DateTime inicial, DateTime final) {

            TimeSpan t1 = final.Subtract(inicial);
            if (t1.Hours <= 12 && t1.Days == 0) {

                return t1.Hours * ValuePerHour;
            }
            else {
                return t1.Days * ValuePerDay;
            }
        }

        public double CalculoImposto(double valorTotal) {

            if (valorTotal <= 100.00) {

                return (valorTotal * 20) / 100;
            }
            else {

                return (valorTotal * 15) / 100;
            }
        }

        public double TotalPayment(double basicPayment, double calculoImposto) {

            return basicPayment + calculoImposto;
        }
    }
}
