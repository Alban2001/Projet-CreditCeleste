using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Credit;

namespace Maquettes
{
    public partial class Résumé_Crédit : Form
    {
        public Résumé_Crédit()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            // Aller vers la page "PagePrinc.cs"
            if (Globales.PagePrinc == null)
                Globales.PagePrinc = new PagePrincipale();
            else if (Globales.PagePrinc.IsDisposed) 
                Globales.PagePrinc = new PagePrincipale();

            Globales.PagePrinc.Show();
            Globales.PagePrinc.BringToFront();
            Hide();

            // Initialiser la liste box
            listDateDebutCredit.Items.Clear();
            listMontantCredit.Items.Clear();
            listDureeCredit.Items.Clear();
            listTauxCredit.Items.Clear();
            listMensualiteCredit.Items.Clear();
            listRevenusVendeur.Items.Clear();
            listDateFinCredit.Items.Clear();

            // Initialiser la collection
            Globales.lesCredits.Clear();
        }

        private void cmdListeCredit_Click(object sender, EventArgs e)
        {
            // Fermeture de l'application
            Application.Exit();
        }

        private void Résumé_Crédit_Load(object sender, EventArgs e)
        {
            foreach (Credit.Credit xCredit in Globales.lesCredits)
            {
                // Insertion des données de l'objet xCredit à la table "CREDIT" (Modèle MVC)
                xCredit.InsertCreditBDD();

                // Affichage complet des données de l'objet xCredit avec la collection "lesCredits"
                txtNumCredit.Items.Add(xCredit.SelectCreditBDD());  // Affichage du numéro du dernier crédit
                listDateDebutCredit.Items.Add(xCredit.getDateDebutCredit());
                listMontantCredit.Items.Add(xCredit.getMontantCredit());
                listDureeCredit.Items.Add(xCredit.getDureeCredit());
                listTauxCredit.Items.Add(xCredit.getTauxCredit()*1200);
                listMensualiteCredit.Items.Add(xCredit.getMensualiteCredit());
                listRevenusVendeur.Items.Add(xCredit.getRevenusVendeur());
                listDateFinCredit.Items.Add(xCredit.getDateFinCredit());
            }
        }
    }
}
