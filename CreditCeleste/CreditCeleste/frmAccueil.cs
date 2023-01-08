using System;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void cmdIntroduction_Click(object sender, EventArgs e)
        {
            //appel d la fenetre introduction
            //classe        objet       int : int
            var fenIntroduction = new frmIntroduction();
            fenIntroduction.Show();
            //this.Close(); //on ferme la fenetre
            Hide(); //pour cacher la fenetre
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            // on initialise les variable de ClassSQL
            ClassSql.init();    
            //creation d'une concession 
            Globales.uneConcession = new Concession("Garage Munsch", "66 rue des palmiers");

            //Rajout du vendeur
            var unVendeur = new Vendeur("M.", "Munsch", "Nathan");

            //Deuxieme vendeur
            var deuxVendeur = new Vendeur("M.", "TA", "Sarah");

            //Troisieme vendeur
            var troisVendeur = new Vendeur("Mlle", "KAYA", "Sema");

            //Les stocker dans la collection
            Globales.uneConcession.ajoutVendeur(unVendeur);
            Globales.uneConcession.ajoutVendeur(deuxVendeur);
            Globales.uneConcession.ajoutVendeur(troisVendeur);

            //creation d'une concession avec des vendeurs
            //a partir de la table de la bdd

            //gestion des proprieté
            Globales.uneConcession.NomConcession = "toto";
            var adresse = Globales.uneConcession.AdresseConcession;
        }
    }
}