namespace builder;

public class Exercito
{
    public void ConstruirSoldado(CriadorDeSoldado criador)
    {
        criador.Arma();
        criador.Transporte();
        criador.Foco();
    }
}
