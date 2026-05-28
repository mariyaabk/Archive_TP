using Domain.Entites;
using Domain.Enums;

namespace CombatTP.Application.Factories;

public interface IHeroFactory
{
    Heros Creer(string nom, ClasseHeros classe);
}

public interface IEnemyFactory
{
    Ennemi Creer(string type);
}

public class HeroFactory : IHeroFactory
{
    // stats du tableau du TP
    private static readonly Dictionary<ClasseHeros, Func<string, Heros>> _configs = new()
    {
        [ClasseHeros.Guerrier] = nom => new Heros(nom, ClasseHeros.Guerrier, pvMax: 120, attaque: 18, armure: 3),
        [ClasseHeros.Mage]     = nom => new Heros(nom, ClasseHeros.Mage,     pvMax: 80,  attaque: 12, armure: 0),
        [ClasseHeros.Voleur]   = nom => new Heros(nom, ClasseHeros.Voleur,   pvMax: 90,  attaque: 14, armure: 1),
    };

    public Heros Creer(string nom, ClasseHeros classe)
    {
        if (!_configs.TryGetValue(classe, out var factory))
            throw new ArgumentException($"Classe inconnue : {classe}");

        return factory(nom);
    }
}

public class EnemyFactory : IEnemyFactory
{
    private static readonly Dictionary<string, Func<Ennemi>> _configs = new()
    {
        ["GoblinFaible"]  = () => new Ennemi("Goblin",       "Goblin", pvMax: 40,  attaque: 8),
        ["Goblin"]        = () => new Ennemi("Goblin",        "Goblin", pvMax: 55,  attaque: 10),
        ["GoblinArcher"]  = () => new Ennemi("Goblin archer", "Goblin", pvMax: 35,  attaque: 12),
        ["BossOrc"]       = () => new Ennemi("Orc boss",      "Boss",   pvMax: 150, attaque: 20, armure: 5),
    };

    public Ennemi Creer(string type)
    {
        if (!_configs.TryGetValue(type, out var factory))
            throw new ArgumentException($"Type d'ennemi inconnu : {type}");

        return factory();
    }
}