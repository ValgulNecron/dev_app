using System;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmCalculCredit : Form
    {
        public frmCalculCredit()
        {
            InitializeComponent();
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            //permet de calculer la mensualité
            //sur l'écran sereont saisie
            // -le montant financé
            // -la duréé du pret
            // - le taux annuel

            var unCredit = new Credit(Convert.ToDouble(txtMontant.Text), Convert.ToDouble(txtDuree.Text),
                Convert.ToDouble(txtTaux.Text));

            txtMensualite.Text = Convert.ToString(unCredit.getMensualite());

            //rajout dans la collection des credits

            Globales.lesCredits.Add(unCredit);
        }

        private void btnListeCredit_Click(object sender, EventArgs e)
        {
            //aller vers la fenetre qui presente les credits
            //l'utilisateur va en selectionner un

            //nouvel objet

            var fenListeCredit = new frmListeCredit();
            // Affichage
            fenListeCredit.Show();
            // Ferme (hide)
            Close();
        }

        private void btnVoiture_Click(object sender, EventArgs e)
        {
            var fenSaisieBien = new frmSaisieBien();
            fenSaisieBien.Show();
            Close();
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            ClassSql.majBddCredit(new Credit(Convert.ToDouble(txtMontant.Text), Convert.ToDouble(txtDuree.Text),
                Convert.ToDouble(txtTaux.Text)));
        }
    }
}