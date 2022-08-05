using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Facture
{
    public class Facture
    {
        int NumFacture;
        double MontantFacture;
        DateTime DateFacture;
        int CodeClient;

        public Facture()
        {
            MontantFacture = 0;
            DateFacture = DateTime.Now.Date;
        }

        public Facture(double unMontant, int unClient, int unNumFacture)
        {
            MontantFacture = unMontant;
            DateFacture = DateTime.Now.Date;
            CodeClient = unClient;
            NumFacture = unNumFacture;
        }

        public double getMontantFacture()
        {
            return MontantFacture;
        }
        public DateTime getDateFacture()
        {
            return DateFacture;
        }

        public void InsertFactureBDD()   // Insertion des vendeurs dans la base de données
        {
            // Connexion à la base de données
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";

            SqlConnection oConnexion = new SqlConnection(strConnexion);
            string strRequete = "INSERT INTO dbo.FACTURE (MontantFacture, DateFacture, CodeClient) VALUES(@MontantFacture, @DateFacture, @CodeClient)";

            // lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

            // Insertions des valeurs dans les paramètres
            oCommand.Parameters.AddWithValue("@MontantFacture", MontantFacture);
            oCommand.Parameters.AddWithValue("@DateFacture", DateFacture);
            oCommand.Parameters.AddWithValue("@CodeClient", DBNull.Value);

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
        public void UpdateFactureBDD()   // Insertion des vendeurs dans la base de données
        {
            // Connexion à la base de données
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";

            SqlConnection oConnexion = new SqlConnection(strConnexion);
            string strRequete = "UPDATE dbo.FACTURE SET MontantFacture = '"+MontantFacture+"', CodeClient = '"+CodeClient+"' WHERE NumFacture = '"+NumFacture+"'";

            // lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);
            
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
        public int SelectNumFacture()    // Affichage du numéro du dernier crédit
        {
            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requête
                string strRequete = " SELECT MAX(NumFacture) AS 'NumFactureMax' FROM dbo.FACTURE";

                // Lancer ma commande
                SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

                oConnexion.Open();  // Ouverture de la base de données

                // Lire l'enregistrement
                SqlDataReader oReader = oCommand.ExecuteReader();

                while (oReader.Read())
                {
                    NumFacture = (int)oReader["NumFactureMax"];
                }

                oConnexion.Close();   // Fermeture de la base de données

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }

            return NumFacture;
        }
    }
}
