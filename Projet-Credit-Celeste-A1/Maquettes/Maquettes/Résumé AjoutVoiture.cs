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
    public partial class Résumé_AjoutVoiture : Form
    {
        public Résumé_AjoutVoiture()
        {
            InitializeComponent();
        }

        private void btnRetSim_Click(object sender, EventArgs e)
        {
            if (Globales.PageVoiture == null)
                Globales.PageVoiture = new PageVoiture();
            else if (Globales.PageVoiture.IsDisposed)    // chercher la raison ' mettre un point d'arret
                Globales.PageVoiture = new PageVoiture();

            Globales.PageVoiture.Show();
            Globales.PageVoiture.BringToFront();

            Hide();
            
            // Initialiser la liste box
            txtNumVoiture.Items.Clear();
            listImmatVoiture.Items.Clear();
            listMontantVoiture.Items.Clear();
            listDateAchatVoiture.Items.Clear();
            listMarqueVoiture.Items.Clear();
            listModeleVoiture.Items.Clear();
            listAnneeModele.Items.Clear();
            listClient.Items.Clear();

            // Initialiser la collection
            Globales.lesVoitures.Clear();
        }

        private void Résumé_AjoutVoiture_Load(object sender, EventArgs e)
        {
            foreach (Voiture.Voiture xVoiture in Globales.lesVoitures)
            {
                // Insertion des données de l'objet xCredit à la table "CREDIT" (Modèle MVC)
                xVoiture.InsertVoitureBDD();

                // Affichage complet des données de l'objet xCredit avec la collection "lesCredits"
                txtNumVoiture.Items.Add(xVoiture.SelectVoitureBDD());  // Affichage du numéro du dernier crédit
                listImmatVoiture.Items.Add(xVoiture.getImmatVoiture());
                listMontantVoiture.Items.Add(xVoiture.getMontantVoiture());
                listDateAchatVoiture.Items.Add(xVoiture.getDateAchatVoiture());
                listMarqueVoiture.Items.Add(xVoiture.getMarqueVoiture());
                listModeleVoiture.Items.Add(xVoiture.getModeleVoiture());
                listAnneeModele.Items.Add(xVoiture.getAnneeModele());
                listClient.Items.Add(xVoiture.getCodeClient());
            }
        }
    }
}
