using System.Globalization;
namespace Project9.Entities {
    internal class Invoice {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
       
        public Invoice(double basicPayment, double tax) {

            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment { //propriedade calculada, no get não retorna o valor total de pagamento, ela calcula o valor total de pagamento.

            get { return BasicPayment + Tax; }
        }

        public override string ToString() {

            return $"BasicPayment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}\nTotal payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
