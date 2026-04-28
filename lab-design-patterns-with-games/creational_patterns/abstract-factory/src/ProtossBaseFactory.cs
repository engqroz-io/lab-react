namespace abstract_factory;

public class ProtossBaseFactory : IBaseFactory
{
    public ProtossBaseFactory()
    {
        CreateBase();
    }
    public void CreateBase()
    {
        Console.WriteLine("Building Protoss Base...");

        ProtossBaseCoating coating = new();
        coating.Composition();
        ProtossBaseEnergy energy = new();
        energy.Composition();

        Console.WriteLine("Protoss Base built successfully!");
    }
}
