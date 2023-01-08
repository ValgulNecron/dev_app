using System;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmIntroduction : Form
    {
        public frmIntroduction()
        {
            InitializeComponent();
        }

        private void cmdSaisieBien_Click(object sender, EventArgs e)
        {
            //appel de la fenetre voiture
            var fenSaisieBien = new frmSaisieBien();
            fenSaisieBien.Show();
            Close(); //on ferme la fenetre
        }

        private void cmdEnregistre_Click(object sender, EventArgs e)
        {
            var affichage = "";
            RadioButton radio;

            affichage = cboCidt.Text + " " + txtNom.Text + " " + txtPrenom.Text;
            affichage += Environment.NewLine;
            affichage += cboVendeur.Text;
            affichage += Environment.NewLine;

            var i = 0;
            var age = "";

            radio = gpbAgeVehicule.Controls[i] as RadioButton;

            while (radio.Checked == false)
            {
                i += 1;
                radio = gpbAgeVehicule.Controls[i] as RadioButton;
            }

            affichage += "Age du vehicule : " + Environment.NewLine;
            affichage += radio.Text + Environment.NewLine;

            //Age du vehicule avec le tp pizza

            Globales.uneVoiture = new Voiture(txtNouveauVehicule.Text, age, txtAncienVehicule.Text);
        }

        private void frmIntroduction_Load(object sender, EventArgs e)
        {
            //lecture de la collection des vendeurs de la concession
            //pour l'affichage dans la combobox vendeur

            foreach (var xVendeur in Globales.uneConcession.getLesVendeurs())
                cboVendeur.Items.Add(xVendeur.getInfosVendeurs());

            //comment passer la collection en variable globales 
            //(identique aux variable de sessions)

            if (Globales.unClientVoit != null)
            {
                //recuperation des elements du client

                cboCidt.Text = Globales.unClientVoit.getCivClient();
                txtNom.Text = Globales.unClientVoit.getNomClient();
                txtPrenom.Text = Globales.unClientVoit.getPrenomClient();
                cboVendeur.Text = Globales.unClientVoit.getNomVendeur();
            }
        }
    }
}