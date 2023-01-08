namespace CreditCeleste
{
    internal class Vendeur
    {
        private string monIdtVendeur;
        private readonly string nomVendeur;
        private readonly string prenomVendeur;

        public Vendeur(string unIdtVendeur, string unNomVendeur, string unPrenomVendeur)
        {
            monIdtVendeur = unIdtVendeur;
            nomVendeur = unNomVendeur;
            prenomVendeur = unPrenomVendeur;
        }

        public void setIdtVendeur(string IdtVendeur)
        {
            monIdtVendeur = IdtVendeur;
        }

        public void setNomVendeur(string NomVendeur)
        {
            monIdtVendeur = NomVendeur;
        }

        public void setPrenomVendeur(string PrenomVendeur)
        {
            monIdtVendeur = PrenomVendeur;
        }

        public string getIdtVendeur()
        {
            return monIdtVendeur;
        }

        public string getNomVendeur()
        {
            return nomVendeur;
        }

        public string getPrenomVendeur()
        {
            return prenomVendeur;
        }

        public string getInfosVendeurs()
        {
            return monIdtVendeur + nomVendeur + prenomVendeur;
        }
    }
}