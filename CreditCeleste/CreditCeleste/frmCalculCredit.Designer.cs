
namespace CreditCeleste
{
    partial class frmCalculCredit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIntroduction = new System.Windows.Forms.Button();
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMensualite = new System.Windows.Forms.TextBox();
            this.txtTaux = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.btnListeCredit = new System.Windows.Forms.Button();
            this.btnVoiture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntroduction
            // 
            this.btnIntroduction.Location = new System.Drawing.Point(324, 366);
            this.btnIntroduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIntroduction.Name = "btnIntroduction";
            this.btnIntroduction.Size = new System.Drawing.Size(117, 30);
            this.btnIntroduction.TabIndex = 21;
            this.btnIntroduction.Text = "Introduction";
            this.btnIntroduction.UseVisualStyleBackColor = true;
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(464, 366);
            this.btnEnregistre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(109, 30);
            this.btnEnregistre.TabIndex = 20;
            this.btnEnregistre.Text = "J\'enregistre";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(256, 303);
            this.btnCalcul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(75, 30);
            this.btnCalcul.TabIndex = 19;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mensualité";
            // 
            // txtMensualite
            // 
            this.txtMensualite.Location = new System.Drawing.Point(310, 277);
            this.txtMensualite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMensualite.Name = "txtMensualite";
            this.txtMensualite.Size = new System.Drawing.Size(140, 22);
            this.txtMensualite.TabIndex = 17;
            // 
            // txtTaux
            // 
            this.txtTaux.Location = new System.Drawing.Point(310, 218);
            this.txtTaux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaux.Name = "txtTaux";
            this.txtTaux.Size = new System.Drawing.Size(140, 22);
            this.txtTaux.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Taux annuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Durée en mois";
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(310, 149);
            this.txtDuree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(140, 22);
            this.txtDuree.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Montant du crédit";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(310, 78);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(140, 22);
            this.txtMontant.TabIndex = 11;
            // 
            // btnListeCredit
            // 
            this.btnListeCredit.Location = new System.Drawing.Point(363, 309);
            this.btnListeCredit.Name = "btnListeCredit";
            this.btnListeCredit.Size = new System.Drawing.Size(147, 23);
            this.btnListeCredit.TabIndex = 22;
            this.btnListeCredit.Text = "Liste des crédits";
            this.btnListeCredit.UseVisualStyleBackColor = true;
            this.btnListeCredit.Click += new System.EventHandler(this.btnListeCredit_Click);
            // 
            // btnVoiture
            // 
            this.btnVoiture.Location = new System.Drawing.Point(218, 366);
            this.btnVoiture.Name = "btnVoiture";
            this.btnVoiture.Size = new System.Drawing.Size(75, 23);
            this.btnVoiture.TabIndex = 23;
            this.btnVoiture.Text = "Voiture";
            this.btnVoiture.UseVisualStyleBackColor = true;
            this.btnVoiture.Click += new System.EventHandler(this.btnVoiture_Click);
            // 
            // frmCalculCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoiture);
            this.Controls.Add(this.btnListeCredit);
            this.Controls.Add(this.btnIntroduction);
            this.Controls.Add(this.btnEnregistre);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMensualite);
            this.Controls.Add(this.txtTaux);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontant);
            this.Name = "frmCalculCredit";
            this.Text = "CalculCredit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIntroduction;
        private System.Windows.Forms.Button btnEnregistre;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMensualite;
        private System.Windows.Forms.TextBox txtTaux;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Button btnListeCredit;
        private System.Windows.Forms.Button btnVoiture;
    }
}