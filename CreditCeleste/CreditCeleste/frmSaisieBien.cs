using System;
using System.Linq;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmSaisieBien : Form
    {
        public frmSaisieBien()
        {
            InitializeComponent();
        }

        private bool verifSaisie()
        {
            foreach (var txtbox in Controls.OfType<TextBox>())
                if (txtbox.Text == "")
                {
                    txtbox.Focus();
                    MessageBox.Show("Veuillez saisir le champ " + txtbox.Name);
                    return false;
                }

            return true;
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            // Permet de sauvegarder les informations vers l'objet Voiture
            // uneVoiture.setVoiture(...)

            var age = "";

            // Age du véhicule
            for (var i = 0; i < gpbAgeVehicule.Controls.Count; i++)
            {
                var chk = (RadioButton) gpbAgeVehicule.Controls[i];
                if (chk.Checked)
                    age = chk.Text;
            }

            if (verifSaisie())
            {
                if (Globales.uneVoiture == null)
                    Globales.uneVoiture = new Voiture(txtNouveauVehicule.Text, age, "", txtDate1ereImmatriculation.Text,
                        txtNumeroImmatriculation.Text, txtNumeroSerie.Text, txtPuissance.Text);
                // -- Si la voiture existe déjà, on reprend les données et on les affiche à l'écran
                else
                    Globales.uneVoiture.setVoiture(txtNouveauVehicule.Text, age, "", txtDate1ereImmatriculation.Text,
                        txtNumeroImmatriculation.Text, txtNumeroSerie.Text, txtPuissance.Text);

                MessageBox.Show("Saisie enregistrée !");
            }
        }

        private void frmSaisieBien_Load(object sender, EventArgs e)
        {
            // -- Lors de l'affichage, on va récupérer les informations de l'objet
            // -- et les mettre dans les zones de l'écran (dans la fenêtre) (les textboxs, listbox, etc.)
            // -- Si l'objet n'existe pas, les champs seront vide...

            if (Globales.uneVoiture != null)
            {
                txtNouveauVehicule.Text = Globales.uneVoiture.getNomVehicule();
                txtNumeroImmatriculation.Text = Globales.uneVoiture.getNumImmatVehicule();
                txtDate1ereImmatriculation.Text = Globales.uneVoiture.getPremImmatVehicule();
                txtNumeroSerie.Text = Globales.uneVoiture.getNumSerieVehicule();
                txtPuissance.Text = Globales.uneVoiture.getPuissanceVehicule();

                foreach (RadioButton rdb in gpbAgeVehicule.Controls)
                    if (rdb.Text == Globales.uneVoiture.getAgeVehicule())
                        rdb.Checked = true;
            }
        }

        private void btnIntroduction_Click(object sender, EventArgs e)
        {
            // Nouvel Objet
            var frmIntroduction = new frmIntroduction();
            // Affichage
            frmIntroduction.Show();
            // Ferme (hide)
            Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Permet de stocker les informations de l'objet dans la base de données
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            // Nouvel Objet
            var fenCalculCredit = new frmCalculCredit();
            // Affichage
            fenCalculCredit.Show();
            // Ferme (hide)
            Close();
        }
    }
}