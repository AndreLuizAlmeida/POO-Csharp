using System;

namespace DadosRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados Retangulo = new Dados();

            Console.Write("Insira o valor do lado do retangulo: ");
            Retangulo.Lado = double.Parse(Console.ReadLine());
            Console.Write("Insira o valor da altura do retangulo: ");
            Retangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados: Área = "+Retangulo.Area()+
                              " Perímetro = "+Retangulo.Perimetro()+
                              " Diagonal = "+Retangulo.Diagonal());
        }
    }
}

