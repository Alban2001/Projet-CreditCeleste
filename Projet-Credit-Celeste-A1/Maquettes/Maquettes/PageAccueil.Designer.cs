namespace Maquettes
{
    partial class PageAccueil
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjoutCredit = new System.Windows.Forms.Button();
            this.btnAffichageCredits = new System.Windows.Forms.Button();
            this.btnAjoutPers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReparationVoiture = new System.Windows.Forms.Button();
            this.btnAjoutPieces = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(177, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREDIT CELESTE";
            // 
            // btnAjoutCredit
            // 
            this.btnAjoutCredit.Location = new System.Drawing.Point(177, 188);
            this.btnAjoutCredit.Name = "btnAjoutCredit";
            this.btnAjoutCredit.Size = new System.Drawing.Size(140, 44);
            this.btnAjoutCredit.TabIndex = 2;
            this.btnAjoutCredit.Text = "Ajouter un crédit";
            this.btnAjoutCredit.UseVisualStyleBackColor = true;
            this.btnAjoutCredit.Click += new System.EventHandler(this.btnAjoutCredit_Click);
            // 
            // btnAffichageCredits
            // 
            this.btnAffichageCredits.Location = new System.Drawing.Point(177, 276);
            this.btnAffichageCredits.Name = "btnAffichageCredits";
            this.btnAffichageCredits.Size = new System.Drawing.Size(140, 44);
            this.btnAffichageCredits.TabIndex = 69;
            this.btnAffichageCredits.Text = "Afficher les crédits";
            this.btnAffichageCredits.UseVisualStyleBackColor = true;
            this.btnAffichageCredits.Click += new System.EventHandler(this.btnAffichageCredits_Click);
            // 
            // btnAjoutPers
            // 
            this.btnAjoutPers.Location = new System.Drawing.Point(366, 188);
            this.btnAjoutPers.Name = "btnAjoutPers";
            this.btnAjoutPers.Size = new System.Drawing.Size(217, 44);
            this.btnAjoutPers.TabIndex = 68;
            this.btnAjoutPers.Text = "Ajouter un client ou un vendeur";
            this.btnAjoutPers.UseVisualStyleBackColor = true;
            this.btnAjoutPers.Click += new System.EventHandler(this.btnAjoutPers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 44);
            this.button1.TabIndex = 70;
            this.button1.Text = "Ajouter une voiture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReparationVoiture
            // 
            this.btnReparationVoiture.Location = new System.Drawing.Point(366, 351);
            this.btnReparationVoiture.Name = "btnReparationVoiture";
            this.btnReparationVoiture.Size = new System.Drawing.Size(217, 44);
            this.btnReparationVoiture.TabIndex = 72;
            this.btnReparationVoiture.Text = "Réparer une voiture";
            this.btnReparationVoiture.UseVisualStyleBackColor = true;
            this.btnReparationVoiture.Click += new System.EventHandler(this.btnReparationVoiture_Click);
            // 
            // btnAjoutPieces
            // 
            this.btnAjoutPieces.Location = new System.Drawing.Point(177, 351);
            this.btnAjoutPieces.Name = "btnAjoutPieces";
            this.btnAjoutPieces.Size = new System.Drawing.Size(140, 44);
            this.btnAjoutPieces.TabIndex = 71;
            this.btnAjoutPieces.Text = "Ajouter des pièces";
            this.btnAjoutPieces.UseVisualStyleBackColor = true;
            this.btnAjoutPieces.Click += new System.EventHandler(this.btnAjoutPieces_Click);
            // 
            // PageAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReparationVoiture);
            this.Controls.Add(this.btnAjoutPieces);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAffichageCredits);
            this.Controls.Add(this.btnAjoutPers);
            this.Controls.Add(this.btnAjoutCredit);
            this.Controls.Add(this.label1);
            this.Name = "PageAccueil";
            this.Text = "PageAccueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjoutCredit;
        private System.Windows.Forms.Button btnAffichageCredits;
        private System.Windows.Forms.Button btnAjoutPers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReparationVoiture;
        private System.Windows.Forms.Button btnAjoutPieces;
    }
}