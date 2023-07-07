using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace Project2
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() {

        }

        public Produto(string nome, double preco, int quantidade) {
            
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }

            set {
                if (value != null && value.Length > 0) {
                    _nome = value;
                }
                else {

                    Console.WriteLine($"Não é possível alterar o nome do produto. Digite uma palavra com letras.");
                }

            }
        }

        public double ValorTotalEmEstoque() {

            return Quantidade * Preco;
        }

        public void AdicionarProdutos() {

           Quantidade += Convert.ToInt32(Console.ReadLine());

        }

        public void RemoverProdutos() {

            Quantidade -= Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString() {

            return ($"Dados do produto: {_nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $");
        }

    }
}
