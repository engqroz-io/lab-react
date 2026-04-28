namespace abstract_factory;

public class TerranBaseEnergy: IEnergy
{
    public void Composition()
    {
        Console.WriteLine("Terran Base Energy: Energy composition based on fossil fuels and nuclear energy.");
    }
}
