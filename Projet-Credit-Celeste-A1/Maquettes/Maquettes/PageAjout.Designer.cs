namespace Maquettes
{
    partial class PageAjout
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.txtPrenomClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAjoutClient = new System.Windows.Forms.Button();
            this.btnAjoutVendeur = new System.Windows.Forms.Button();
            this.txtPrenomVendeur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomVendeur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalaireVendeur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout d\'un client ou d\'un vendeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendeur : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom : ";
            // 
            // txtNomClient
            // 
            this.txtNomClient.Location = new System.Drawing.Point(76, 122);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(123, 22);
            this.txtNomClient.TabIndex = 4;
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.Location = new System.Drawing.Point(278, 122);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.Size = new System.Drawing.Size(133, 22);
            this.txtPrenomClient.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prenom : ";
            // 
            // btnAjoutClient
            // 
            this.btnAjoutClient.Location = new System.Drawing.Point(430, 117);
            this.btnAjoutClient.Name = "btnAjoutClient";
            this.btnAjoutClient.Size = new System.Drawing.Size(128, 32);
            this.btnAjoutClient.TabIndex = 7;
            this.btnAjoutClient.Text = "Ajouter un client";
            this.btnAjoutClient.UseVisualStyleBackColor = true;
            this.btnAjoutClient.Click += new System.EventHandler(this.btnAjoutClient_Click);
            // 
            // btnAjoutVendeur
            // 
            this.btnAjoutVendeur.Location = new System.Drawing.Point(696, 230);
            this.btnAjoutVendeur.Name = "btnAjoutVendeur";
            this.btnAjoutVendeur.Size = new System.Drawing.Size(138, 43);
            this.btnAjoutVendeur.TabIndex = 12;
            this.btnAjoutVendeur.Text = "Ajouter un vendeur";
            this.btnAjoutVendeur.UseVisualStyleBackColor = true;
            this.btnAjoutVendeur.Click += new System.EventHandler(this.btnAjoutVendeur_Click);
            // 
            // txtPrenomVendeur
            // 
            this.txtPrenomVendeur.Location = new System.Drawing.Point(278, 240);
            this.txtPrenomVendeur.Name = "txtPrenomVendeur";
            this.txtPrenomVendeur.Size = new System.Drawing.Size(133, 22);
            this.txtPrenomVendeur.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prenom : ";
            // 
            // txtNomVendeur
            // 
            this.txtNomVendeur.Location = new System.Drawing.Point(76, 239);
            this.txtNomVendeur.Name = "txtNomVendeur";
            this.txtNomVendeur.Size = new System.Drawing.Size(123, 22);
            this.txtNomVendeur.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nom : ";
            // 
            // txtSalaireVendeur
            // 
            this.txtSalaireVendeur.Location = new System.Drawing.Point(538, 239);
            this.txtSalaireVendeur.Name = "txtSalaireVendeur";
            this.txtSalaireVendeur.Size = new System.Drawing.Size(133, 22);
            this.txtSalaireVendeur.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Salaire / mois : ";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(24, 301);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 15;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // PageAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 353);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.txtSalaireVendeur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAjoutVendeur);
            this.Controls.Add(this.txtPrenomVendeur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomVendeur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAjoutClient);
            this.Controls.Add(this.txtPrenomClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PageAjout";
            this.Text = "PageAjout";
            this.Load += new System.EventHandler(this.PageAjout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.TextBox txtPrenomClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAjoutClient;
        private System.Windows.Forms.Button btnAjoutVendeur;
        private System.Windows.Forms.TextBox txtPrenomVendeur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomVendeur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalaireVendeur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRetour;
    }
}