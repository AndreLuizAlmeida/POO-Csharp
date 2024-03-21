namespace DadosRetangulo;

public class Dados
{
    public double Lado;
    public double Altura;

    public double Area()
    {
        return Lado * Altura;
    }

    public double Perimetro()
    {
        return 2 * Lado + 2 * Altura;
    }

    public double Diagonal()
    {
        return Math.Sqrt(Lado * Lado + Altura * Altura);
    }
}