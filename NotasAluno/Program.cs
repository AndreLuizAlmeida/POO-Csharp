using System;
using System.Globalization;

namespace NotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados Aluno = new Dados();

            Console.Write("Insira o nome do aluno: ");
            Aluno.Nome = Console.ReadLine();
            Console.Write("Insira a primeira nota: ");
            Aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Insira a segunda nota: ");
            Aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Insira a terceira nota: ");
            Aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final = " + Aluno.Notafinal());

            if (Aluno.Notafinal() < 60)
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("Faltaram " + Aluno.Reprovado() + "pontos");
            }
            else
            {
                Console.WriteLine("APROVADO!");
            }
            
            
        }
    }
}

