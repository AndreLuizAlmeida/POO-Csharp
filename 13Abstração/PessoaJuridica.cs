using System;

class PessoaJuridica : Padrao
{
    //Metodo obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        System.Console.WriteLine("Taxa emprestimo para pessoa juridica R$"+(valor*0.2));
    }
}