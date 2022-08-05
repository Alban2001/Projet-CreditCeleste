namespace Maquettes
{
    partial class Résumé_AjoutVendeur
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.listPrenomVendeur = new System.Windows.Forms.ListBox();
            this.listNomVendeur = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listSalaireVendeur = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(235, 229);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 13;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(123, 229);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // listPrenomVendeur
            // 
            this.listPrenomVendeur.FormattingEnabled = true;
            this.listPrenomVendeur.ItemHeight = 16;
            this.listPrenomVendeur.Location = new System.Drawing.Point(191, 123);
            this.listPrenomVendeur.Name = "listPrenomVendeur";
            this.listPrenomVendeur.Size = new System.Drawing.Size(120, 20);
            this.listPrenomVendeur.TabIndex = 11;
            // 
            // listNomVendeur
            // 
            this.listNomVendeur.FormattingEnabled = true;
            this.listNomVendeur.ItemHeight = 16;
            this.listNomVendeur.Location = new System.Drawing.Point(191, 74);
            this.listNomVendeur.Name = "listNomVendeur";
            this.listNomVendeur.Size = new System.Drawing.Size(120, 20);
            this.listNomVendeur.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prénom : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Etes-vous sur des valeurs du vendeur ?";
            // 
            // listSalaireVendeur
            // 
            this.listSalaireVendeur.FormattingEnabled = true;
            this.listSalaireVendeur.ItemHeight = 16;
            this.listSalaireVendeur.Location = new System.Drawing.Point(191, 173);
            this.listSalaireVendeur.Name = "listSalaireVendeur";
            this.listSalaireVendeur.Size = new System.Drawing.Size(120, 20);
            this.listSalaireVendeur.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Salaire / mois :";
            // 
            // Résumé_AjoutVendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 291);
            this.Controls.Add(this.listSalaireVendeur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.listPrenomVendeur);
            this.Controls.Add(this.listNomVendeur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Résumé_AjoutVendeur";
            this.Text = "Résumé_AjoutVendeur";
            this.Load += new System.EventHandler(this.Résumé_AjoutVendeur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListBox listPrenomVendeur;
        private System.Windows.Forms.ListBox listNomVendeur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listSalaireVendeur;
        private System.Windows.Forms.Label label4;
    }
}