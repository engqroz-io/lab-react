namespace Banco.Domain;

public class ContaCorrente: Conta
{
    private Double Encargos { get; set; }

    public void SetEncargos(Double value)
    {
        Encargos = value;
    }

    public override void Debitar(Double value)
    {
        value += Encargos;

        if (Saldo >= value)
            Saldo -= value;
        else
            Console.WriteLine("Não há saldo para debitar!");
    }

    public override void Creditar(Double value)
    {
        Saldo += value;
    }
    
}
