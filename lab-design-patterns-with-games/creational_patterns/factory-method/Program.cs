using factory;

Dictionary<int, string> personagens = new Dictionary<int, string>
{
    { 1, "Liu Kang" },
    { 2, "SubZero" },
    { 3, "Scorpion" },
    { 4, "Raiden" }
};

foreach (var personagem in personagens)
{
    Console.WriteLine($"{personagem.Key} - {personagem.Value}");
}

string? escolha = Console.ReadLine();

if (string.IsNullOrEmpty(escolha) || !personagens.ContainsKey(int.Parse(escolha)))
{
    Console.WriteLine("Entrada inválida! Por favor, insira um número.");
    return;
}

FactoryMethod factory = new FactoryMethod();
factory.ChooseCharacter(personagens[int.Parse(escolha)]).Chosen();