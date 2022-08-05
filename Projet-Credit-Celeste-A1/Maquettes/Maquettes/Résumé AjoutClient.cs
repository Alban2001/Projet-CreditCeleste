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
    public partial class Résumé_AjoutClient : Form
    {
        public Résumé_AjoutClient()
        {
            InitializeComponent();
        }

        private void Résumé_AjoutClient_Load(object sender, EventArgs e)
        {
            // Affichage complet des données de l'objet unCredit avec la collection "lesClients"
            foreach (Client.Client unClient in Globales.lesClients)
            {
                listNomClient.Items.Add(unClient.getNomClient());
                listPrenomClient.Items.Add(unClient.getPrenomClient());
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            // Aller vers la page "PageAjout.cs"
            if (Globales.PageAjout == null)
                Globales.PageAjout = new PageAjout();
            else if (Globales.PageAjout.IsDisposed)
                Globales.PageAjout = new PageAjout();

            Globales.PageAjout.Show();
            Globales.PageAjout.BringToFront();
            Hide();

            // Initialiser la liste box
            listNomClient.Items.Clear();
            listPrenomClient.Items.Clear();

            // Initialiser la collection
            Globales.lesClients.Clear();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Insertion des données dans la BDD
            Globales.unClient.InsertClientBDD();

            // Affichage d'une fenêtre pour l'enregistrement effectué avec succès d'un client
            MessageBox.Show("Enregistrement effectué avec succès : " + "\n\n" + "Nom : " + Globales.unClient.getNomClient() + "\n" + "Prénom : " + Globales.unClient.getPrenomClient());

            // Aller vers la page "PagePrinc.cs"
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
