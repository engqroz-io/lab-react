namespace builder;

public class CriadorDeForcasEspeciais: CriadorDeSoldado
{
    public CriadorDeForcasEspeciais()
    {
        _soldado = new SoldadoDeForcasEspeciais();
    }
    public override void Arma()
    {
        _soldado.EscolherArma("Rifle de assalto avançado");
    }

    public override void Transporte()
    {
        _soldado.EscolherTransporte("Veículo blindado de transporte");
    }

    public override void Foco()
    {
        _soldado.EscolherFoco("Versatilidade e resistência");
    }
}
