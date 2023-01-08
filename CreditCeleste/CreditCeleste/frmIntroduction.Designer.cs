
namespace CreditCeleste
{
    partial class frmIntroduction
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
            this.cmdEnregistre = new System.Windows.Forms.Button();
            this.cmdSaisieBien = new System.Windows.Forms.Button();
            this.cmdVersBdd = new System.Windows.Forms.Button();
            this.cboCidt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNouveauVehicule = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAncienVehicule = new System.Windows.Forms.TextBox();
            this.cboVendeur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbAgeVehicule = new System.Windows.Forms.GroupBox();
            this.rdbOcc5plus = new System.Windows.Forms.RadioButton();
            this.rdbOcc5 = new System.Windows.Forms.RadioButton();
            this.rdbOcc3 = new System.Windows.Forms.RadioButton();
            this.rdbNeuf = new System.Windows.Forms.RadioButton();
            this.gpbAgeVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdEnregistre
            // 
            this.cmdEnregistre.Location = new System.Drawing.Point(33, 330);
            this.cmdEnregistre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdEnregistre.Name = "cmdEnregistre";
            this.cmdEnregistre.Size = new System.Drawing.Size(120, 31);
            this.cmdEnregistre.TabIndex = 0;
            this.cmdEnregistre.Text = "J\'enregistre";
            this.cmdEnregistre.UseVisualStyleBackColor = true;
            this.cmdEnregistre.Click += new System.EventHandler(this.cmdEnregistre_Click);
            // 
            // cmdSaisieBien
            // 
            this.cmdSaisieBien.Location = new System.Drawing.Point(337, 330);
            this.cmdSaisieBien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSaisieBien.Name = "cmdSaisieBien";
            this.cmdSaisieBien.Size = new System.Drawing.Size(75, 31);
            this.cmdSaisieBien.TabIndex = 1;
            this.cmdSaisieBien.Text = "Voiture";
            this.cmdSaisieBien.UseVisualStyleBackColor = true;
            this.cmdSaisieBien.Click += new System.EventHandler(this.cmdSaisieBien_Click);
            // 
            // cmdVersBdd
            // 
            this.cmdVersBdd.Location = new System.Drawing.Point(625, 330);
            this.cmdVersBdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdVersBdd.Name = "cmdVersBdd";
            this.cmdVersBdd.Size = new System.Drawing.Size(75, 31);
            this.cmdVersBdd.TabIndex = 2;
            this.cmdVersBdd.Text = "Valider";
            this.cmdVersBdd.UseVisualStyleBackColor = true;
            // 
            // cboCidt
            // 
            this.cboCidt.FormattingEnabled = true;
            this.cboCidt.Items.AddRange(new object[] {
            "Mademoiselle",
            "Madame",
            "Monsieur"});
            this.cboCidt.Location = new System.Drawing.Point(29, 36);
            this.cboCidt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCidt.Name = "cboCidt";
            this.cboCidt.Size = new System.Drawing.Size(121, 24);
            this.cboCidt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Je m\'appelle";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(29, 234);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(121, 22);
            this.txtPrenom.TabIndex = 5;
            // 
            // txtNouveauVehicule
            // 
            this.txtNouveauVehicule.Location = new System.Drawing.Point(561, 231);
            this.txtNouveauVehicule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNouveauVehicule.Name = "txtNouveauVehicule";
            this.txtNouveauVehicule.Size = new System.Drawing.Size(209, 22);
            this.txtNouveauVehicule.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(29, 124);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 22);
            this.txtNom.TabIndex = 7;
            // 
            // txtAncienVehicule
            // 
            this.txtAncienVehicule.Location = new System.Drawing.Point(561, 137);
            this.txtAncienVehicule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAncienVehicule.Name = "txtAncienVehicule";
            this.txtAncienVehicule.Size = new System.Drawing.Size(209, 22);
            this.txtAncienVehicule.TabIndex = 8;
            // 
            // cboVendeur
            // 
            this.cboVendeur.FormattingEnabled = true;
            this.cboVendeur.Items.AddRange(new object[] {
            "A faire depuis la bdd"});
            this.cboVendeur.Location = new System.Drawing.Point(316, 58);
            this.cboVendeur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboVendeur.Name = "cboVendeur";
            this.cboVendeur.Size = new System.Drawing.Size(121, 24);
            this.cboVendeur.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Vendeur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mon nouveau véhicule";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mon ancien véhicule";
            // 
            // gpbAgeVehicule
            // 
            this.gpbAgeVehicule.Controls.Add(this.rdbOcc5plus);
            this.gpbAgeVehicule.Controls.Add(this.rdbOcc5);
            this.gpbAgeVehicule.Controls.Add(this.rdbOcc3);
            this.gpbAgeVehicule.Controls.Add(this.rdbNeuf);
            this.gpbAgeVehicule.Location = new System.Drawing.Point(289, 135);
            this.gpbAgeVehicule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbAgeVehicule.Name = "gpbAgeVehicule";
            this.gpbAgeVehicule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbAgeVehicule.Size = new System.Drawing.Size(200, 137);
            this.gpbAgeVehicule.TabIndex = 15;
            this.gpbAgeVehicule.TabStop = false;
            this.gpbAgeVehicule.Text = "Age du vehicule";
            // 
            // rdbOcc5plus
            // 
            this.rdbOcc5plus.AutoSize = true;
            this.rdbOcc5plus.Location = new System.Drawing.Point(5, 102);
            this.rdbOcc5plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbOcc5plus.Name = "rdbOcc5plus";
            this.rdbOcc5plus.Size = new System.Drawing.Size(159, 21);
            this.rdbOcc5plus.TabIndex = 3;
            this.rdbOcc5plus.TabStop = true;
            this.rdbOcc5plus.Text = "Occasion 5 ans ou +";
            this.rdbOcc5plus.UseVisualStyleBackColor = true;
            // 
            // rdbOcc5
            // 
            this.rdbOcc5.AutoSize = true;
            this.rdbOcc5.Location = new System.Drawing.Point(5, 75);
            this.rdbOcc5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbOcc5.Name = "rdbOcc5";
            this.rdbOcc5.Size = new System.Drawing.Size(156, 21);
            this.rdbOcc5.TabIndex = 2;
            this.rdbOcc5.Text = "Occasion - de 5 ans";
            this.rdbOcc5.UseVisualStyleBackColor = true;
            // 
            // rdbOcc3
            // 
            this.rdbOcc3.AutoSize = true;
            this.rdbOcc3.Location = new System.Drawing.Point(5, 48);
            this.rdbOcc3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbOcc3.Name = "rdbOcc3";
            this.rdbOcc3.Size = new System.Drawing.Size(156, 21);
            this.rdbOcc3.TabIndex = 1;
            this.rdbOcc3.TabStop = true;
            this.rdbOcc3.Text = "Occasion - de 3 ans";
            this.rdbOcc3.UseVisualStyleBackColor = true;
            // 
            // rdbNeuf
            // 
            this.rdbNeuf.AutoSize = true;
            this.rdbNeuf.Checked = true;
            this.rdbNeuf.Location = new System.Drawing.Point(5, 22);
            this.rdbNeuf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbNeuf.Name = "rdbNeuf";
            this.rdbNeuf.Size = new System.Drawing.Size(59, 21);
            this.rdbNeuf.TabIndex = 0;
            this.rdbNeuf.TabStop = true;
            this.rdbNeuf.Text = "Neuf";
            this.rdbNeuf.UseVisualStyleBackColor = true;
            // 
            // frmIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbAgeVehicule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboVendeur);
            this.Controls.Add(this.txtAncienVehicule);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNouveauVehicule);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCidt);
            this.Controls.Add(this.cmdVersBdd);
            this.Controls.Add(this.cmdSaisieBien);
            this.Controls.Add(this.cmdEnregistre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmIntroduction";
            this.Text = "Introduction";
            this.Load += new System.EventHandler(this.frmIntroduction_Load);
            this.gpbAgeVehicule.ResumeLayout(false);
            this.gpbAgeVehicule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdEnregistre;
        private System.Windows.Forms.Button cmdSaisieBien;
        private System.Windows.Forms.Button cmdVersBdd;
        private System.Windows.Forms.ComboBox cboCidt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNouveauVehicule;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAncienVehicule;
        private System.Windows.Forms.ComboBox cboVendeur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbAgeVehicule;
        private System.Windows.Forms.RadioButton rdbOcc5plus;
        private System.Windows.Forms.RadioButton rdbOcc5;
        private System.Windows.Forms.RadioButton rdbOcc3;
        private System.Windows.Forms.RadioButton rdbNeuf;
    }
}