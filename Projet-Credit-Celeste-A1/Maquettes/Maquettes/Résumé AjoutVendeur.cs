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
    public partial class Résumé_AjoutVendeur : Form
    {
        public Résumé_AjoutVendeur()
        {
            InitializeComponent();
        }

        private void Résumé_AjoutVendeur_Load(object sender, EventArgs e)
        {
            // Affichage complet des données de l'objet unVendeur avec la collection "lesVendeurs"
            foreach (Vendeur.Vendeur unVendeur in Globales.lesVendeurs)
            {
                listNomVendeur.Items.Add(unVendeur.getNomVendeur());
                listPrenomVendeur.Items.Add(unVendeur.getPrenomVendeur());
                listSalaireVendeur.Items.Add(unVendeur.getSalairePrevuMois());
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            // Aller vers la page "PageAjout.cs"
            if (Globales.PageAjout == null)
                Globales.PageAjout = new PageAjout();
            else if (Globales.PageAjout.IsDisposed)    // chercher la raison ' mettre un point d'arret
                Globales.PageAjout = new PageAjout();

            Globales.PageAjout.Show();
            Globales.PageAjout.BringToFront();
            Hide();

            // Initialiser la liste box
            listNomVendeur.Items.Clear();
            listPrenomVendeur.Items.Clear();

            // Initialiser la collection
            Globales.lesVendeurs.Clear();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Insertion des données dans la BDD
            Globales.unVendeur.InsertVendeurBDD();

            // Affichage d'une fenêtre pour l'enregistrement effectué avec succès d'un vendeur
            MessageBox.Show("Enregistrement effectué avec succès : "+"\n\n"+"Nom : " + Globales.unVendeur.getNomVendeur() + "\n" + "Prénom : " + Globales.unVendeur.getPrenomVendeur() + "\n" + "Salaire / mois : " + Globales.unVendeur.getSalairePrevuMois());

            // Aller vers la page "PagePrinc.cs"
            if (Globales.PagePrinc == null)
                Globales.PagePrinc = new PagePrincipale();
            else if (Globales.PagePrinc.IsDisposed)    // chercher la raison ' mettre un point d'arret
                Globales.PagePrinc = new PagePrincipale();

            Globales.PagePrinc.Show();
            Globales.PagePrinc.BringToFront();
            Hide();
        }
    }
}
