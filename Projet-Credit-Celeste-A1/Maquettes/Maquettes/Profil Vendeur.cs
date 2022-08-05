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
    public partial class Profil_Vendeur : Form
    {
        public Profil_Vendeur()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            Profil_Vendeur.ActiveForm.Close();  // Fermeture de la page Profil_Vendeur.cs
            Application.Run(new Menu_Vendeur());  // Ouverture de la page PagePrincipale.cs
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
