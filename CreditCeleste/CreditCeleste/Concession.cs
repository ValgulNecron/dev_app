using System.Collections.Generic;

namespace CreditCeleste
{
    internal class Concession
    {
        private readonly List<Vendeur> lesVendeurs = new List<Vendeur>();

        // test
        public Concession(string nomConcession, string adresseConcession)
        {
            NomConcession = nomConcession;
            AdresseConcession = adresseConcession;
        }

        //permet de gerer les proprietés
        public string NomConcession { get; set; }

        public string AdresseConcession { get; set; }

        //pour ajouter un vendeur
        public void ajoutVendeur(Vendeur unVendeur)
        {
            lesVendeurs.Add(unVendeur);
        }

        public List<Vendeur> getLesVendeurs()
        {
            return lesVendeurs;
        }
    }
}