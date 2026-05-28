using Domain.Enums;

namespace Domain.Entites;

public class Heros : Personnage
{
    public ClasseHeros Classe { get; }
    public int CooldownCompetence { get; private set; }
    public int SoinsRestants { get; private set; }

    public const int SOINS_MAX_PAR_COMBAT = 2;
    public const int SOIN_MONTANT = 25;

    public bool PeutUtiliserCompetence => CooldownCompetence == 0;
    public bool PeutSesoigner => SoinsRestants > 0;

    public Heros(string nom, ClasseHeros classe, int pvMax, int attaque, int armure = 0)
        : base(nom, pvMax, attaque, armure)
    {
        Classe = classe;
        CooldownCompetence = 0;
        SoinsRestants = SOINS_MAX_PAR_COMBAT;
    }

    public void DeclencherCooldown(int valeur)
    {
        CooldownCompetence = valeur;
    }

    public void TickCooldown()
    {
        if (CooldownCompetence > 0)
            CooldownCompetence--;
    }

    public void UtiliserSoin()
    {
        SoinsRestants--;
    }

    public void ResetSoins()
    {
        SoinsRestants = SOINS_MAX_PAR_COMBAT;
    }
}