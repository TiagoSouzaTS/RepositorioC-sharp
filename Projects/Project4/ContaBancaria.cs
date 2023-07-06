using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Project4
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public double DepositoInicial { get; private set; }
        public double _saldoDaConta { get; private set; }
        private string _nomeTitular;


        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial) {

            NumeroConta = numeroConta;
            _nomeTitular = nomeTitular;
            DepositoInicial = depositoInicial;
            Deposito(depositoInicial);
        }

        public string Nome {

            get { return _nomeTitular; }

            set { 

                if (value != null && value.Length > 0) {
                    _nomeTitular = value;
                }
            }
        }

        public void Deposito(double deposito) {

            _saldoDaConta += deposito;
        }

        public void Saque(double saque) {
            _saldoDaConta -= (saque + 5);
        }

        public override string ToString() {
            return ($"A conta de número: {NumeroConta} que pertence ao titular: {_nomeTitular} tem o saldo de: ${_saldoDaConta.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
