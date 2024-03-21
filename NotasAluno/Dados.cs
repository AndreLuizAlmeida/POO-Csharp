namespace NotasAluno;

public class Dados
{
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double Notafinal()
    {
        return Nota1 + Nota2 + Nota3;
    }

    public double Reprovado()
    {
        return 60 - Notafinal();
    }
}