using System;

class Pessoa
{

   // Método 01
    public void apresentar()
    {
        System.Console.WriteLine("oi");
    }
   // Método 02
    public void apresentar(string nome)
    {
        System.Console.WriteLine("oi " +nome);
    }
   // Método 03
    public void apresentar(string nome,int idade)
    {
        System.Console.WriteLine("oi " + nome +" você tem " + idade+ " anos");
    }
}