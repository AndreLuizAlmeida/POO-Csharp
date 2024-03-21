using System;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X = new Triangulo();
            Triangulo Y = new Triangulo();
            
            Console.WriteLine("Insira o valor dos lados do triangulo X:");
            X.A = double.Parse(Console.ReadLine());
            X.B = double.Parse(Console.ReadLine());
            X.C = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor dos lados do triangulo Y");
            Y.A = double.Parse(Console.ReadLine());
            Y.B = double.Parse(Console.ReadLine());
            Y.C = double.Parse(Console.ReadLine());

            double AreaX = X.Area();
            double AreaY = Y.Area();
            
            Console.WriteLine("O valor da área de X é " + AreaX);
            Console.WriteLine("O valor da área de Y é " + AreaY);

        }
    }
}

