using Domain.Entites;
using Domain.ValueObjects;

namespace CombatTP.Application.Actions;

public interface ICombatAction
{
    string Nom { get; }
    bool PeutExecuter(Heros heros);
    CombatResult Executer(Heros heros, IReadOnlyList<Ennemi> ennemis);
}