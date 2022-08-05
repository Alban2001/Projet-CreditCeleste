namespace Maquettes
{
    partial class PagePrincipale
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
            this.components = new System.ComponentModel.Container();
            this.btnValidationPrinc = new System.Windows.Forms.Button();
            this.txtMensualite = new System.Windows.Forms.TextBox();
            this.cbxDuree = new System.Windows.Forms.ComboBox();
            this.lblMens = new System.Windows.Forms.Label();
            this.lblTaux = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.btnDeconnexionPP = new System.Windows.Forms.Button();
            this.btnRetourPrinc = new System.Windows.Forms.Button();
            this.cbxTauxCredit = new System.Windows.Forms.ComboBox();
            this.lblVdr = new System.Windows.Forms.Label();
            this.cbxVendeur = new System.Windows.Forms.ComboBox();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.creditCelesteA1DataSet = new Maquettes.CreditCelesteA1DataSet();
            this.creditCelesteA1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxVoiture = new System.Windows.Forms.ComboBox();
            this.lblVoiture1 = new System.Windows.Forms.Label();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.listMontantCredit = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.creditCelesteA1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCelesteA1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidationPrinc
            // 
            this.btnValidationPrinc.Location = new System.Drawing.Point(443, 177);
            this.btnValidationPrinc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidationPrinc.Name = "btnValidationPrinc";
            this.btnValidationPrinc.Size = new System.Drawing.Size(133, 25);
            this.btnValidationPrinc.TabIndex = 20;
            this.btnValidationPrinc.Text = "Validation";
            this.btnValidationPrinc.UseVisualStyleBackColor = true;
            this.btnValidationPrinc.Click += new System.EventHandler(this.btnValidationPrinc_Click);
            // 
            // txtMensualite
            // 
            this.txtMensualite.Location = new System.Drawing.Point(138, 178);
            this.txtMensualite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMensualite.Name = "txtMensualite";
            this.txtMensualite.Size = new System.Drawing.Size(160, 22);
            this.txtMensualite.TabIndex = 19;
            // 
            // cbxDuree
            // 
            this.cbxDuree.FormattingEnabled = true;
            this.cbxDuree.Location = new System.Drawing.Point(161, 130);
            this.cbxDuree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDuree.Name = "cbxDuree";
            this.cbxDuree.Size = new System.Drawing.Size(137, 24);
            this.cbxDuree.TabIndex = 18;
            // 
            // lblMens
            // 
            this.lblMens.AutoSize = true;
            this.lblMens.Location = new System.Drawing.Point(55, 181);
            this.lblMens.Name = "lblMens";
            this.lblMens.Size = new System.Drawing.Size(76, 17);
            this.lblMens.TabIndex = 17;
            this.lblMens.Text = "Mensualité";
            // 
            // lblTaux
            // 
            this.lblTaux.AutoSize = true;
            this.lblTaux.Location = new System.Drawing.Point(69, 86);
            this.lblTaux.Name = "lblTaux";
            this.lblTaux.Size = new System.Drawing.Size(86, 17);
            this.lblTaux.TabIndex = 16;
            this.lblTaux.Text = "Taux annuel";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(55, 133);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(100, 17);
            this.lblDuree.TabIndex = 14;
            this.lblDuree.Text = "Durée en mois";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(12, 37);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(120, 17);
            this.lblMontant.TabIndex = 13;
            this.lblMontant.Text = "Montant du Crédit";
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Location = new System.Drawing.Point(304, 177);
            this.cmdCalcul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(133, 25);
            this.cmdCalcul.TabIndex = 11;
            this.cmdCalcul.Text = "Calcul";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // btnDeconnexionPP
            // 
            this.btnDeconnexionPP.Location = new System.Drawing.Point(614, 323);
            this.btnDeconnexionPP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeconnexionPP.Name = "btnDeconnexionPP";
            this.btnDeconnexionPP.Size = new System.Drawing.Size(115, 25);
            this.btnDeconnexionPP.TabIndex = 42;
            this.btnDeconnexionPP.Text = "Déconnexion";
            this.btnDeconnexionPP.UseVisualStyleBackColor = true;
            this.btnDeconnexionPP.Click += new System.EventHandler(this.btnDeconnexionPP_Click);
            // 
            // btnRetourPrinc
            // 
            this.btnRetourPrinc.Location = new System.Drawing.Point(629, 294);
            this.btnRetourPrinc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetourPrinc.Name = "btnRetourPrinc";
            this.btnRetourPrinc.Size = new System.Drawing.Size(100, 25);
            this.btnRetourPrinc.TabIndex = 60;
            this.btnRetourPrinc.Text = "Retour";
            this.btnRetourPrinc.UseVisualStyleBackColor = true;
            this.btnRetourPrinc.Click += new System.EventHandler(this.btnRetourPrinc_Click);
            // 
            // cbxTauxCredit
            // 
            this.cbxTauxCredit.FormattingEnabled = true;
            this.cbxTauxCredit.Location = new System.Drawing.Point(161, 81);
            this.cbxTauxCredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTauxCredit.Name = "cbxTauxCredit";
            this.cbxTauxCredit.Size = new System.Drawing.Size(137, 24);
            this.cbxTauxCredit.TabIndex = 61;
            // 
            // lblVdr
            // 
            this.lblVdr.AutoSize = true;
            this.lblVdr.Location = new System.Drawing.Point(15, 227);
            this.lblVdr.Name = "lblVdr";
            this.lblVdr.Size = new System.Drawing.Size(62, 17);
            this.lblVdr.TabIndex = 62;
            this.lblVdr.Text = "Vendeur";
            // 
            // cbxVendeur
            // 
            this.cbxVendeur.FormattingEnabled = true;
            this.cbxVendeur.Location = new System.Drawing.Point(83, 223);
            this.cbxVendeur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxVendeur.Name = "cbxVendeur";
            this.cbxVendeur.Size = new System.Drawing.Size(215, 24);
            this.cbxVendeur.TabIndex = 63;
            // 
            // cbxClient
            // 
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(83, 266);
            this.cbxClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(215, 24);
            this.cbxClient.TabIndex = 65;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(34, 269);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 17);
            this.lblClient.TabIndex = 64;
            this.lblClient.Text = "Client";
            // 
            // creditCelesteA1DataSet
            // 
            this.creditCelesteA1DataSet.DataSetName = "CreditCelesteA1DataSet";
            this.creditCelesteA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // creditCelesteA1DataSetBindingSource
            // 
            this.creditCelesteA1DataSetBindingSource.DataSource = this.creditCelesteA1DataSet;
            this.creditCelesteA1DataSetBindingSource.Position = 0;
            // 
            // cbxVoiture
            // 
            this.cbxVoiture.FormattingEnabled = true;
            this.cbxVoiture.Location = new System.Drawing.Point(83, 306);
            this.cbxVoiture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxVoiture.Name = "cbxVoiture";
            this.cbxVoiture.Size = new System.Drawing.Size(354, 24);
            this.cbxVoiture.TabIndex = 67;
            this.cbxVoiture.Visible = false;
            // 
            // lblVoiture1
            // 
            this.lblVoiture1.AutoSize = true;
            this.lblVoiture1.Location = new System.Drawing.Point(24, 306);
            this.lblVoiture1.Name = "lblVoiture1";
            this.lblVoiture1.Size = new System.Drawing.Size(53, 17);
            this.lblVoiture1.TabIndex = 66;
            this.lblVoiture1.Text = "Voiture";
            this.lblVoiture1.Visible = false;
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.Location = new System.Drawing.Point(443, 305);
            this.btnInitialiser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(133, 25);
            this.btnInitialiser.TabIndex = 70;
            this.btnInitialiser.Text = "Initialiser";
            this.btnInitialiser.UseVisualStyleBackColor = true;
            this.btnInitialiser.Click += new System.EventHandler(this.btnInitialiser_Click);
            // 
            // listMontantCredit
            // 
            this.listMontantCredit.FormattingEnabled = true;
            this.listMontantCredit.ItemHeight = 16;
            this.listMontantCredit.Location = new System.Drawing.Point(138, 37);
            this.listMontantCredit.Name = "listMontantCredit";
            this.listMontantCredit.Size = new System.Drawing.Size(160, 20);
            this.listMontantCredit.TabIndex = 71;
            this.listMontantCredit.SelectedIndexChanged += new System.EventHandler(this.listMontantCredit_SelectedIndexChanged);
            // 
            // PagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 359);
            this.Controls.Add(this.listMontantCredit);
            this.Controls.Add(this.btnInitialiser);
            this.Controls.Add(this.cbxVoiture);
            this.Controls.Add(this.lblVoiture1);
            this.Controls.Add(this.cbxClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.cbxVendeur);
            this.Controls.Add(this.lblVdr);
            this.Controls.Add(this.cbxTauxCredit);
            this.Controls.Add(this.btnRetourPrinc);
            this.Controls.Add(this.btnDeconnexionPP);
            this.Controls.Add(this.btnValidationPrinc);
            this.Controls.Add(this.txtMensualite);
            this.Controls.Add(this.cbxDuree);
            this.Controls.Add(this.lblMens);
            this.Controls.Add(this.lblTaux);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.cmdCalcul);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PagePrincipale";
            this.Text = " PagePrincipale";
            this.Load += new System.EventHandler(this.PagePrincipale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditCelesteA1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditCelesteA1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnValidationPrinc;
        internal System.Windows.Forms.TextBox txtMensualite;
        internal System.Windows.Forms.ComboBox cbxDuree;
        internal System.Windows.Forms.Label lblMens;
        internal System.Windows.Forms.Label lblTaux;
        internal System.Windows.Forms.Label lblDuree;
        internal System.Windows.Forms.Label lblMontant;
        internal System.Windows.Forms.Button cmdCalcul;
        internal System.Windows.Forms.Button btnDeconnexionPP;
        internal System.Windows.Forms.Button btnRetourPrinc;
        internal System.Windows.Forms.ComboBox cbxTauxCredit;
        private System.Windows.Forms.Label lblVdr;
        internal System.Windows.Forms.ComboBox cbxVendeur;
        internal System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.BindingSource creditCelesteA1DataSetBindingSource;
        private CreditCelesteA1DataSet creditCelesteA1DataSet;
        internal System.Windows.Forms.ComboBox cbxVoiture;
        private System.Windows.Forms.Label lblVoiture1;
        internal System.Windows.Forms.Button btnInitialiser;
        private System.Windows.Forms.ListBox listMontantCredit;
    }
}