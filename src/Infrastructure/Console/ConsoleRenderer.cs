using Domain.Enums;

namespace CombatTP.Infrastructure.UI;

public class ConsoleRenderer
{
    public void AfficherTitre()
    {
        System.Console.WriteLine("JEU DE COMBAT TOUR PAR TOUR");
        System.Console.WriteLine();
    }

    public void AfficherChoixClasse()
    {
        System.Console.WriteLine("  Choisissez votre classe :");
        System.Console.WriteLine("    1. Guerrier  (PV: 120 | ATQ: 18 | Frappe lourde x1.5, cooldown 2 tours)");
        System.Console.WriteLine("    2. Mage      (PV: 80  | ATQ: 12 | Éclair magique, cooldown 3 tours)");
        System.Console.WriteLine("    3. Voleur    (PV: 90  | ATQ: 14 | Coup critique 30%, cooldown 2 tours)");
        System.Console.Write("  Votre choix : ");
    }

    public void AfficherConfirmationHeros(string nom, ClasseHeros classe)
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"  Héros créé : {nom} ({classe})");
        System.Console.WriteLine("  Appuyez sur Entrée pour commencer...");
        System.Console.ReadLine();
    }
}