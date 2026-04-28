namespace Banco.Domain;

public class ContaPoupanca : Conta
{
    public override void Creditar(double value)
    {
        Saldo += value;
    }

    public override void Debitar(double value)
    {
        if (Saldo >= value)
            Saldo -= value;
        else
            Console.WriteLine("Não há saldo para debitar!");
    }
}
