namespace consResto
{
    public class ClientFid : Client
    {
        private int reduc;

        public ClientFid()
        {
            reduc = 10;
        } //constructeur par défaut

        public ClientFid(int numCli) : base(numCli)
        {
            reduc = 10;
        } //constructeur avec paramètres

        public ClientFid(int numCli, string nomCli, string prenomCli) : base(numCli, nomCli, prenomCli)
        {
            reduc = 10;
        }//constructeur avec paramètres

        public ClientFid(int numCli, string nomCli, string prenomCli, int redu) : base(numCli, nomCli, prenomCli)
        {
            reduc = redu;
        }//constructeur avec paramètres

        public override double Addition()
        {
            var total = base.Addition() * (1 - reduc / 100);
            return total;
        }//calcul de la facture avec la réduction

        public double Addition(int redu)
        {
            double addition;
            addition = Addition() * (1 - redu / 100);
            return addition;
        }//calcul de la facture avec une réduction donnée

        public double AdditionNormal()
        {
            return base.Addition();
        }//calcul de la facture sans reduction
    }
}