namespace DadosFuncionario;

public class Funcionario
{
   public string Nome;
   public double SalarioBruto;
   public double Imposto;

   public double SalarioLiquido()
   {
      return SalarioBruto - Imposto;
   }

   public override string ToString()
   {
      return "Nome: " + Nome +" , salario: $" + SalarioLiquido();
   }

   public void Porcentagem(double porcentagem)
   {
      SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
   }
}