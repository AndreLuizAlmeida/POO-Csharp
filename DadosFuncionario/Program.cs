using System;

namespace DadosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario();

            Console.WriteLine("Insira os dados do funcionario: ");
            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: "+ F);

            Console.Write("Digite uma porcentagem para aumentar o salário: ");
            double Porcent = double.Parse(Console.ReadLine());
            F.Porcentagem(Porcent);
            Console.WriteLine("\n Dados atualizados: "+F);
        }
    }
}
