namespace factory;

public class FactoryMethod
{
    public ICharacter ChooseCharacter(string character)
    {
        switch (character)
        {
            case "Liu Kang":
                return new LiuKang();
            case "Raiden":
                return new Raiden();
            case "Scorpion":
                return new Scorpion();
            case "SubZero":
                return new SubZero();
            default:
                throw new ArgumentException("Personagem inválido");
        }
    }
}
