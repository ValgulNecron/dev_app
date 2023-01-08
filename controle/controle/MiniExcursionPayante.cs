namespace ConsExcursion;

public class MiniExcursionPayante : MiniExcursion
{
    public float tarif;

    public MiniExcursionPayante()
    {
        tarif = 0;
    }

    public MiniExcursionPayante(float tarif)
    {
        this.tarif = tarif;
    }

    public MiniExcursionPayante(int numMiniExcursion, string libelléMiniExcursion, int nombrePlaces) : base(
        numMiniExcursion, libelléMiniExcursion, nombrePlaces)
    {
    }

    public MiniExcursionPayante(int numMiniExcursion, string libelléMiniExcursion, int nombrePlaces, float tarif) :
        base(numMiniExcursion, libelléMiniExcursion, nombrePlaces)
    {
        this.tarif = tarif;
    }

    public float Tarif
    {
        get => tarif;
        set => tarif = value;
    }
}