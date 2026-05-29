using Domain.Entites;
using Domain.ValueObjects;

namespace CombatTP.Application.Actions;

public class AttaqueBasiqueAction : ICombatAction
{
    public string Nom => "Attaque de base";

    public bool PeutExecuter(Heros heros) => true;

    public CombatResult Executer(Heros heros, IReadOnlyList<Ennemi> ennemis)
    {
        var cible = ennemis.First(e => e.EstVivant);
        var degats = heros.Attaque;

        cible.RecevoirDegats(degats);

        return new CombatResult(true, $"{heros.Nom} attaque {cible.Nom} pour {degats} dégâts !", degats);
    }
}