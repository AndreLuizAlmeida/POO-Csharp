using System;

namespace DadosSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario A = new Funcionario();
            Funcionario B = new Funcionario();

            Console.WriteLine("Insira o nome do primeiro funcionario:");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Insira o salário desse funcionario:");
            A.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome do segundo funcionario:");
            B.Nome = Console.ReadLine();
            Console.WriteLine("Insira o salário desse funcionario:");
            B.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.WriteLine("Nome: "+A.Nome + " | Salário: "+ A.Salario);
            Console.WriteLine("Dados  do segundo funcionario:");
            Console.WriteLine("Nome: "+B.Nome + " | Salário: "+ B.Salario);
            Console.WriteLine("Salário médio: " + (A.Salario + B.Salario)/2);
        }
    }
}
