using System;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmCredit : Form
    {
        public frmCredit()
        {
            InitializeComponent();
        }

        private void btCalcule_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit(Convert.ToDouble(tbMontant), 
                Convert.ToDouble(tbTaux), Convert.ToInt32(tbDuree));
            
            tbMensualite.Text = credit.maMensualiteProperty.ToString();
            
            Globales.lesCredits.Add(credit);
        }

        private void btCredit_Click(object sender, EventArgs e)
        {
            
        }
    }
}