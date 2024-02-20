using System;

class PessoaFisica : Padrao
{
    //Metodo obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        System.Console.WriteLine("Taxa emprestimo para pessoa física R$"+(valor*0.1));
    }
}