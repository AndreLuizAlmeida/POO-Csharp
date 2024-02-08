using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "André";
            a.nota1 = 3;
            a.nota2 = 10;
            a.mensagem();

        }
    }
}