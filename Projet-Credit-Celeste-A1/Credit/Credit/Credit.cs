using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Credit
{
    public class Credit
    {
        // Attributs privés
        private int NumCredit;  // Numéro du crédit
        private double MontantCredit;   // Montant du crédit
        private double MensualiteCredit;    //Mensualite du crédit
        private int DureeMensualite;    // Durée de la mensualité
        private double TauxMensualite;     // Taux de la mensualité
        private double RevenusVendeur;    // Revenus du vendeur sur le crédit
        private double TauxVendeur = 0.60;    // Taux du vendeur (60 % pour le vendeur et 40 % pour Crédit Céleste)
        private DateTime DateDebutCredit;   // Date du début du crédit de type Date (date du jour par défaut)
        private DateTime DateFinCredit;     // Date du fin du crédit de type DateTime (Date)
        private int CodeVendeur;    // Code du vendeur
        private int CodeClient;   // Code du client 
        private string CodeMensualite;  // Code de la mensualite
        private int CodeNiveau;  // Code du taux de niveau
        private int NumVoiture;  // Numéro de la voiture

        public Credit()
        {
            // Constructeur vide
        }
        public Credit(double unMontant, double uneMensualiteCredit, double unTauxMensualite, int uneDureeMensualite, int unCodeVendeur, int unCodeClient, string unCodeMensualite, int unCodeNiveau, int unNumVoiture)  // Constructeur (5 paramètres)
        {
            // Constructeur avec toutes les données
            MontantCredit = unMontant;
            MensualiteCredit = uneMensualiteCredit;
            DureeMensualite = uneDureeMensualite;
            
            // Calcul du revenu du vendeur en multipliant la mensualité du crédit avec le taux du vendeur
            // Donc le vendeur va gagner X % de mensualité du crédit du client
            RevenusVendeur = MontantCredit * TauxVendeur;
            TauxMensualite = unTauxMensualite / 1200;
            DateDebutCredit = DateTime.Now.Date;

            // Calcul de la date de fin du crédit en ajoutant la durée du crédit en mois
            DateFinCredit = DateDebutCredit.AddMonths(DureeMensualite);
            CodeVendeur = unCodeVendeur;
            CodeClient = unCodeClient;
            CodeMensualite = unCodeMensualite;
            CodeNiveau = unCodeNiveau;
            NumVoiture = unNumVoiture;
        }

        public Credit(double uneMensualiteCredit, int uneDureeMensualite, double unTauxMensualite)  // Constructeur (3 paramètres)
        {
            // Constructeur pour calculer le montant
            MensualiteCredit = uneMensualiteCredit;
            TauxMensualite = unTauxMensualite / 1200;
            DureeMensualite = uneDureeMensualite;
            MontantCredit = Math.Round((MensualiteCredit * TauxMensualite * Math.Pow((1 + TauxMensualite), DureeMensualite)) / ((Math.Pow((1 + TauxMensualite), DureeMensualite)) - 1),2);
        }

        public Credit(double unMontant, double unTauxMensualite, int uneDureeMensualite)  // Constructeur (5 paramètres)
        {
            // Constructeur pour calculer la mensualité
            MontantCredit = unMontant;
            TauxMensualite = unTauxMensualite / 1200;
            DureeMensualite = uneDureeMensualite;

            // Calcul de la mensualité du crédit pour savoir combien va payer le client par mois pour payer la totalité du montant
            // Formule : (Montant * TauxMens) / (1 - (1 + TauxMens)^ -Durée))
            MensualiteCredit = Math.Round((MontantCredit * TauxMensualite) / (1 - Math.Pow((1 + TauxMensualite), -DureeMensualite)),2);
        }

        public void setMensualiteCredit(int unTauxMensualite, int uneDureeMensualite)   // Mise à jour du taux et de la mensualité du crédit
        {
            TauxMensualite = unTauxMensualite / 1200;   // Le taux de mensualité sera divisé par 1200
            DureeMensualite = uneDureeMensualite;
        }

        public double getMontantCredit()    // Récupération du montant du crédit
        {
            return MontantCredit;
        }

        public double getMensualiteCredit()     // Récupération de la mensualité du crédit
        {
            return MensualiteCredit;
        }

        public double getRevenusVendeur()   // Récupération du revenu du vendeur pour chaque crédit
        {
            return RevenusVendeur;
        }

        public DateTime getDateDebutCredit()    // Récupération de la date de début du crédit (date du jour par défaut)
        {
            return DateDebutCredit;
        }

        public DateTime getDateFinCredit()    // Récupération de la date de fin du crédit
        {
            return DateFinCredit;
        }

        public int getDureeCredit()     // Récupération de la durée du crédit en mois
        {
            return DureeMensualite;
        }
        public double getTauxCredit()   // Récupération du taux de crédit
        {
            return TauxMensualite;
        }
       
        public void InsertCreditBDD()   // Insertion des vendeurs dans la base de données
        {
            // Connexion à la base de données
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";

            SqlConnection oConnexion = new SqlConnection(strConnexion);
            string strRequete = "INSERT INTO dbo.CREDIT (MontantCredit, MensualiteCredit, RevenusVendeur, DateDebutCredit, DateFinCredit, CodeVendeur, CodeClient, CodeMensualite, CodeNiveau, NumVoiture) VALUES(@MontantCredit, @MensualiteCredit, @RevenusVendeur, @DateDebutCredit, @DateFinCredit, @CodeVendeur, @CodeClient, @CodeMensualite, @CodeNiveau, @NumVoiture)";

            // lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

            // Insertions des valeurs dans les paramètres
            oCommand.Parameters.AddWithValue("@MontantCredit", MontantCredit);
            oCommand.Parameters.AddWithValue("@MensualiteCredit", MensualiteCredit);
            oCommand.Parameters.AddWithValue("@RevenusVendeur", RevenusVendeur);
            oCommand.Parameters.AddWithValue("@DateDebutCredit", DateDebutCredit);
            oCommand.Parameters.AddWithValue("@DateFinCredit", DateFinCredit);
            oCommand.Parameters.AddWithValue("@CodeVendeur", CodeVendeur);
            oCommand.Parameters.AddWithValue("@CodeClient", CodeClient);
            oCommand.Parameters.AddWithValue("@CodeMensualite", CodeMensualite);
            oCommand.Parameters.AddWithValue("@CodeNiveau", CodeNiveau);
            oCommand.Parameters.AddWithValue("@NumVoiture", NumVoiture);

            try
            {
                oConnexion.Open();  // Ouvrir la base de données
                oCommand.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                oConnexion.Close();   // Fermeture de la base de données
            }
        }

        public int SelectCreditBDD()    // Affichage du numéro du dernier crédit
        {
            try
            {
            // Connexion à la base de données
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
            SqlConnection oConnexion = new SqlConnection(strConnexion);
            
            // Requête
            string strRequete = "SELECT MAX(NumCredit) AS 'NumCreditMax' FROM dbo.CREDIT";

            // Lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

            oConnexion.Open();  // Ouverture de la base de données

            // Lire l'enregistrement
            SqlDataReader oReader = oCommand.ExecuteReader();

            while (oReader.Read())
            {
                NumCredit = (int)oReader["NumCreditMax"];
            }
            
            oConnexion.Close();   // Fermeture de la base de données

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
           
            return NumCredit;
        }
    }
}
