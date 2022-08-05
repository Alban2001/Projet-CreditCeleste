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
using Voiture;

namespace Maquettes
{
    public partial class PageVoiture : Form
    {
        public PageVoiture()
        {
            InitializeComponent();
        }

        private void PageVoiture_Load(object sender, EventArgs e)
        {
            // Affichage des année de 1900 à aujourd'hui
            for(int xAnnee = 1900; xAnnee <= DateTime.Now.Year; xAnnee++)
            {
                cbxAnneeModele.Items.Add(xAnnee);
            }

            // Initialisation
            Globales.lesVoitures.Clear();

            // Affichage des clients
            affichageDonneesClient();
        }

        public void affichageDonneesClient()
        {
            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";  // DataSource
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requêtes
                string strRequete = "SELECT CodeClient, CONCAT(NomClient, ' ',PrenomClient) AS 'NomPrenom_Client' FROM dbo.CLIENT";

                // Lancements des commandes
                SqlDataAdapter adapter = new SqlDataAdapter(strRequete, oConnexion);

                // Ouverture des connexions
                oConnexion.Open();

                // Se positionner sur le premier objet et lire l'enregistrement

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbxClient.DataSource = dt;
                cbxClient.DisplayMember = "NomPrenom_Client";
                cbxClient.ValueMember = "CodeClient";

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

        private void btnValider_Click(object sender, EventArgs e)
        {
            Globales.uneVoiture = new Voiture.Voiture((string)txtImmatVoiture.Text, Convert.ToDouble(txtMontantVoiture.Text), Convert.ToDateTime(DateAchatVoiture.Text), (string)txtMarqueVoiture.Text, (string)txtModeleVoiture.Text, int.Parse(cbxAnneeModele.Text), (int)cbxClient.SelectedValue);

            // Ajouter un crédit à la collection
            Globales.lesVoitures.Add(Globales.uneVoiture);

            // Aller vers la page "Résumé AjoutVoiture.cs"
            if (Globales.PageResumeAjoutVoiture == null)
                Globales.PageResumeAjoutVoiture = new Résumé_AjoutVoiture();
            else if (Globales.PageResumeAjoutVoiture.IsDisposed)
                Globales.PageResumeAjoutVoiture = new Résumé_AjoutVoiture();

            Globales.PageResumeAjoutVoiture.Show();
            Globales.PageResumeAjoutVoiture.BringToFront();

            Hide();

            // Initialiser la liste box
            txtImmatVoiture.Clear();
            txtMontantVoiture.Clear();
            txtMarqueVoiture.Clear();
            txtModeleVoiture.Clear();
        }
    }
}
