namespace ConversorDeMoeda;

public class Conversor
{
    public static double IOF = 6;

    public static double DolarParaReal(double quantia, double cotacao)
    {
        double total = quantia * cotacao;
        return total + total * IOF / 100;
    }
}