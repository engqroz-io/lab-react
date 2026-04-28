namespace abstract_factory;

public class TerranBaseFactory : IBaseFactory
{
    public TerranBaseFactory()
    {
        CreateBase();
    }

    public void CreateBase()
    {
        Console.WriteLine("Building Terran Base...");

        TerranBaseCoating coating = new();
        coating .Composition();

        TerranBaseEnergy energia = new();
        energia.Composition();

        Console.WriteLine("Terran Base built successfully!");
    }
}
