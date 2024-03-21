namespace EstoqueProdutos;

public class Produto
{
   public string Nome;
   public double Preco;
   public int Quantidade;

   public Produto(string nome, double preco, int quantidade)
   {
       Nome = nome;
       Preco = preco;
       Quantidade = quantidade;
   }
   public double ValorTotal()
   {
       return Quantidade * Preco;
   }

   public void AdicionarProdutos(int quantidade)
   {
       Quantidade += quantidade;
   }

   public void RemoverProdutos(int quantidade)
   {
       Quantidade -= quantidade;
   }

   public override string ToString()
   {
       return Nome + " , $ " + Preco + " , " + Quantidade + " unidades" + " , Valor total: $"+ValorTotal();
   }
}