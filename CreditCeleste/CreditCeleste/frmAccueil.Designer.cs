
namespace CreditCeleste
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdIntroduction = new System.Windows.Forms.Button();
            this.cmdEtude = new System.Windows.Forms.Button();
            this.cmdRelance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdIntroduction
            // 
            this.cmdIntroduction.Location = new System.Drawing.Point(218, 145);
            this.cmdIntroduction.Name = "cmdIntroduction";
            this.cmdIntroduction.Size = new System.Drawing.Size(122, 53);
            this.cmdIntroduction.TabIndex = 0;
            this.cmdIntroduction.Text = "Introduction";
            this.cmdIntroduction.UseVisualStyleBackColor = true;
            this.cmdIntroduction.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // cmdEtude
            // 
            this.cmdEtude.Location = new System.Drawing.Point(346, 145);
            this.cmdEtude.Name = "cmdEtude";
            this.cmdEtude.Size = new System.Drawing.Size(90, 52);
            this.cmdEtude.TabIndex = 1;
            this.cmdEtude.Text = "Etude";
            this.cmdEtude.UseVisualStyleBackColor = true;
            // 
            // cmdRelance
            // 
            this.cmdRelance.Location = new System.Drawing.Point(452, 145);
            this.cmdRelance.Name = "cmdRelance";
            this.cmdRelance.Size = new System.Drawing.Size(107, 53);
            this.cmdRelance.TabIndex = 2;
            this.cmdRelance.Text = "Relance";
            this.cmdRelance.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nathan Munsch";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdRelance);
            this.Controls.Add(this.cmdEtude);
            this.Controls.Add(this.cmdIntroduction);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdIntroduction;
        private System.Windows.Forms.Button cmdEtude;
        private System.Windows.Forms.Button cmdRelance;
        private System.Windows.Forms.Label label1;
    }
}

