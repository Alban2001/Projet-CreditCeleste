using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquettes
{
    public partial class PageAjout : Form
    {
        public PageAjout()
        {
            InitializeComponent();
        }

        private void PageAjout_Load(object sender, EventArgs e)
        {

        }

        private void btnAjoutVendeur_Click(object sender, EventArgs e)
        {
            if (verifieSaisieVendeur())     // Si tous les champs obligatoires sont remplis
            {
                Globales.unVendeur = new Vendeur.Vendeur(txtNomVendeur.Text, txtPrenomVendeur.Text, Convert.ToDecimal(txtSalaireVendeur.Text));

                // Ajouter un vendeur à la collection
                Globales.lesVendeurs.Add(Globales.unVendeur);
            
                // Aller vers la page "PageResumeAjoutVendeur.cs"
                if (Globales.PageResumeAjoutVendeur == null)
                    Globales.PageResumeAjoutVendeur = new Résumé_AjoutVendeur();
                else if (Globales.PageResumeAjoutVendeur.IsDisposed)
                    Globales.PageResumeAjoutVendeur = new Résumé_AjoutVendeur();

                Globales.PageResumeAjoutVendeur.Show();
                Globales.PageResumeAjoutVendeur.BringToFront();
                Hide();
            }
        }

        private void btnAjoutClient_Click(object sender, EventArgs e)
        {
            if (verifieSaisieClient())     // Si tous les champs obligatoires sont remplis
            {
                Globales.unClient = new Client.Client(txtNomClient.Text, txtPrenomClient.Text);

                // Ajouter un client à la collection
                Globales.lesClients.Add(Globales.unClient);
            
                // Aller vers la page "PageResumeAjoutClient.cs"
                if (Globales.PageResumeAjoutClient == null)
                    Globales.PageResumeAjoutClient = new Résumé_AjoutClient();
                else if (Globales.PageResumeAjoutClient.IsDisposed)    // chercher la raison ' mettre un point d'arret
                    Globales.PageResumeAjoutClient = new Résumé_AjoutClient();

                Globales.PageResumeAjoutClient.Show();
                Globales.PageResumeAjoutClient.BringToFront();
                Hide();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            // Aller vers la page "PagePrinc.cs"
            if (Globales.PagePrinc == null)
                Globales.PagePrinc = new PagePrincipale();
            else if (Globales.PagePrinc.IsDisposed)    // chercher la raison ' mettre un point d'arret
                Globales.PagePrinc = new PagePrincipale();

            Globales.PagePrinc.Show();
            Globales.PagePrinc.BringToFront();
            Hide();
        }

        private Boolean verifieSaisieClient()     // Pour forcer les saisies des champs obligatoires aux utilisateur
        {
            bool verif = false;
            Color borderColorRed = Color.Red;

            if (txtNomClient.Text == "")   // Si le champ "Nom du client" est vide
            {
                txtNomClient.Focus();
                MessageBox.Show("Veuillez saisir le nom du client");
                return verif;
            }
            if (txtPrenomClient.Text == "")   // Si le champ "Prénom du client" est vide
            {
                txtPrenomClient.Focus();
                MessageBox.Show("Veuillez saisir le prénom du client");
                return verif;
            }

            verif = true;

            return verif;
        }

        private Boolean verifieSaisieVendeur()     // Pour forcer les saisies des champs obligatoires aux utilisateur
        {
            bool verif = false;

            if (txtNomVendeur.Text == "")   // Si le champ "Nom du client" est vide
            {
                txtNomVendeur.Focus();
                MessageBox.Show("Veuillez saisir le nom du vendeur");
                return verif;
            }
            if (txtPrenomVendeur.Text == "")   // Si le champ "Prénom du client" est vide
            {
                txtPrenomVendeur.Focus();
                MessageBox.Show("Veuillez saisir le prénom du vendeur");
                return verif;
            }
            if (txtSalaireVendeur.Text == "")   // Si le champ "Prénom du client" est vide
            {
                txtSalaireVendeur.Focus();
                MessageBox.Show("Veuillez saisir le salaire du vendeur");
                return verif;
            }

            verif = true;

            return verif;
        }
    }
}
