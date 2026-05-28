namespace Domain.Entites;

public class Ennemi : Personnage
{
    public string Type { get; }

    public Ennemi(string nom, string type, int pvMax, int attaque, int armure = 0)
        : base(nom, pvMax, attaque, armure)
    {
        Type = type;
    }
}