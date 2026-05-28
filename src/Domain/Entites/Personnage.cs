using Domain.Interfaces;

namespace Domain.Entites;

public abstract class Personnage : IDamageable
{
    public string Nom { get; }
    public int PvMax { get; }
    public int PvActuels { get; private set; }
    public int Attaque { get; }
    public int Armure { get; }
    public bool EstVivant => PvActuels > 0;

    protected Personnage(string nom, int pvMax, int attaque, int armure = 0)
    {
        Nom = nom;
        PvMax = pvMax;
        PvActuels = pvMax;
        Attaque = attaque;
        Armure = armure;
    }

    public void RecevoirDegats(int degats)
    {
        var degatsReduits = Math.Max(0, degats - Armure);
        PvActuels = Math.Max(0, PvActuels - degatsReduits);
    }

    public void Soigner(int soin)
    {
        PvActuels = Math.Min(PvMax, PvActuels + soin);
    }

    public void RestaurerPv(int quantite)
    {
        PvActuels = Math.Min(PvMax, PvActuels + quantite);
    }
}