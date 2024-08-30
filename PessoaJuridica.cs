class PessoaJuridica : ContaBancaria
{
  private string cnpj;
  public PessoaJuridica(string proprietary, string _id, double saldo, string cnpj) : base(proprietary, _id, saldo)
  {
    this.cnpj = cnpj;
  }

  public void ExibirDados()
  {
    Console.WriteLine("## Dados do proprietario ##");
    Console.WriteLine($"Nome: {getproprietary()}");
    Console.WriteLine($"ID: {getId()}");
    Console.WriteLine($"Saldo: {getSaldo()}");
    Console.WriteLine($"CNPJ: {cnpj}");
  }
  public string getCnpj() { return cnpj; }
}