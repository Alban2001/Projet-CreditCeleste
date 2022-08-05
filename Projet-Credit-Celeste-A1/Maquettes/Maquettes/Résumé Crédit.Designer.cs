namespace Maquettes
{
    partial class Résumé_Crédit
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblMens = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnRetSim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listDateDebutCredit = new System.Windows.Forms.ListBox();
            this.listMontantCredit = new System.Windows.Forms.ListBox();
            this.listDureeCredit = new System.Windows.Forms.ListBox();
            this.listTauxCredit = new System.Windows.Forms.ListBox();
            this.listMensualiteCredit = new System.Windows.Forms.ListBox();
            this.listDateFinCredit = new System.Windows.Forms.ListBox();
            this.listRevenusVendeur = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumCredit = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(286, 336);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(92, 25);
            this.btnQuitter.TabIndex = 41;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.cmdListeCredit_Click);
            // 
            // lblMens
            // 
            this.lblMens.AutoSize = true;
            this.lblMens.Location = new System.Drawing.Point(156, 233);
            this.lblMens.Name = "lblMens";
            this.lblMens.Size = new System.Drawing.Size(76, 17);
            this.lblMens.TabIndex = 40;
            this.lblMens.Text = "Mensualité";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(146, 207);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(86, 17);
            this.Label3.TabIndex = 39;
            this.Label3.Text = "Taux annuel";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(132, 181);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 17);
            this.Label2.TabIndex = 38;
            this.Label2.Text = "Durée en mois";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(112, 152);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 17);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "Montant du Crédit";
            // 
            // btnRetSim
            // 
            this.btnRetSim.Location = new System.Drawing.Point(74, 336);
            this.btnRetSim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetSim.Name = "btnRetSim";
            this.btnRetSim.Size = new System.Drawing.Size(158, 25);
            this.btnRetSim.TabIndex = 36;
            this.btnRetSim.Text = "Retour à la simulation";
            this.btnRetSim.UseVisualStyleBackColor = true;
            this.btnRetSim.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Crédit N°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Début du contrat";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(137, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 50;
            this.label13.Text = "Fin du contrat";
            // 
            // listDateDebutCredit
            // 
            this.listDateDebutCredit.FormattingEnabled = true;
            this.listDateDebutCredit.ItemHeight = 16;
            this.listDateDebutCredit.Location = new System.Drawing.Point(250, 122);
            this.listDateDebutCredit.Name = "listDateDebutCredit";
            this.listDateDebutCredit.Size = new System.Drawing.Size(128, 20);
            this.listDateDebutCredit.TabIndex = 58;
            // 
            // listMontantCredit
            // 
            this.listMontantCredit.FormattingEnabled = true;
            this.listMontantCredit.ItemHeight = 16;
            this.listMontantCredit.Location = new System.Drawing.Point(250, 149);
            this.listMontantCredit.Name = "listMontantCredit";
            this.listMontantCredit.Size = new System.Drawing.Size(128, 20);
            this.listMontantCredit.TabIndex = 59;
            // 
            // listDureeCredit
            // 
            this.listDureeCredit.FormattingEnabled = true;
            this.listDureeCredit.ItemHeight = 16;
            this.listDureeCredit.Location = new System.Drawing.Point(250, 178);
            this.listDureeCredit.Name = "listDureeCredit";
            this.listDureeCredit.Size = new System.Drawing.Size(128, 20);
            this.listDureeCredit.TabIndex = 60;
            // 
            // listTauxCredit
            // 
            this.listTauxCredit.FormattingEnabled = true;
            this.listTauxCredit.ItemHeight = 16;
            this.listTauxCredit.Location = new System.Drawing.Point(250, 204);
            this.listTauxCredit.Name = "listTauxCredit";
            this.listTauxCredit.Size = new System.Drawing.Size(128, 20);
            this.listTauxCredit.TabIndex = 61;
            // 
            // listMensualiteCredit
            // 
            this.listMensualiteCredit.FormattingEnabled = true;
            this.listMensualiteCredit.ItemHeight = 16;
            this.listMensualiteCredit.Location = new System.Drawing.Point(250, 230);
            this.listMensualiteCredit.Name = "listMensualiteCredit";
            this.listMensualiteCredit.Size = new System.Drawing.Size(128, 20);
            this.listMensualiteCredit.TabIndex = 62;
            // 
            // listDateFinCredit
            // 
            this.listDateFinCredit.FormattingEnabled = true;
            this.listDateFinCredit.ItemHeight = 16;
            this.listDateFinCredit.Location = new System.Drawing.Point(250, 282);
            this.listDateFinCredit.Name = "listDateFinCredit";
            this.listDateFinCredit.Size = new System.Drawing.Size(128, 20);
            this.listDateFinCredit.TabIndex = 63;
            // 
            // listRevenusVendeur
            // 
            this.listRevenusVendeur.FormattingEnabled = true;
            this.listRevenusVendeur.ItemHeight = 16;
            this.listRevenusVendeur.Location = new System.Drawing.Point(250, 256);
            this.listRevenusVendeur.Name = "listRevenusVendeur";
            this.listRevenusVendeur.Size = new System.Drawing.Size(128, 20);
            this.listRevenusVendeur.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Revenus Vendeur";
            // 
            // txtNumCredit
            // 
            this.txtNumCredit.FormattingEnabled = true;
            this.txtNumCredit.ItemHeight = 16;
            this.txtNumCredit.Location = new System.Drawing.Point(250, 73);
            this.txtNumCredit.Name = "txtNumCredit";
            this.txtNumCredit.Size = new System.Drawing.Size(84, 20);
            this.txtNumCredit.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "€";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "Mois";
            // 
            // Résumé_Crédit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 405);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumCredit);
            this.Controls.Add(this.listRevenusVendeur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listDateFinCredit);
            this.Controls.Add(this.listMensualiteCredit);
            this.Controls.Add(this.listTauxCredit);
            this.Controls.Add(this.listDureeCredit);
            this.Controls.Add(this.listMontantCredit);
            this.Controls.Add(this.listDateDebutCredit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblMens);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnRetSim);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Résumé_Crédit";
            this.Text = "Résumé_Crédit";
            this.Load += new System.EventHandler(this.Résumé_Crédit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnQuitter;
        internal System.Windows.Forms.Label lblMens;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnRetSim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listDateDebutCredit;
        private System.Windows.Forms.ListBox listMontantCredit;
        private System.Windows.Forms.ListBox listDureeCredit;
        private System.Windows.Forms.ListBox listTauxCredit;
        private System.Windows.Forms.ListBox listMensualiteCredit;
        private System.Windows.Forms.ListBox listDateFinCredit;
        private System.Windows.Forms.ListBox listRevenusVendeur;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox txtNumCredit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}