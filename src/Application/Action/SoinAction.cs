using Domain.Entites;
using Domain.ValueObjects;

namespace CombatTP.Application.Actions;

public class SoinAction : ICombatAction
{
    public string Nom => "Se soigner";

    public bool PeutExecuter(Heros heros) => heros.PeutSesoigner;

    public CombatResult Executer(Heros heros, IReadOnlyList<Ennemi> ennemis)
    {
        if (!PeutExecuter(heros))
            return new CombatResult(false, "Plus de soins disponibles !");

        heros.Soigner(Heros.SOIN_MONTANT);
        heros.UtiliserSoin();

        return new CombatResult(true, $"{heros.Nom} se soigne de {Heros.SOIN_MONTANT} PV.", 0, Heros.SOIN_MONTANT);
    }
}