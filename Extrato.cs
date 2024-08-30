namespace Conta_Bancaria;

public class Extrato
{
    public DateTime Data { get; set; }
    public string Descricao { get; set; }
    public double Valor { get; set; }

    public Extrato(DateTime data, string descricao, double valor)
    {
        Data = data;
        Descricao = descricao;
        Valor = valor;

    }
}