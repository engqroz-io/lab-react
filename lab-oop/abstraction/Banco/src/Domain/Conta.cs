namespace Banco.Domain;

public abstract class Conta
{
    protected Double Saldo { get; set; }
    public abstract void Debitar(Double value);
    public abstract void Creditar(Double value);
    public void ExibirSaldo()
    {
        Console.WriteLine($"O saldo na sua conta é de {Saldo:F2}€");
    }
}
