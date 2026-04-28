using abstract_factory;

Dictionary<string, string> races = new()
{
    {"1", "Zerg"},
    {"2", "Terran"},
    {"3", "Protoss"}
};

Console.WriteLine("Choose the race to create the base:");
foreach (var race in races)
{
    Console.WriteLine($"{race.Key} - {race.Value}");
}

string? choice = Console.ReadLine();
if (string.IsNullOrEmpty(choice) || !races.TryGetValue(choice, out _))
{
    Console.WriteLine("Invalid race. Please choose a valid option.");
    return;
}

switch (choice)
{
    case "1":
        IBaseFactory zergFactory = new ZergBaseFactory();
        break;
    case "2":
        IBaseFactory terranFactory = new TerranBaseFactory();
        break;
    case "3":
        IBaseFactory protossFactory = new ProtossBaseFactory();
        break;
    default:
        Console.WriteLine("Invalid option. Please choose a valid option.");
        break;
}

Console.ReadKey();