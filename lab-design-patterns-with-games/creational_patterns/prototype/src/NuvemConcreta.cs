namespace prototype;

public class NuvemConcreta: NuvemMolde
{
    private string cor_preenchimento;
    private string cor_contorno;
    public NuvemConcreta(string cor_preenchimento, string cor_contorno)
    {
        this.cor_preenchimento = cor_preenchimento;
        this.cor_contorno = cor_contorno;
    }
    public override NuvemMolde Clone()
    {
        Console.WriteLine("A nuvem clonada tem contorno {0} e preenchimento {1}", this.cor_contorno, this.cor_preenchimento);

        return this.MemberwiseClone() as NuvemMolde;
    }
}
