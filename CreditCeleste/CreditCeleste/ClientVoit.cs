namespace CreditCeleste
{
    internal class ClientVoit : Client //pour ne pas modifier client
    {
        private string nomVendeur;

        public ClientVoit()
        {
        }

        public ClientVoit(int cidtClient, string nomCli, string prenomCli) : base(cidtClient, nomCli, prenomCli)
        {
        }

        public ClientVoit(int cidtClient, string nomCli, string prenomCli, string vendeur) : base(cidtClient, nomCli,
            prenomCli)
        {
            nomVendeur = vendeur;
        }

        public string getNomVendeur()
        {
            return nomVendeur;
        }

        public void setNomVendeur(string vendeur)
        {
            nomVendeur = vendeur;
        }
    }
}