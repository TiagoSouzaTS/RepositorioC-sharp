using System;
using System.Globalization;
using System.Linq;

namespace Project2 {

    class Program {
        // Exemplo de programa que mostra os dados de um produto, adiciona, remove e mostra os dados sempre atualizados com POO. 
        static void Main(string[] args) {

            Console.WriteLine($"Entre os dados do produto: ");
            Console.Write($"Nome: ");
            string nome = Console.ReadLine();
            Console.Write($"Preço: ");
            double preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Produto p1 = new Produto();

            double Total = p1.ValorTotalEmEstoque();

            Console.WriteLine($"{p1} {Total.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.Write($"Digite o número de produtos a ser adicionado ao estoque: ");

            p1.AdicionarProdutos();
            Total = p1.ValorTotalEmEstoque();

            Console.WriteLine($"{p1} {Total.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.Write($"Digite o número de produtos a ser removido do estoque: ");

            p1.RemoverProdutos();
            Total = p1.ValorTotalEmEstoque();

            Console.WriteLine($"{p1} {Total.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
