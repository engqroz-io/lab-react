namespace singleton;

public sealed class Singleton
{
    private static Singleton? _instance;
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
            Console.WriteLine("Bola em jogo");
        }

        return _instance;
    }

    public void Mensagem(string msg)
    {
        Console.WriteLine(msg);
    }
}
