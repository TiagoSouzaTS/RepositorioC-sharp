using System;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Transactions;

namespace Project4
{
    class Program
    {   
        static void Main(string[] args)
        {
            char resultadoDepositoInicial = 'n';
            double depositoInicial = 0;
            Console.Write($"Digite o nome do Titular da conta: ");
            string nome = (Console.ReadLine());
            Console.Write($"Digite o número da conta: ");
            int numeroConta = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Você deseja realizar um deposito inicial S/N? ");
            resultadoDepositoInicial = Convert.ToChar(Console.ReadLine());
            

            if (resultadoDepositoInicial == 's' || resultadoDepositoInicial == 'S') {

                Console.Write($"Qual a quantidade que deseja depositar inicialmente? ");
                depositoInicial = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                
            } else {
                Console.WriteLine($"Tudo bem, sua conta poderá ser aberta sem um depósito inicial.");
            }

            ContaBancaria c1 = new ContaBancaria(numeroConta, nome, depositoInicial);

            Console.WriteLine($"{c1}");

            Console.Write($"Digite o valor de depósito que deseja realizar: ");
            double deposito = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            c1.Deposito(deposito);

            Console.WriteLine($"{c1}");

            Console.Write($"Digite o valor de saque que deseja realizar: ");
            double saque = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            c1.Saque(saque);

            Console.WriteLine($"{c1}");



        }
    }
}
