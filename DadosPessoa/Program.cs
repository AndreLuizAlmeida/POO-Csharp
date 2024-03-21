using System;

namespace DadosPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A = new Pessoa();
            Pessoa B = new Pessoa();

            Console.WriteLine("Insira o nome da primeira pessoa");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Insira a idade da primeira pessoa");
            A.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome da segunda pessoa");
            B.Nome = Console.ReadLine();
            Console.WriteLine("Insira a idade da segunda pessoa");
            B.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados a primeira pessoa:");
            Console.WriteLine("Nome: "+A.Nome);
            Console.WriteLine("Idade: "+A.Idade);
            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: "+B.Nome);
            Console.WriteLine("Idade: "+B.Idade);
            if (A.Idade > B.Idade)
            {
                Console.WriteLine("A pessoa mais velha é "+A.Nome);
            }
            else if (A.Idade == B.Idade)
            {
                Console.WriteLine(A.Nome + " e "+B.Nome + " tem a mesma idade");
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é "+B.Idade);
            }
        }
    }
}

