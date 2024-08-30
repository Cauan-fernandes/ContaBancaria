class PessoaFisica : ContaBancaria
{
  private string cpf;
  public PessoaFisica(string proprietary, string _id, double saldo, string cpf) : base(proprietary, _id, saldo)
  {
    this.cpf = cpf;
  }

  public void ExibirDados()
  {
    Console.WriteLine("## Dados do proprietario ##");
    Console.WriteLine($"Nome: {getproprietary()}");
    Console.WriteLine($"ID: {getId()}");
    Console.WriteLine($"Saldo: {getSaldo()}");
    Console.WriteLine($"CPF: {cpf}");
  }
}