using System.ComponentModel;

namespace CreditCeleste
{
    partial class frmCredit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMensualite = new System.Windows.Forms.TextBox();
            this.tbTaux = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMontant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCalcule = new System.Windows.Forms.Button();
            this.btCredit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "mensualite";
            // 
            // tbMensualite
            // 
            this.tbMensualite.Location = new System.Drawing.Point(25, 59);
            this.tbMensualite.Name = "tbMensualite";
            this.tbMensualite.Size = new System.Drawing.Size(105, 20);
            this.tbMensualite.TabIndex = 4;
            // 
            // tbTaux
            // 
            this.tbTaux.Location = new System.Drawing.Point(25, 138);
            this.tbTaux.Name = "tbTaux";
            this.tbTaux.Size = new System.Drawing.Size(105, 20);
            this.tbTaux.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "taux";
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(25, 217);
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.Size = new System.Drawing.Size(105, 20);
            this.tbDuree.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "duree (mois)";
            // 
            // tbMontant
            // 
            this.tbMontant.Location = new System.Drawing.Point(25, 300);
            this.tbMontant.Name = "tbMontant";
            this.tbMontant.Size = new System.Drawing.Size(105, 20);
            this.tbMontant.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "montant";
            // 
            // btCalcule
            // 
            this.btCalcule.Location = new System.Drawing.Point(25, 360);
            this.btCalcule.Name = "btCalcule";
            this.btCalcule.Size = new System.Drawing.Size(72, 20);
            this.btCalcule.TabIndex = 11;
            this.btCalcule.Text = "calcule";
            this.btCalcule.UseVisualStyleBackColor = true;
            this.btCalcule.Click += new System.EventHandler(this.btCalcule_Click);
            // 
            // btCredit
            // 
            this.btCredit.Location = new System.Drawing.Point(114, 360);
            this.btCredit.Name = "btCredit";
            this.btCredit.Size = new System.Drawing.Size(109, 20);
            this.btCredit.TabIndex = 12;
            this.btCredit.Text = "liste des credit";
            this.btCredit.UseVisualStyleBackColor = true;
            this.btCredit.Click += new System.EventHandler(this.btCredit_Click);
            // 
            // frmCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 422);
            this.Controls.Add(this.btCredit);
            this.Controls.Add(this.btCalcule);
            this.Controls.Add(this.tbMontant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDuree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTaux);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMensualite);
            this.Controls.Add(this.label1);
            this.Name = "frmCredit";
            this.Text = "frmCredit";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMensualite;
        private System.Windows.Forms.TextBox tbTaux;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.TextBox tbMontant;
        private System.Windows.Forms.Button btCalcule;
        private System.Windows.Forms.Button btCredit;

        #endregion
    }
}