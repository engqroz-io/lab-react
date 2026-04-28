namespace builder;

public class CriadorDeInfantariaLeve: CriadorDeSoldado
{
    public CriadorDeInfantariaLeve()
    {
        _soldado = new SoldadoDeInfantariaLeve();
    }
    public override void Arma()
    {
        _soldado.EscolherArma("Rifle de assalto leve");
    }

    public override void Transporte()
    {
        _soldado.EscolherTransporte("Veículo leve de transporte");
    }

    public override void Foco()
    {
        _soldado.EscolherFoco("Mobilidade e rapidez");
    }
}
