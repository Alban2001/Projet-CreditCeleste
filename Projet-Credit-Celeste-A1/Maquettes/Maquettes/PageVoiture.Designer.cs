namespace Maquettes
{
    partial class PageVoiture
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
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtImmatVoiture = new System.Windows.Forms.TextBox();
            this.DateAchatVoiture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarqueVoiture = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModeleVoiture = new System.Windows.Forms.TextBox();
            this.cbxAnneeModele = new System.Windows.Forms.ComboBox();
            this.lblVdr = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontantVoiture = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(12, 66);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(157, 17);
            this.lblMontant.TabIndex = 15;
            this.lblMontant.Text = "Immatriculation voiture :";
            // 
            // txtImmatVoiture
            // 
            this.txtImmatVoiture.Location = new System.Drawing.Point(175, 66);
            this.txtImmatVoiture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImmatVoiture.Name = "txtImmatVoiture";
            this.txtImmatVoiture.Size = new System.Drawing.Size(230, 22);
            this.txtImmatVoiture.TabIndex = 14;
            // 
            // DateAchatVoiture
            // 
            this.DateAchatVoiture.Location = new System.Drawing.Point(175, 142);
            this.DateAchatVoiture.Name = "DateAchatVoiture";
            this.DateAchatVoiture.Size = new System.Drawing.Size(230, 22);
            this.DateAchatVoiture.TabIndex = 16;
            this.DateAchatVoiture.Value = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date d\'achat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Marque :";
            // 
            // txtMarqueVoiture
            // 
            this.txtMarqueVoiture.Location = new System.Drawing.Point(175, 183);
            this.txtMarqueVoiture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarqueVoiture.Name = "txtMarqueVoiture";
            this.txtMarqueVoiture.Size = new System.Drawing.Size(230, 22);
            this.txtMarqueVoiture.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Modèle :";
            // 
            // txtModeleVoiture
            // 
            this.txtModeleVoiture.Location = new System.Drawing.Point(175, 222);
            this.txtModeleVoiture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModeleVoiture.Name = "txtModeleVoiture";
            this.txtModeleVoiture.Size = new System.Drawing.Size(230, 22);
            this.txtModeleVoiture.TabIndex = 20;
            // 
            // cbxAnneeModele
            // 
            this.cbxAnneeModele.FormattingEnabled = true;
            this.cbxAnneeModele.Location = new System.Drawing.Point(175, 257);
            this.cbxAnneeModele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAnneeModele.Name = "cbxAnneeModele";
            this.cbxAnneeModele.Size = new System.Drawing.Size(137, 24);
            this.cbxAnneeModele.TabIndex = 67;
            // 
            // lblVdr
            // 
            this.lblVdr.AutoSize = true;
            this.lblVdr.Location = new System.Drawing.Point(42, 260);
            this.lblVdr.Name = "lblVdr";
            this.lblVdr.Size = new System.Drawing.Size(127, 17);
            this.lblVdr.TabIndex = 66;
            this.lblVdr.Text = "Année du modèle :";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(102, 352);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(133, 25);
            this.btnRetour.TabIndex = 65;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(272, 352);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(133, 25);
            this.btnValider.TabIndex = 64;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cbxClient
            // 
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(175, 293);
            this.cbxClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(230, 24);
            this.cbxClient.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "Client :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Montant voiture :";
            // 
            // txtMontantVoiture
            // 
            this.txtMontantVoiture.Location = new System.Drawing.Point(175, 103);
            this.txtMontantVoiture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontantVoiture.Name = "txtMontantVoiture";
            this.txtMontantVoiture.Size = new System.Drawing.Size(230, 22);
            this.txtMontantVoiture.TabIndex = 70;
            // 
            // PageVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontantVoiture);
            this.Controls.Add(this.cbxClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxAnneeModele);
            this.Controls.Add(this.lblVdr);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModeleVoiture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarqueVoiture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateAchatVoiture);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.txtImmatVoiture);
            this.Name = "PageVoiture";
            this.Text = "PageVoiture";
            this.Load += new System.EventHandler(this.PageVoiture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblMontant;
        internal System.Windows.Forms.TextBox txtImmatVoiture;
        private System.Windows.Forms.DateTimePicker DateAchatVoiture;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtMarqueVoiture;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtModeleVoiture;
        internal System.Windows.Forms.ComboBox cbxAnneeModele;
        private System.Windows.Forms.Label lblVdr;
        internal System.Windows.Forms.Button btnRetour;
        internal System.Windows.Forms.Button btnValider;
        internal System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtMontantVoiture;
    }
}