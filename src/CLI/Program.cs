using CombatTP.Application.Factories;
using Domain.Enums;

var heroFactory = new HeroFactory();
var heros = heroFactory.Creer("Aria", ClasseHeros.Mage);

Console.WriteLine($"{heros.Nom} - {heros.Classe} - PV : {heros.PvActuels}/{heros.PvMax}");