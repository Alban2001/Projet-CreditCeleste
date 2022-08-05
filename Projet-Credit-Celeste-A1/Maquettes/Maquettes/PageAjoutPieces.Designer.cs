namespace Maquettes
{
    partial class PageAjoutPieces
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrixPiece = new System.Windows.Forms.TextBox();
            this.cbxDureeGarantieMois = new System.Windows.Forms.ComboBox();
            this.lblDureeGarantie = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtLibellePiece = new System.Windows.Forms.TextBox();
            this.rdbOui = new System.Windows.Forms.RadioButton();
            this.rdbNon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Prix de la pièce :";
            // 
            // txtPrixPiece
            // 
            this.txtPrixPiece.Location = new System.Drawing.Point(175, 69);
            this.txtPrixPiece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrixPiece.Name = "txtPrixPiece";
            this.txtPrixPiece.Size = new System.Drawing.Size(121, 22);
            this.txtPrixPiece.TabIndex = 86;
            // 
            // cbxDureeGarantieMois
            // 
            this.cbxDureeGarantieMois.FormattingEnabled = true;
            this.cbxDureeGarantieMois.Location = new System.Drawing.Point(175, 133);
            this.cbxDureeGarantieMois.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDureeGarantieMois.Name = "cbxDureeGarantieMois";
            this.cbxDureeGarantieMois.Size = new System.Drawing.Size(230, 24);
            this.cbxDureeGarantieMois.TabIndex = 85;
            // 
            // lblDureeGarantie
            // 
            this.lblDureeGarantie.AutoSize = true;
            this.lblDureeGarantie.Location = new System.Drawing.Point(21, 136);
            this.lblDureeGarantie.Name = "lblDureeGarantie";
            this.lblDureeGarantie.Size = new System.Drawing.Size(146, 17);
            this.lblDureeGarantie.TabIndex = 84;
            this.lblDureeGarantie.Text = "Durée de la garantie :";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(44, 186);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(133, 25);
            this.btnRetour.TabIndex = 81;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(185, 186);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(133, 25);
            this.btnValider.TabIndex = 80;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Garantie souscrite :";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(37, 35);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(130, 17);
            this.lblMontant.TabIndex = 73;
            this.lblMontant.Text = "Libellé de la pièce :";
            // 
            // txtLibellePiece
            // 
            this.txtLibellePiece.Location = new System.Drawing.Point(175, 32);
            this.txtLibellePiece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLibellePiece.Name = "txtLibellePiece";
            this.txtLibellePiece.Size = new System.Drawing.Size(230, 22);
            this.txtLibellePiece.TabIndex = 72;
            // 
            // rdbOui
            // 
            this.rdbOui.AutoSize = true;
            this.rdbOui.Location = new System.Drawing.Point(174, 104);
            this.rdbOui.Name = "rdbOui";
            this.rdbOui.Size = new System.Drawing.Size(51, 21);
            this.rdbOui.TabIndex = 88;
            this.rdbOui.TabStop = true;
            this.rdbOui.Text = "Oui";
            this.rdbOui.UseVisualStyleBackColor = true;
            this.rdbOui.CheckedChanged += new System.EventHandler(this.rdbOui_CheckedChanged);
            // 
            // rdbNon
            // 
            this.rdbNon.AutoSize = true;
            this.rdbNon.Location = new System.Drawing.Point(241, 104);
            this.rdbNon.Name = "rdbNon";
            this.rdbNon.Size = new System.Drawing.Size(55, 21);
            this.rdbNon.TabIndex = 89;
            this.rdbNon.TabStop = true;
            this.rdbNon.Text = "Non";
            this.rdbNon.UseVisualStyleBackColor = true;
            this.rdbNon.CheckedChanged += new System.EventHandler(this.rdbNon_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 90;
            this.label1.Text = "€";
            // 
            // PageAjoutPieces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbNon);
            this.Controls.Add(this.rdbOui);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrixPiece);
            this.Controls.Add(this.cbxDureeGarantieMois);
            this.Controls.Add(this.lblDureeGarantie);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.txtLibellePiece);
            this.Name = "PageAjoutPieces";
            this.Text = "PageAjoutPieces";
            this.Load += new System.EventHandler(this.PageAjoutPieces_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtPrixPiece;
        internal System.Windows.Forms.ComboBox cbxDureeGarantieMois;
        private System.Windows.Forms.Label lblDureeGarantie;
        internal System.Windows.Forms.Button btnRetour;
        internal System.Windows.Forms.Button btnValider;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblMontant;
        internal System.Windows.Forms.TextBox txtLibellePiece;
        private System.Windows.Forms.RadioButton rdbOui;
        private System.Windows.Forms.RadioButton rdbNon;
        internal System.Windows.Forms.Label label1;
    }
}