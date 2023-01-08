namespace ConsExcursion;

public class Etape
{
    private string description;

    private int dureePrevue; // Durée de l’étape exprimée en minutes 

    // Attributs privés
    private int numEtape;
    // constructeur

    public Etape()
    {
    }

    public Etape(int unNumEtape, string uneDescription, int uneDuréePrévue)
    {
    }

    // Méthodes publiques

    public int getNumEtape() // Retourne la valeur de l’attribut numEtape   
    {
        return numEtape;
    }

    public int getDureePrevue() // Retourne la valeur de l’attribut duréePrévue   
    {
        return dureePrevue;
    }

    public string getDescription() // Retourne la descripition
    {
        return description;
    }

    public string donneDureePrevuehhmm()
    {
        // Retourne la durée de l’étape sous la forme hh:mm. 

        return "xx hhmm";
    }
}