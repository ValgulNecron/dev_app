namespace ConsExcursion;

public class MiniExcursion : Excursion
{
    private readonly List<Etape>
        lesEtapes; // Collection de Etape ; // Contient toutes les étapes constituant  la mini-excursion 

    private string libelléMiniExcursion;
    private readonly int nombrePlaces;

    // Attributs privés	
    private int numMiniExcursion;

    // Constructeurs

    public MiniExcursion()
    {
    }


    // Méthodes publiques
    public MiniExcursion(int numMiniExcursion, string libelléMiniExcursion, int nombrePlaces)
    {
        this.numMiniExcursion = numMiniExcursion;
        this.libelléMiniExcursion = libelléMiniExcursion;
        this.nombrePlaces = nombrePlaces;
        lesEtapes = new List<Etape>();
    }

    public override int getNombrePlaces() // Retourne la valeur de l’attribut nombrePlaces
    {
        return nombrePlaces;
    }

    public override int donneDureePrevue()
    {
        var duree = 0;
        foreach (var etape in lesEtapes) duree += etape.getDureePrevue();
        return duree;
    }

    public override string donneDureePrevuehhmm()
    {
        // Retourne la durée totale de la mini-excursion sous la forme hh:mm.
        return temps.conversion_hhmm(donneDureePrevue());
    }

    public override bool ajouteEtape(int unNumEtape, string uneDescription, int uneDuréePrévue)
    {
        // Elle renvoie VRAI si le numéro d’étape n'existe pas déjà dans la collection des étapes de la mini-
        // excursion et ajoute une nouvelle étape dans la collection. Elle renvoie FAUX dans le cas contraire. 
        //fonction MiniExcursion : ajouteEtape(e unNumEtape : Entier, uneDescription : Chaîne, uneDuréePrévue : Entier) : Booléen 
        var etape = new Etape(unNumEtape, uneDescription, uneDuréePrévue);
        if (lesEtapes.Contains(etape)) return false;
        lesEtapes.Add(etape);
        return true;
    }

    public bool ajouteEtape2(int unNumEtape, string uneDescription, int uneDureePrevue)
    {
        var existe = false;
        var etape = new Etape(unNumEtape, uneDescription, uneDureePrevue);
        /*
        foreach (var etape1 in lesEtapes)
        {
            if (etape1.getNumEtape() == etape.getNumEtape() && etape1.getDescription() == etape.getDescription() &&
                etape1.getDureePrevue() == etape.getDureePrevue())
            {
                existePas = false;
            }
        }
        */
        var i = 0;
        while (lesEtapes.Count >= i)
        {
            i += 1;
            if (lesEtapes[i].getNumEtape() == etape.getNumEtape() &&
                lesEtapes[i].getDescription() == etape.getDescription() &&
                lesEtapes[i].getDureePrevue() == etape.getDureePrevue()) existe = true;
        }

        if (!existe) lesEtapes.Add(etape);
        return !existe;
    }
}