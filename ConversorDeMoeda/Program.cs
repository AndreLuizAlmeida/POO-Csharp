using System;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares você vai comprar: ");
            double quantia = double.Parse(Console.ReadLine());

            double result = Conversor.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valo pago em reais: "+result);
        }
    }
}

