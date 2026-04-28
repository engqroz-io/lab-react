namespace prototype;

public class GerenciadorNuvens
{
    private Dictionary<string, NuvemMolde> nuvens = [];
    public NuvemMolde this[string key]
    {
        get { return nuvens[key]; }
        set { nuvens.Add(key, value); }
    }
}
