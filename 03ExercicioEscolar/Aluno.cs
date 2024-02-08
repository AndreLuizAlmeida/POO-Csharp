using System;

class Aluno
{

    //Atributos
    public string nome;
    public double nota1, nota2;

    //Media
    public double media()
    {
        return (nota1 + nota2)/2;
    }
    //Situação
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }
    //mensagem
    public void mensagem()
    {
        //obter a media
        double obterMedia = media();
        //obter situação
        string obterSituacao = situacao(obterMedia);
        //mensagem
        Console.WriteLine(nome+" está "+obterSituacao+" com média "+obterMedia);
    }
}