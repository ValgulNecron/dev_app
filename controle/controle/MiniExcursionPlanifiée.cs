

//

namespace ConsExcursion;

public class MiniExcursionPlanifiée : MiniExcursion
{
    private TimeSpan heureDépart; // en heure  

    // Attributs privés	
    private MiniExcursion laMiniExcursion;
    private readonly int nombreInscrits;

    // Constructeur
    public MiniExcursionPlanifiée()
    {
        heureDépart = new TimeSpan(0, 0, 0);
        nombreInscrits = 0;
    }

    /* Méthodes publiques
    fonction estComplète() : Booléen
    Retourne VRAI si le nombre d’inscrits est égal au nombre de places et FAUX dans le cas contraire */
    private bool estComplète()
    {
        if (nombreInscrits >= getNombrePlaces()) return true;

        return false;
    }
}