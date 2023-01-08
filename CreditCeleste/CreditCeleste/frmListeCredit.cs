using System;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmListeCredit : Form
    {
        public frmListeCredit()
        {
            InitializeComponent();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            var fenCalculCredit = new frmCalculCredit();
            // Affichage
            fenCalculCredit.Show();
            // Ferme (hide)
            Close();
        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
        }

        private void frmListeCredit_Load(object sender, EventArgs e)
        {
            //mettre les données de la collection lesCredits
            //dans la listBox de l'écran
            foreach (var credit in ClassSql.recupBddCredit())
            {
                lsbCredit.Items.Add(credit.getInfos());
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            // il initialise 
            lsbCredit.Items.Clear();
        }
    }
}