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
    public partial class ReparationVoiture : Form
    {
        public ReparationVoiture()
        {
            InitializeComponent();
        }

        private void ReparationVoiture_Load(object sender, EventArgs e)
        {
            btnCreationFacture.Visible = true;
            gpbFacture.Visible = false;

            affichageDonnees();

            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";  // DataSource
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requêtes
                string strRequete = "SELECT NumVoiture, CONCAT(NumVoiture, ' - ', ImmatriculationVoiture, ' - ',MarqueVoiture, ' - ', ModeleVoiture) AS 'Voiture' FROM dbo.VOITURE WHERE CodeClient = '"+ cbxClient.SelectedValue + "'";


                // Lancements des commandes
                SqlDataAdapter adapter = new SqlDataAdapter(strRequete, oConnexion);

                // Ouverture des connexions
                oConnexion.Open();

                // Se positionner sur le premier objet et lire l'enregistrement
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbxVoiture.DataSource = dt;
                cbxVoiture.DisplayMember = "Voiture";
                cbxVoiture.ValueMember = "NumVoiture";

                // Fermeture des connexions
                oConnexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requête
                string strRequete = "SELECT SUM(PrixPiece) AS 'SommeFacture' FROM dbo.PANNE, dbo.PIECE WHERE PANNE.NumPiece = PIECE.NumPiece AND NumFacture = '" + (int)Globales.uneFacture.SelectNumFacture() + "'";

                // Lancer ma commande
                SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

                oConnexion.Open();  // Ouverture de la base de données

                // Lire l'enregistrement
                SqlDataReader oReader = oCommand.ExecuteReader();

                while (oReader.Read())
                {
                    lblMontantFacture.Text = oReader["SommeFacture"].ToString();
                }

                oConnexion.Close();   // Fermeture de la base de données

            }
            catch (SqlException k)
            {
                Console.WriteLine("Error Generated. Details: " + k.ToString());
            }
        }

        
        public void affichageDonnees()
        {
            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";  // DataSource
                SqlConnection oConnexion2 = new SqlConnection(strConnexion);
                SqlConnection oConnexion3 = new SqlConnection(strConnexion);

                // Requêtes
                string strRequete2 = "SELECT NumPiece, CONCAT(NumPiece, ' - ',LibellePiece) AS 'Piece' FROM dbo.PIECE";
                string strRequete3 = "SELECT CodeClient, CONCAT(NomClient, ' ',PrenomClient) AS 'Client' FROM dbo.CLIENT";


                // Lancements des commandes
                SqlDataAdapter adapter2 = new SqlDataAdapter(strRequete2, oConnexion2);
                SqlDataAdapter adapter3 = new SqlDataAdapter(strRequete3, oConnexion3);

                // Ouverture des connexions
                oConnexion2.Open();
                oConnexion3.Open();

                // Se positionner sur le premier objet et lire l'enregistrement

                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                cbxPiece.DataSource = dt2;
                cbxPiece.DisplayMember = "Piece";
                cbxPiece.ValueMember = "NumPiece";

                DataTable dt3 = new DataTable();
                adapter3.Fill(dt3);
                cbxClient.DataSource = dt3;
                cbxClient.DisplayMember = "Client";
                cbxClient.ValueMember = "CodeClient";

                // Fermeture des connexions
                oConnexion2.Close();
                oConnexion3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnCalculMontantpanne_Click(object sender, EventArgs e)
        {
            Panne.Panne unePanne = new Panne.Panne((int)cbxPiece.SelectedValue);
            
            lblMontantPanne.Text = Convert.ToString(unePanne.SelectMontantPanne());
        }

        private void btnAjoutFacture_Click(object sender, EventArgs e)
        {

            Panne.Panne unePanne = new Panne.Panne((int)cbxPiece.SelectedValue, (int)cbxVoiture.SelectedValue, (int)Globales.uneFacture.SelectNumFacture());

            unePanne.InsertPanneBDD();

            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requête
                string strRequete = "SELECT SUM(PrixPiece) AS 'SommeFacture' FROM dbo.PANNE, dbo.PIECE WHERE PANNE.NumPiece = PIECE.NumPiece AND NumFacture = '" + (int)Globales.uneFacture.SelectNumFacture() + "'";

                // Lancer ma commande
                SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

                oConnexion.Open();  // Ouverture de la base de données

                // Lire l'enregistrement
                SqlDataReader oReader = oCommand.ExecuteReader();

                while (oReader.Read())
                {
                    lblMontantFacture.Text = oReader["SommeFacture"].ToString();
                }

                oConnexion.Close();   // Fermeture de la base de données

            }
            catch (SqlException k)
            {
                Console.WriteLine("Error Generated. Details: " + k.ToString());
            }

        }

        private void listBoxMontantFacture_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";  // DataSource
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requêtes
                string strRequete = "SELECT NumVoiture, CONCAT(NumVoiture, ' - ', ImmatriculationVoiture, ' - ',MarqueVoiture, ' - ', ModeleVoiture) AS 'Voiture' FROM dbo.VOITURE WHERE CodeClient = '"+ cbxClient.SelectedValue+ "'";


                // Lancements des commandes
                SqlDataAdapter adapter = new SqlDataAdapter(strRequete, oConnexion);

                // Ouverture des connexions
                oConnexion.Open();

                // Se positionner sur le premier objet et lire l'enregistrement
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbxVoiture.DataSource = dt;
                cbxVoiture.DisplayMember = "Voiture";
                cbxVoiture.ValueMember = "NumVoiture";

                // Fermeture des connexions
                oConnexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void cbxVoiture_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCreationFacture_Click(object sender, EventArgs e)
        {
            gpbFacture.Visible = true;

            Globales.uneFacture = new Facture.Facture();

            Globales.uneFacture.InsertFactureBDD();

            btnCreationFacture.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Facture.Facture une2Facture = new Facture.Facture(Convert.ToDouble(lblMontantFacture.Text), (int)cbxClient.SelectedValue, (int)Globales.uneFacture.SelectNumFacture());

            une2Facture.UpdateFactureBDD();

            if (Globales.PageAccueil == null)
                Globales.PageAccueil = new PageAccueil();
            else if (Globales.PageAccueil.IsDisposed)    // chercher la raison ' mettre un point d'arret
                Globales.PageAccueil = new PageAccueil();

            Globales.PageAccueil.Show();
            Globales.PageAccueil.BringToFront();

            Hide();

            MessageBox.Show("Validation du paiement !!!");
        }

        private void lblMontantFacture_Click(object sender, EventArgs e)
        {
            
        }

        private void listMontantFacture_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblMontantFacture_Click_1(object sender, EventArgs e)
        {
            
        }

        private void gpbFacture_Enter(object sender, EventArgs e)
        {

        }
    }
}
