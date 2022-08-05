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
    public partial class PageAccueil : Form
    {
        public PageAccueil()
        {
            InitializeComponent();
        }

        private void btnAjoutCredit_Click(object sender, EventArgs e)
        {
            if (Globales.PagePrinc == null)
                Globales.PagePrinc = new PagePrincipale();
            else if (Globales.PagePrinc.IsDisposed)
                Globales.PagePrinc = new PagePrincipale();

            Globales.PagePrinc.Show();
            Globales.PagePrinc.BringToFront();

            Hide();
        }

        private void btnAjoutPers_Click(object sender, EventArgs e)
        {
            if (Globales.PageAjout == null)
                Globales.PageAjout = new PageAjout();
            else if (Globales.PageAjout.IsDisposed)
                Globales.PageAjout = new PageAjout();

            Globales.PageAjout.Show();
            Globales.PageAjout.BringToFront();

            Hide();
        }

        private void btnAffichageCredits_Click(object sender, EventArgs e)
        {
            if (Globales.PageAffichageCredits == null)
                Globales.PageAffichageCredits = new AffichageCredits();
            else if (Globales.PageAffichageCredits.IsDisposed)
                Globales.PageAffichageCredits = new AffichageCredits();

            Globales.PageAffichageCredits.Show();
            Globales.PageAffichageCredits.BringToFront();

            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Globales.PageVoiture == null)
                Globales.PageVoiture = new PageVoiture();
            else if (Globales.PageVoiture.IsDisposed)
                Globales.PageVoiture = new PageVoiture();

            Globales.PageVoiture.Show();
            Globales.PageVoiture.BringToFront();

            Hide();
        }

        private void btnReparationVoiture_Click(object sender, EventArgs e)
        {
            if (Globales.PageReparationVoiture == null)
                Globales.PageReparationVoiture = new ReparationVoiture();
            else if (Globales.PageReparationVoiture.IsDisposed)
                Globales.PageReparationVoiture = new ReparationVoiture();

            Globales.PageReparationVoiture.Show();
            Globales.PageReparationVoiture.BringToFront();

            Hide();
        }

        private void btnAjoutPieces_Click(object sender, EventArgs e)
        {
            if (Globales.PageAjoutPieces == null)
                Globales.PageAjoutPieces = new PageAjoutPieces();
            else if (Globales.PageAjoutPieces.IsDisposed)
                Globales.PageAjoutPieces = new PageAjoutPieces();

            Globales.PageAjoutPieces.Show();
            Globales.PageAjoutPieces.BringToFront();

            Hide();
        }
    }
}
