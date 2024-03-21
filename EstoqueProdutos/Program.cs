using System;

namespace EstoqueProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total;

            Console.WriteLine("Insira os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto X = new Produto(nome,preco,quantidade);
            
            Console.WriteLine("Dados do produto: " + X);
            Console.Write("Insira a quantidade de produtos a ser adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            X.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + X);
            Console.Write("Insira a quantidade de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            X.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + X);
            
        }    
    }
    
}