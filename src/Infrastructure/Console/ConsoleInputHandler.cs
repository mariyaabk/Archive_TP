namespace CombatTP.Infrastructure.UI;

public class ConsoleInputHandler
{
    public string LireNom(string invite)
    {
        System.Console.Write(invite);
        var nom = System.Console.ReadLine()?.Trim();

        while (string.IsNullOrWhiteSpace(nom))
        {
            System.Console.Write("  Nom invalide. Réessayez : ");
            nom = System.Console.ReadLine()?.Trim();
        }

        return nom!;
    }

    public int LireChoixMenu(int min, int max)
    {
        while (true)
        {
            var saisie = System.Console.ReadLine();

            if (int.TryParse(saisie, out int choix) && choix >= min && choix <= max)
                return choix;

            System.Console.Write($"  Choix invalide. Entrez un nombre entre {min} et {max} : ");
        }
    }
}