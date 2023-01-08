namespace CreditCeleste
{
    internal class Voiture
    {
        private string monAgeVehicule;
        private string monAncienVehicule;
        private string monDate1ereImmatriculation;
        private string monNomVehicule;
        private string monNumeroImmat;
        private string monNumeroSerie;
        private string monPuissance;

        public Voiture()
        {
        }

        public Voiture(string nomVehicule, string ageVehicule, string ancienVehicule)
        {
            monNomVehicule = nomVehicule;
            monAgeVehicule = ageVehicule;
            monAncienVehicule = ancienVehicule;
        }

        public Voiture(string nomVehicule, string ageVehicule, string ancienVehicule, string date1ereImmatriculation,
            string numeroImmatriculation, string numeroSerie, string puissance)
        {
            monNomVehicule = nomVehicule;
            monAgeVehicule = ageVehicule;
            monAncienVehicule = ancienVehicule;
            monDate1ereImmatriculation = date1ereImmatriculation;
            monNumeroImmat = numeroImmatriculation;
            monNumeroSerie = numeroSerie;
            monPuissance = puissance;
        }

        public void setVoiture(string nomVehicule, string ageVehicule, string ancienVehicule,
            string date1ereImmatriculation)
        {
            monNomVehicule = nomVehicule;
            monAgeVehicule = ageVehicule;
            monAncienVehicule = ancienVehicule;
            monDate1ereImmatriculation = date1ereImmatriculation;
        }

        public void setVoiture(string nomVehicule, string ageVehicule, string ancienVehicule,
            string date1ereImmatriculation, string numeroImmatriculation, string numeroSerie, string puissance)
        {
            monNomVehicule = nomVehicule;
            monAgeVehicule = ageVehicule;
            monAncienVehicule = ancienVehicule;
            monDate1ereImmatriculation = date1ereImmatriculation;
            monNumeroImmat = numeroImmatriculation;
            monNumeroSerie = numeroSerie;
            monPuissance = puissance;
        }

        public string getNomVehicule()
        {
            return monNomVehicule;
        }

        public string getAgeVehicule()
        {
            return monAgeVehicule;
        }

        public string getNumImmatVehicule()
        {
            return monNumeroImmat;
        }

        public string getPremImmatVehicule()
        {
            return monDate1ereImmatriculation;
        }

        public string getNumSerieVehicule()
        {
            return monNumeroSerie;
        }

        public string getPuissanceVehicule()
        {
            return monPuissance;
        }
    }
}