namespace Maquettes
{
    partial class Validation
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
            this.btnConfirmationValid = new System.Windows.Forms.Button();
            this.lblMensualite = new System.Windows.Forms.Label();
            this.lblTauxCredit = new System.Windows.Forms.Label();
            this.lblDureeCredit = new System.Windows.Forms.Label();
            this.lblMontantCredit = new System.Windows.Forms.Label();
            this.btnRetourValid = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.listMontantCredit = new System.Windows.Forms.ListBox();
            this.listDureeCredit = new System.Windows.Forms.ListBox();
            this.listTauxCredit = new System.Windows.Forms.ListBox();
            this.listMensualiteCredit = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConfirmationValid
            // 
            this.btnConfirmationValid.Location = new System.Drawing.Point(384, 318);
            this.btnConfirmationValid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmationValid.Name = "btnConfirmationValid";
            this.btnConfirmationValid.Size = new System.Drawing.Size(133, 25);
            this.btnConfirmationValid.TabIndex = 30;
            this.btnConfirmationValid.Text = "Confirmation";
            this.btnConfirmationValid.UseVisualStyleBackColor = true;
            this.btnConfirmationValid.Click += new System.EventHandler(this.btnConfirmationValid_Click);
            // 
            // lblMensualite
            // 
            this.lblMensualite.AutoSize = true;
            this.lblMensualite.Location = new System.Drawing.Point(561, 140);
            this.lblMensualite.Name = "lblMensualite";
            this.lblMensualite.Size = new System.Drawing.Size(76, 17);
            this.lblMensualite.TabIndex = 27;
            this.lblMensualite.Text = "Mensualité";
            // 
            // lblTauxCredit
            // 
            this.lblTauxCredit.AutoSize = true;
            this.lblTauxCredit.Location = new System.Drawing.Point(380, 140);
            this.lblTauxCredit.Name = "lblTauxCredit";
            this.lblTauxCredit.Size = new System.Drawing.Size(86, 17);
            this.lblTauxCredit.TabIndex = 26;
            this.lblTauxCredit.Text = "Taux annuel";
            // 
            // lblDureeCredit
            // 
            this.lblDureeCredit.AutoSize = true;
            this.lblDureeCredit.Location = new System.Drawing.Point(221, 140);
            this.lblDureeCredit.Name = "lblDureeCredit";
            this.lblDureeCredit.Size = new System.Drawing.Size(100, 17);
            this.lblDureeCredit.TabIndex = 24;
            this.lblDureeCredit.Text = "Durée en mois";
            // 
            // lblMontantCredit
            // 
            this.lblMontantCredit.AutoSize = true;
            this.lblMontantCredit.Location = new System.Drawing.Point(47, 140);
            this.lblMontantCredit.Name = "lblMontantCredit";
            this.lblMontantCredit.Size = new System.Drawing.Size(120, 17);
            this.lblMontantCredit.TabIndex = 23;
            this.lblMontantCredit.Text = "Montant du Crédit";
            this.lblMontantCredit.Click += new System.EventHandler(this.lblMontantCredit_Click);
            // 
            // btnRetourValid
            // 
            this.btnRetourValid.Location = new System.Drawing.Point(188, 318);
            this.btnRetourValid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetourValid.Name = "btnRetourValid";
            this.btnRetourValid.Size = new System.Drawing.Size(133, 25);
            this.btnRetourValid.TabIndex = 21;
            this.btnRetourValid.Text = "Retour";
            this.btnRetourValid.UseVisualStyleBackColor = true;
            this.btnRetourValid.Click += new System.EventHandler(this.btnRetourValid_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Etes vous sur des valeurs ?";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(592, 326);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(108, 25);
            this.btnQuitter.TabIndex = 42;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // listMontantCredit
            // 
            this.listMontantCredit.FormattingEnabled = true;
            this.listMontantCredit.ItemHeight = 16;
            this.listMontantCredit.Location = new System.Drawing.Point(37, 192);
            this.listMontantCredit.Margin = new System.Windows.Forms.Padding(4);
            this.listMontantCredit.Name = "listMontantCredit";
            this.listMontantCredit.Size = new System.Drawing.Size(129, 20);
            this.listMontantCredit.TabIndex = 43;
            // 
            // listDureeCredit
            // 
            this.listDureeCredit.FormattingEnabled = true;
            this.listDureeCredit.ItemHeight = 16;
            this.listDureeCredit.Location = new System.Drawing.Point(207, 192);
            this.listDureeCredit.Margin = new System.Windows.Forms.Padding(4);
            this.listDureeCredit.Name = "listDureeCredit";
            this.listDureeCredit.Size = new System.Drawing.Size(113, 20);
            this.listDureeCredit.TabIndex = 44;
            // 
            // listTauxCredit
            // 
            this.listTauxCredit.FormattingEnabled = true;
            this.listTauxCredit.ItemHeight = 16;
            this.listTauxCredit.Location = new System.Drawing.Point(353, 192);
            this.listTauxCredit.Margin = new System.Windows.Forms.Padding(4);
            this.listTauxCredit.Name = "listTauxCredit";
            this.listTauxCredit.Size = new System.Drawing.Size(119, 20);
            this.listTauxCredit.TabIndex = 45;
            // 
            // listMensualiteCredit
            // 
            this.listMensualiteCredit.FormattingEnabled = true;
            this.listMensualiteCredit.ItemHeight = 16;
            this.listMensualiteCredit.Location = new System.Drawing.Point(523, 192);
            this.listMensualiteCredit.Margin = new System.Windows.Forms.Padding(4);
            this.listMensualiteCredit.Name = "listMensualiteCredit";
            this.listMensualiteCredit.Size = new System.Drawing.Size(133, 20);
            this.listMensualiteCredit.TabIndex = 46;
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 358);
            this.Controls.Add(this.listMensualiteCredit);
            this.Controls.Add(this.listTauxCredit);
            this.Controls.Add(this.listDureeCredit);
            this.Controls.Add(this.listMontantCredit);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnConfirmationValid);
            this.Controls.Add(this.lblMensualite);
            this.Controls.Add(this.lblTauxCredit);
            this.Controls.Add(this.lblDureeCredit);
            this.Controls.Add(this.lblMontantCredit);
            this.Controls.Add(this.btnRetourValid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Validation";
            this.Text = "Validation";
            this.Load += new System.EventHandler(this.Validation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnConfirmationValid;
        internal System.Windows.Forms.Label lblMensualite;
        internal System.Windows.Forms.Label lblTauxCredit;
        internal System.Windows.Forms.Label lblDureeCredit;
        internal System.Windows.Forms.Label lblMontantCredit;
        internal System.Windows.Forms.Button btnRetourValid;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListBox listMontantCredit;
        private System.Windows.Forms.ListBox listDureeCredit;
        private System.Windows.Forms.ListBox listTauxCredit;
        private System.Windows.Forms.ListBox listMensualiteCredit;
    }
}