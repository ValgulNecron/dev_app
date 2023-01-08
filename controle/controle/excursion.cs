namespace ConsExcursion;

public abstract class Excursion
{
    public abstract int donneDureePrevue();
    public abstract string donneDureePrevuehhmm();
    public abstract bool ajouteEtape(int unNumEtape, string uneDescription, int uneDuréePrévue);
    public abstract int getNombrePlaces();

    public string niveauSecurite(bool niveauSecu)
    {
        var message = niveauSecu ? "attention, sécurité à mettre en oeuvre" : "sans sécurité particulière";
        return message;
    }
}