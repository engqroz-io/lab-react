namespace abstract_factory;

public class ZergBaseFactory : IBaseFactory
{
    public ZergBaseFactory()
    {
        CreateBase();
    }
    
    public void CreateBase()
    {
        Console.WriteLine("Building Zerg Base...");
        
        ZergBaseCoating coating = new();
        ZergBaseEnergy energy = new();
        
        coating.Composition();
        energy.Composition();

        Console.WriteLine("Zerg Base built successfully!");
    }
}
