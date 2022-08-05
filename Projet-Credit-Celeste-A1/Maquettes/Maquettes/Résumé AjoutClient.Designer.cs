namespace Maquettes
{
    partial class Résumé_AjoutClient
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
            this.listNomClient = new System.Windows.Forms.ListBox();
            this.listPrenomClient = new System.Windows.Forms.ListBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etes-vous sur des valeurs du client ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom : ";
            // 
            // listNomClient
            // 
            this.listNomClient.FormattingEnabled = true;
            this.listNomClient.ItemHeight = 16;
            this.listNomClient.Location = new System.Drawing.Point(196, 106);
            this.listNomClient.Name = "listNomClient";
            this.listNomClient.Size = new System.Drawing.Size(120, 20);
            this.listNomClient.TabIndex = 3;
            // 
            // listPrenomClient
            // 
            this.listPrenomClient.FormattingEnabled = true;
            this.listPrenomClient.ItemHeight = 16;
            this.listPrenomClient.Location = new System.Drawing.Point(196, 155);
            this.listPrenomClient.Name = "listPrenomClient";
            this.listPrenomClient.Size = new System.Drawing.Size(120, 20);
            this.listPrenomClient.TabIndex = 4;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(128, 223);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(240, 223);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // Résumé_AjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 303);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.listPrenomClient);
            this.Controls.Add(this.listNomClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Résumé_AjoutClient";
            this.Text = "Résumé_AjoutClient";
            this.Load += new System.EventHandler(this.Résumé_AjoutClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listNomClient;
        private System.Windows.Forms.ListBox listPrenomClient;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnValider;
    }
}