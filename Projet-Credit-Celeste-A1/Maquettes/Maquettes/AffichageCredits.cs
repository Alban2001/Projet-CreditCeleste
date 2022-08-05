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
    public partial class AffichageCredits : Form
    {
        public AffichageCredits()
        {
            InitializeComponent();
        }

        private void AffichageCredits_Load(object sender, EventArgs e)
        {
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
            SqlConnection oConnexion = new SqlConnection(strConnexion);

            // Requête
            string strRequete = "SELECT NumCredit FROM dbo.CREDIT";
            // Lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

            oConnexion.Open();  // Ouverture de la base de données

            // Lire l'enregistrement
            SqlDataReader oReader = oCommand.ExecuteReader();

            while (oReader.Read())
            {
                listCredit.Items.Add(oReader["NumCredit"].ToString());
            }
            
            oConnexion.Close();   // Fermeture de la base de données
        }

        public void AffichageDonneesCredit(string unNumCredit)
        {
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
            SqlConnection oConnexion2 = new SqlConnection(strConnexion);

            // Requête
            string strRequete2 = "SELECT NumCredit, MontantCredit, MensualiteCredit, RevenusVendeur, DateDebutCredit, DateFinCredit, CONCAT(NomVendeur, ' ',PrenomVendeur) AS 'Vendeur', CONCAT(NomClient, ' ',PrenomClient) AS 'Client', NombreMoisMensualite, CodeNiveau, CONCAT(ImmatriculationVoiture, ' - ',MarqueVoiture, ' - ', ModeleVoiture) AS 'Voiture' FROM CREDIT, VENDEUR, CLIENT, MENSUALITE, VOITURE WHERE VENDEUR.CodeVendeur = CREDIT.CodeVendeur AND CLIENT.CodeClient = CREDIT.CodeClient AND MENSUALITE.CodeMensualite = CREDIT.CodeMensualite AND VOITURE.NumVoiture = CREDIT.NumVoiture AND NumCredit = '" + unNumCredit + "'";

            // Lancer ma commande
            SqlCommand oCommand2 = new SqlCommand(strRequete2, oConnexion2);
            
            oConnexion2.Open();  // Ouverture de la base de données

            // Lire l'enregistrement
            SqlDataReader oReader2 = oCommand2.ExecuteReader();
            
            while (oReader2.Read())
            {
                listNumCredit.Items.Add(oReader2["NumCredit"].ToString());
                listMontantCredit.Items.Add(oReader2["MontantCredit"].ToString());
                listMensualiteCredit.Items.Add(oReader2["MensualiteCredit"].ToString());
                listRevenusVendeur.Items.Add(oReader2["RevenusVendeur"].ToString());
                listDateDebutCredit.Items.Add(oReader2["DateDebutCredit"].ToString());
                listDateFinCredit.Items.Add(oReader2["DateFinCredit"].ToString());
                listVendeur.Items.Add(oReader2["Vendeur"].ToString());
                listClient.Items.Add(oReader2["Client"].ToString());
                listNbrMois.Items.Add(oReader2["NombreMoisMensualite"].ToString());
                listNiveau.Items.Add(oReader2["CodeNiveau"].ToString());
                listVoitureClient.Items.Add(oReader2["Voiture"].ToString());
            }

            oConnexion2.Close();   // Fermeture de la base de données
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            listNumCredit.Items.Clear();
            listMontantCredit.Items.Clear();
            listMensualiteCredit.Items.Clear();
            listRevenusVendeur.Items.Clear();
            listDateDebutCredit.Items.Clear();
            listDateFinCredit.Items.Clear();
            listVendeur.Items.Clear();
            listClient.Items.Clear();
            listNbrMois.Items.Clear();
            listNiveau.Items.Clear();
            listVoitureClient.Items.Clear();
            string unNumCredit = listCredit.GetItemText(listCredit.SelectedItem.ToString());
            AffichageDonneesCredit(unNumCredit);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            listNumCredit.Items.Clear();
            listMontantCredit.Items.Clear();
            listMensualiteCredit.Items.Clear();
            listRevenusVendeur.Items.Clear();
            listDateDebutCredit.Items.Clear();
            listDateFinCredit.Items.Clear();
            listVendeur.Items.Clear();
            listClient.Items.Clear();
            listNbrMois.Items.Clear();
            listNiveau.Items.Clear();

            if (Globales.PagePrinc == null)
                Globales.PagePrinc = new PagePrincipale();
            else if (Globales.PagePrinc.IsDisposed)
                Globales.PagePrinc = new PagePrincipale();

            Globales.PagePrinc.Show();
            Globales.PagePrinc.BringToFront();

            Hide();
        }
    }
}
