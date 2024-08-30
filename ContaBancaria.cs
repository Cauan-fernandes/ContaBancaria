class ContaBancaria
{
  private string _proprietary;
  private string _id;
  private double saldo;

  public ContaBancaria(string proprietary, string _id, double saldo)
  {
    _proprietary = proprietary;
    this._id = _id;
    this.saldo = saldo;
  }

  public void Deposit(double vlr)
  {
    if (vlr > 0)
    {
      saldo += vlr;
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
    if (vlr > 0 && vlr < saldo)
    {
      saldo -= vlr;
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

  public string getproprietary() { return _proprietary; }
  public string getId() { return _id; }
  public double getSaldo() { return saldo; }

}