using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Maquettes
{
    public partial class PageAjoutPieces : Form
    {
        public PageAjoutPieces()
        {
            InitializeComponent();
        }

        private void PageAjoutPieces_Load(object sender, EventArgs e)
        {
            lblDureeGarantie.Visible = false;
            cbxDureeGarantieMois.Visible = false;
            
            affichageDonneesGarantie();

            Globales.lesPieces.Clear();
        }

        public void affichageDonneesGarantie()
        {
            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";  // DataSource
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requêtes
                string strRequete = "SELECT CodeGarantie, DureeGarantieMois FROM dbo.GARANTIE";

                // Lancements des commandes
                SqlDataAdapter adapter = new SqlDataAdapter(strRequete, oConnexion);

                // Ouverture des connexions
                oConnexion.Open();

                // Se positionner sur le premier objet et lire l'enregistrement
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbxDureeGarantieMois.DataSource = dt;
                cbxDureeGarantieMois.DisplayMember = "DureeGarantieMois";
                cbxDureeGarantieMois.ValueMember = "CodeGarantie";
                
                // Fermeture des connexions
                oConnexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (Globales.PageAccueil == null)
                Globales.PageAccueil = new PageAccueil();
            else if (Globales.PageAccueil.IsDisposed)    // chercher la raison ' mettre un point d'arret
                Globales.PageAccueil = new PageAccueil();

            Globales.PageAccueil.Show();
            Globales.PageAccueil.BringToFront();

            Hide();
        }

        private void btnAfficherGaranties_Click(object sender, EventArgs e)
        {
            lblDureeGarantie.Visible = true;
            cbxDureeGarantieMois.Visible = true;
        }

        private void rdbOui_CheckedChanged(object sender, EventArgs e)
        {
            lblDureeGarantie.Visible = true;
            cbxDureeGarantieMois.Visible = true;
        }

        private void rdbNon_CheckedChanged(object sender, EventArgs e)
        {
            lblDureeGarantie.Visible = false;
            cbxDureeGarantieMois.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (rdbOui.Checked)
            {
                Globales.unePiece = new Piece.Piece(txtLibellePiece.Text, Convert.ToDouble(txtPrixPiece.Text), (int)cbxDureeGarantieMois.SelectedValue, int.Parse(cbxDureeGarantieMois.Text));

                Globales.lesPieces.Add(Globales.unePiece);

                Globales.unePiece.InsertPieceAvecGarantieBDD();

                string message = "Enregistrement effectué avec succès : \n\n";
                message += "Numéro de la pièce : " + Globales.unePiece.SelectPieceBDD() + "\n";
                message += "Libellé de la pièce : " + Globales.unePiece.getLibellePiece() + "\n";
                message += "Prix de la pièce : " + Globales.unePiece.getPrixPiece() + "\n";
                message += "Garantie souscrite : " + Globales.unePiece.getGarantieSouscrite() + "\n";
                message += "Durée de la garantie (mois) : " + Globales.unePiece.getDureeGarantieMois() + "\n";
                message += "Date de fin de la garantie : " + Globales.unePiece.getDateFinGarantie() + "\n";

                MessageBox.Show(message);
            }

            if (rdbNon.Checked)
            {
                Globales.unePiece = new Piece.Piece(txtLibellePiece.Text, Convert.ToDouble(txtPrixPiece.Text));

                Globales.lesPieces.Add(Globales.unePiece);

                Globales.unePiece.InsertPieceSansGarantieBDD();

                string message = "Enregistrement effectué avec succès : \n\n";
                message += "Numéro de la pièce : " + Globales.unePiece.SelectPieceBDD() + "\n";
                message += "Libellé de la pièce : " + Globales.unePiece.getLibellePiece() + "\n";
                message += "Prix de la pièce : " + Globales.unePiece.getPrixPiece() + "\n";
                message += "Garantie souscrite : " + Globales.unePiece.getGarantieSouscrite() + "\n";

                MessageBox.Show(message);
            }

            txtLibellePiece.Clear();
            txtPrixPiece.Clear();
            rdbOui.Checked = false;
            rdbNon.Checked = false;
            lblDureeGarantie.Visible = false;
            cbxDureeGarantieMois.Visible = false;

            if (Globales.PageAjoutPieces == null)
                Globales.PageAjoutPieces = new PageAjoutPieces();
            else if (Globales.PageAjoutPieces.IsDisposed)    // chercher la raison ' mettre un point d'arret
                Globales.PageAjoutPieces = new PageAjoutPieces();

            Globales.PageAjoutPieces.Show();
            Globales.PageAjoutPieces.BringToFront();
            
        }
    }
}
