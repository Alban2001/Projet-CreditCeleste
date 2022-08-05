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
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
        }
        
        private void Validation_Load(object sender, EventArgs e)
        {
            // Affichage des données du crédit de la page précécdente et de la collection
            foreach (Credit.Credit xCredit in Globales.lesCredits)
            {
                listMontantCredit.Items.Add(xCredit.getMontantCredit());
                listDureeCredit.Items.Add(xCredit.getDureeCredit());
                listTauxCredit.Items.Add(xCredit.getTauxCredit()*1200);
                listMensualiteCredit.Items.Add(xCredit.getMensualiteCredit());
            }
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            // Initialiser la liste box
            listMontantCredit.Items.Clear();
            listDureeCredit.Items.Clear();
            listTauxCredit.Items.Clear();
            listMensualiteCredit.Items.Clear();

            // Initialiser la collection
            Globales.lesCredits.Clear();
            Application.Exit();
        }

        private void btnRetourValid_Click(object sender, EventArgs e)
        {
            // Aller vers la page "PagePrinc.cs"
            if (Globales.PagePrinc == null)
                Globales.PagePrinc = new PagePrincipale();
            else if (Globales.PagePrinc.IsDisposed)    // chercher la raison ' mettre un point d'arret
                Globales.PagePrinc = new PagePrincipale();

            Globales.PagePrinc.Show();
            Globales.PagePrinc.BringToFront();
            Hide();

            // Initialiser la liste box=
            listMontantCredit.Items.Clear();
            listDureeCredit.Items.Clear();
            listTauxCredit.Items.Clear();
            listMensualiteCredit.Items.Clear();

            // Initialiser la collection
            Globales.lesCredits.Clear();
        }

        private void btnConfirmationValid_Click(object sender, EventArgs e)
        {
            // Aller vers la page "PageResumeCredit.cs"
            if (Globales.PageResumeCredit == null)
                Globales.PageResumeCredit = new Résumé_Crédit();
            else if (Globales.PageResumeCredit.IsDisposed) 
                Globales.PageResumeCredit = new Résumé_Crédit();

            Globales.PageResumeCredit.Show();
            Globales.PageResumeCredit.BringToFront();

            Hide();
        }

        private void lblMontantCredit_Click(object sender, EventArgs e)
        {

        }
    }
}
