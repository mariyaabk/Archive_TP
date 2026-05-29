using CombatTP.Application.Actions;
using CombatTP.Application.Factories;
using Domain.Entites;
using Domain.Enums;
using CombatTP.Infrastructure.UI;

var renderer = new ConsoleRenderer();
var input = new ConsoleInputHandler();
var heroFactory = new HeroFactory();
var enemyFactory = new EnemyFactory();

renderer.AfficherTitre();

var nom = input.LireNom("  Entrez le nom de votre héros : ");

System.Console.WriteLine();
renderer.AfficherChoixClasse();
var choixClasse = input.LireChoixMenu(1, 3);

var classe = choixClasse switch
{
    1 => ClasseHeros.Guerrier,
    2 => ClasseHeros.Mage,
    3 => ClasseHeros.Voleur,
    _ => throw new InvalidOperationException()
};

var heros = heroFactory.Creer(nom, classe);
renderer.AfficherConfirmationHeros(heros.Nom, heros.Classe);

// test strategy
var ennemi = enemyFactory.Creer("GoblinFaible");
var attaque = new AttaqueBasiqueAction();
var result = attaque.Executer(heros, new List<Ennemi> { ennemi });
System.Console.WriteLine(result.Message);
