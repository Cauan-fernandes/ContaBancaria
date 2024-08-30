using Conta_Bancaria;

class ContaBancaria
{
  protected string _proprietary;
  protected string _id;
  protected double saldo;
  protected List<Extrato> movimentacoes;
  

  public ContaBancaria(string proprietary, string _id, double saldo)
  {
    _proprietary = proprietary;
    this._id = _id;
    this.saldo = saldo;
    movimentacoes = new List<Extrato>();
  }

  public void Deposit(double vlr)
  {
    if (vlr > 0)
    {
      saldo += vlr;
      AdicionarMovimetacao("Deposito", vlr);
      Console.WriteLine($"Deposito feito com sucesso");
      Console.WriteLine($"Novo saldo: {saldo}");
    }
    else
    {
      Console.WriteLine("Valor do deposito invalido");
    }
  }

  public void Sacar(double vlr)
  {
    if (vlr > 0 && vlr <= saldo)
    {
      saldo -= vlr;
      AdicionarMovimetacao("saque", -vlr);
      Console.WriteLine($"Saque feito com sucesso");
      Console.WriteLine($"Novo saldo: {saldo}");
    }
    else
    {
      Console.WriteLine("Valor do saque invalido ou saldo insuficiente");
    }
  }

  public void verSaldo()
  {
    Console.WriteLine($"Saldo da conta: {saldo}");
  }

  private void AdicionarMovimetacao(string descricao, double valor)
  {
    movimentacoes.Add(new Extrato(DateTime.Now, descricao, valor));
  }

  public void verExtrato()
  {
    Console.WriteLine("Extrato de movimentações");
    foreach (var movimentacao in movimentacoes)
    {
      Console.WriteLine($"{movimentacao.Data} - {movimentacao.Descricao} - {movimentacao.Valor}");
    }
  }

  public string getproprietary() { return _proprietary; }
  public string getId() { return _id; }
  public double getSaldo() { return saldo; }

}