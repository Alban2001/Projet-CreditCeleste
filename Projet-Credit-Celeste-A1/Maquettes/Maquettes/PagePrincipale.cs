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
using Credit;

namespace Maquettes
{
    public partial class PagePrincipale : Form
    {
        public PagePrincipale()
        {
            InitializeComponent();
        }

        private void btnValidationPrinc_Click(object sender, EventArgs e)
        {
            if (verifieSaisie())    // Si tous les champs obligatoires sont remplis
            {
                Credit.Credit unCredit = new Credit.Credit(Convert.ToDouble(listMontantCredit.Text), Convert.ToDouble(txtMensualite.Text), Convert.ToDouble(cbxTauxCredit.Text), int.Parse(cbxDuree.Text), (int)cbxVendeur.SelectedValue, (int)cbxClient.SelectedValue, (string)cbxDuree.SelectedValue, (int)cbxTauxCredit.SelectedValue, (int)cbxVoiture.SelectedValue);
                
                // Ajouter un crédit à la collection
                Globales.lesCredits.Add(unCredit);  

                // Aller vers la page "Validation.cs"
                if (Globales.PageValidation == null)
                    Globales.PageValidation = new Validation();
                else if (Globales.PageValidation.IsDisposed) 
                    Globales.PageValidation = new Validation();

                Globales.PageValidation.Show();
                Globales.PageValidation.BringToFront();

                Hide();
            }
        }
        
        private void btnDeconnexionPP_Click(object sender, EventArgs e)
        {
           //Application.Run(new Connexion());
        }
        
        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            if (txtMensualite.Text == "")    // Si le champ "Mensualité" est vide alors :
            {
                Credit.Credit unCredit = new Credit.Credit(Convert.ToDouble(listMontantCredit.Text), Convert.ToDouble(cbxTauxCredit.Text), int.Parse(cbxDuree.Text));

                // Calcul de la mensualité
                txtMensualite.Text = Convert.ToString(unCredit.getMensualiteCredit());
            }
            
        }
        
        private void btnRetourPrinc_Click(object sender, EventArgs e)
        {
            if (Globales.PageAccueil == null)
                Globales.PageAccueil = new PageAccueil();
            else if (Globales.PageAccueil.IsDisposed)    // chercher la raison ' mettre un point d'arret
                Globales.PageAccueil = new PageAccueil();

            Globales.PageAccueil.Show();
            Globales.PageAccueil.BringToFront();

            Hide();
        }

        private void PagePrincipale_Load(object sender, EventArgs e)
        {
            // Pour empêcher les utilisateurs de taper du texte dans les listes déroulantes
            cbxVendeur.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTauxCredit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDuree.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxVoiture.DropDownStyle = ComboBoxStyle.DropDownList;

            Globales.lesCredits.Clear();    // Initialiser la collection

            affichageDonnees();   // Affichage des données dans les listes déroulantes
            
        }

        private Boolean verifieSaisie()     // Pour forcer les saisies des champs obligatoires aux utilisateur
        {
            bool verif = false;
            
            if (listMontantCredit.Text == "")   // Si le champ "Montant" est vide
            {
                listMontantCredit.Focus();
                MessageBox.Show("Veuillez saisir ou calculer le montant");
                return verif;
            }
            if (txtMensualite.Text == "")   // Si le champ "Mensualité" est vide
            {
                txtMensualite.Focus();
                MessageBox.Show("Veuillez saisir ou calculer la mensualité");
                return verif;
            }
            if (cbxDuree.Text == "")    // Si la liste déroulante de la "durée en mois" est vide
            {
                cbxDuree.Focus();
                MessageBox.Show("Veuillez sélectionner une durée");
                return verif;
            }

            verif = true;

            return verif;
        }
        
        public void affichageDonnees()
        {
            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";  // DataSource
                SqlConnection oConnexion = new SqlConnection(strConnexion);
                SqlConnection oConnexion2 = new SqlConnection(strConnexion);
                SqlConnection oConnexion3 = new SqlConnection(strConnexion);
                SqlConnection oConnexion4 = new SqlConnection(strConnexion);
                SqlConnection oConnexion5 = new SqlConnection(strConnexion);

                // Requêtes
                string strRequete = "SELECT CodeVendeur, CONCAT(NomVendeur, ' ',PrenomVendeur) AS 'NomPrenom_Vendeur' FROM dbo.VENDEUR";
                string strRequete2 = "SELECT CodeClient, CONCAT(NomClient, ' ',PrenomClient) AS 'NomPrenom_Client' FROM dbo.CLIENT";
                string strRequete3 = "SELECT CodeNiveau, TauxNiveau FROM Niveau";
                string strRequete4 = "SELECT CodeMensualite, NombreMoisMensualite FROM Mensualite";
                string strRequete5 = "SELECT NumVoiture, CONCAT(ImmatriculationVoiture, ' - ',MarqueVoiture, ' - ', ModeleVoiture) AS 'Voiture_Client' FROM dbo.VOITURE WHERE CodeClient = '"+cbxClient.SelectedValue+"'";

                // Lancements des commandes
                SqlDataAdapter adapter = new SqlDataAdapter(strRequete, oConnexion);
                SqlDataAdapter adapter2 = new SqlDataAdapter(strRequete2, oConnexion2);
                SqlDataAdapter adapter3 = new SqlDataAdapter(strRequete3, oConnexion3);
                SqlDataAdapter adapter4 = new SqlDataAdapter(strRequete4, oConnexion4);
                SqlDataAdapter adapter5 = new SqlDataAdapter(strRequete5, oConnexion5);

                // Ouverture des connexions
                oConnexion.Open();
                oConnexion2.Open();
                oConnexion3.Open();
                oConnexion4.Open();
                oConnexion5.Open();

                // Se positionner sur le premier objet et lire l'enregistrement
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbxVendeur.DataSource = dt;
                cbxVendeur.DisplayMember = "NomPrenom_Vendeur";
                cbxVendeur.ValueMember = "CodeVendeur";
                
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                cbxClient.DataSource = dt2;
                cbxClient.DisplayMember = "NomPrenom_Client";
                cbxClient.ValueMember = "CodeClient";
                
                DataTable dt3 = new DataTable();
                adapter3.Fill(dt3);
                cbxTauxCredit.DataSource = dt3;
                cbxTauxCredit.DisplayMember = "TauxNiveau";
                cbxTauxCredit.ValueMember = "CodeNiveau";
                
                DataTable dt4 = new DataTable();
                adapter4.Fill(dt4);
                cbxDuree.DataSource = dt4;
                cbxDuree.DisplayMember = "NombreMoisMensualite";
                cbxDuree.ValueMember = "CodeMensualite";

                DataTable dt5 = new DataTable();
                adapter5.Fill(dt5);
                cbxVoiture.DataSource = dt5;
                cbxVoiture.DisplayMember = "Voiture_Client";
                cbxVoiture.ValueMember = "NumVoiture";

                // Fermeture des connexions
                oConnexion.Close();
                oConnexion2.Close();
                oConnexion3.Close();
                oConnexion4.Close();
                oConnexion5.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
        
        private void btnInitialiser_Click(object sender, EventArgs e)
        {
            lblVoiture1.Visible = true;
            cbxVoiture.Visible = true;

            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";  // DataSource
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requête
                string strRequete = "SELECT MontantVoiture, NumVoiture, CONCAT(ImmatriculationVoiture, ' - ',MarqueVoiture, ' - ', ModeleVoiture) AS 'Voiture_Client' FROM dbo.VOITURE WHERE CodeClient = '" + cbxClient.SelectedValue + "' AND NumVoiture NOT IN(SELECT NumVoiture from CREDIT WHERE CodeClient = '" + cbxClient.SelectedValue + "')";

                // Lancements des commandes
                SqlDataAdapter adapter = new SqlDataAdapter(strRequete, oConnexion);

                // Ouverture des connexions
                oConnexion.Open();
                
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbxVoiture.DataSource = dt;
                cbxVoiture.DisplayMember = "Voiture_Client";
                cbxVoiture.ValueMember = "NumVoiture";
                listMontantCredit.DataSource = dt;
                listMontantCredit.DisplayMember = "MontantVoiture";
                
                // Fermeture des connexions
                oConnexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void listMontantCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
