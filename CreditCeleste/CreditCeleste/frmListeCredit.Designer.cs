
namespace CreditCeleste
{
    partial class frmListeCredit
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
            this.lsbCredit = new System.Windows.Forms.ListBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbCredit
            // 
            this.lsbCredit.FormattingEnabled = true;
            this.lsbCredit.ItemHeight = 16;
            this.lsbCredit.Location = new System.Drawing.Point(66, 52);
            this.lsbCredit.Name = "lsbCredit";
            this.lsbCredit.Size = new System.Drawing.Size(489, 84);
            this.lsbCredit.TabIndex = 0;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(132, 227);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 31);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(246, 227);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(75, 31);
            this.btnCredit.TabIndex = 3;
            this.btnCredit.Text = "Credit";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(358, 227);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(89, 31);
            this.btnEnregistre.TabIndex = 4;
            this.btnEnregistre.Text = "Enregistre";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            this.btnEnregistre.Click += new System.EventHandler(this.btnEnregistre_Click);
            // 
            // frmListeCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.btnEnregistre);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.lsbCredit);
            this.Name = "frmListeCredit";
            this.Text = "frmListeCredit";
            this.Load += new System.EventHandler(this.frmListeCredit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbCredit;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnEnregistre;
    }
}