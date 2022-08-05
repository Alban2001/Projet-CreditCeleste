namespace Maquettes
{
    partial class ReparationVoiture
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
            this.cbxVoiture = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPiece = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculMontantpanne = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjoutFacture = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblMontantPanne = new System.Windows.Forms.Label();
            this.btnCreationFacture = new System.Windows.Forms.Button();
            this.gpbFacture = new System.Windows.Forms.GroupBox();
            this.lblMontantFacture = new System.Windows.Forms.Label();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpbFacture.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxVoiture
            // 
            this.cbxVoiture.FormattingEnabled = true;
            this.cbxVoiture.Location = new System.Drawing.Point(41, 121);
            this.cbxVoiture.Name = "cbxVoiture";
            this.cbxVoiture.Size = new System.Drawing.Size(291, 24);
            this.cbxVoiture.TabIndex = 0;
            this.cbxVoiture.SelectedIndexChanged += new System.EventHandler(this.cbxVoiture_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionner une voiture :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sélectionner une pièce :";
            // 
            // cbxPiece
            // 
            this.cbxPiece.FormattingEnabled = true;
            this.cbxPiece.Location = new System.Drawing.Point(41, 178);
            this.cbxPiece.Name = "cbxPiece";
            this.cbxPiece.Size = new System.Drawing.Size(291, 24);
            this.cbxPiece.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Montant de la panne :";
            // 
            // btnCalculMontantpanne
            // 
            this.btnCalculMontantpanne.Location = new System.Drawing.Point(337, 219);
            this.btnCalculMontantpanne.Name = "btnCalculMontantpanne";
            this.btnCalculMontantpanne.Size = new System.Drawing.Size(75, 23);
            this.btnCalculMontantpanne.TabIndex = 5;
            this.btnCalculMontantpanne.Text = "Calcul montant panne";
            this.btnCalculMontantpanne.UseVisualStyleBackColor = true;
            this.btnCalculMontantpanne.Click += new System.EventHandler(this.btnCalculMontantpanne_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Montant de la facture";
            // 
            // btnAjoutFacture
            // 
            this.btnAjoutFacture.Location = new System.Drawing.Point(112, 309);
            this.btnAjoutFacture.Name = "btnAjoutFacture";
            this.btnAjoutFacture.Size = new System.Drawing.Size(75, 50);
            this.btnAjoutFacture.TabIndex = 9;
            this.btnAjoutFacture.Text = "Ajouter à la facture";
            this.btnAjoutFacture.UseVisualStyleBackColor = true;
            this.btnAjoutFacture.Click += new System.EventHandler(this.btnAjoutFacture_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(222, 309);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 50);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblMontantPanne
            // 
            this.lblMontantPanne.AutoSize = true;
            this.lblMontantPanne.Location = new System.Drawing.Point(194, 225);
            this.lblMontantPanne.Name = "lblMontantPanne";
            this.lblMontantPanne.Size = new System.Drawing.Size(104, 17);
            this.lblMontantPanne.TabIndex = 11;
            this.lblMontantPanne.Text = "Montant Panne";
            // 
            // btnCreationFacture
            // 
            this.btnCreationFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreationFacture.Location = new System.Drawing.Point(133, 12);
            this.btnCreationFacture.Name = "btnCreationFacture";
            this.btnCreationFacture.Size = new System.Drawing.Size(276, 40);
            this.btnCreationFacture.TabIndex = 12;
            this.btnCreationFacture.Text = "Créer une facture";
            this.btnCreationFacture.UseVisualStyleBackColor = true;
            this.btnCreationFacture.Click += new System.EventHandler(this.btnCreationFacture_Click);
            // 
            // gpbFacture
            // 
            this.gpbFacture.Controls.Add(this.lblMontantFacture);
            this.gpbFacture.Controls.Add(this.cbxClient);
            this.gpbFacture.Controls.Add(this.label5);
            this.gpbFacture.Controls.Add(this.lblMontantPanne);
            this.gpbFacture.Controls.Add(this.cbxVoiture);
            this.gpbFacture.Controls.Add(this.label1);
            this.gpbFacture.Controls.Add(this.btnValider);
            this.gpbFacture.Controls.Add(this.cbxPiece);
            this.gpbFacture.Controls.Add(this.btnAjoutFacture);
            this.gpbFacture.Controls.Add(this.label2);
            this.gpbFacture.Controls.Add(this.label3);
            this.gpbFacture.Controls.Add(this.label4);
            this.gpbFacture.Controls.Add(this.btnCalculMontantpanne);
            this.gpbFacture.Location = new System.Drawing.Point(12, 58);
            this.gpbFacture.Name = "gpbFacture";
            this.gpbFacture.Size = new System.Drawing.Size(525, 376);
            this.gpbFacture.TabIndex = 13;
            this.gpbFacture.TabStop = false;
            this.gpbFacture.Text = "Facture";
            this.gpbFacture.Enter += new System.EventHandler(this.gpbFacture_Enter);
            // 
            // lblMontantFacture
            // 
            this.lblMontantFacture.AutoSize = true;
            this.lblMontantFacture.Location = new System.Drawing.Point(194, 262);
            this.lblMontantFacture.Name = "lblMontantFacture";
            this.lblMontantFacture.Size = new System.Drawing.Size(16, 17);
            this.lblMontantFacture.TabIndex = 14;
            this.lblMontantFacture.Text = "0";
            this.lblMontantFacture.Click += new System.EventHandler(this.lblMontantFacture_Click_1);
            // 
            // cbxClient
            // 
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(41, 62);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(291, 24);
            this.cbxClient.TabIndex = 12;
            this.cbxClient.SelectedIndexChanged += new System.EventHandler(this.cbxClient_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sélectionner un client :";
            // 
            // ReparationVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 446);
            this.Controls.Add(this.gpbFacture);
            this.Controls.Add(this.btnCreationFacture);
            this.Name = "ReparationVoiture";
            this.Text = "ReparationVoiture";
            this.Load += new System.EventHandler(this.ReparationVoiture_Load);
            this.gpbFacture.ResumeLayout(false);
            this.gpbFacture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxVoiture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPiece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculMontantpanne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAjoutFacture;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblMontantPanne;
        private System.Windows.Forms.Button btnCreationFacture;
        private System.Windows.Forms.GroupBox gpbFacture;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMontantFacture;
    }
}