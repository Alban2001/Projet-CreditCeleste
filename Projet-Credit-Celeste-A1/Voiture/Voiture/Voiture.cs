using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Voiture
{
    public class Voiture
    {
        int NumVoiture;
        string ImmatriculationVoiture;
        double MontantVoiture;
        DateTime DateAchatVoiture;
        string MarqueVoiture;
        string ModeleVoiture;
        int AnneeModele;
        int CodeClient;

        public Voiture(string uneImmatVoiture, double unMontantVoiture, DateTime uneDateAchatVoiture, string uneMarqueVoiture, string unModeleVoiture, int uneAnneeModele, int unCodeClient)
        {
            ImmatriculationVoiture = uneImmatVoiture;
            MontantVoiture = unMontantVoiture;
            DateAchatVoiture = uneDateAchatVoiture;
            MarqueVoiture = uneMarqueVoiture;
            ModeleVoiture = unModeleVoiture;
            AnneeModele = uneAnneeModele;
            CodeClient = unCodeClient;
        }

        public string getImmatVoiture()
        {
            return ImmatriculationVoiture;
        }

        public double getMontantVoiture()
        {
            return MontantVoiture;
        }
        public DateTime getDateAchatVoiture()
        {
            return DateAchatVoiture;
        }

        public string getMarqueVoiture()
        {
            return MarqueVoiture;
        }
        public string getModeleVoiture()
        {
            return ModeleVoiture;
        }

        public int getAnneeModele()
        {
            return AnneeModele;
        }

        public int getCodeClient()
        {
            return CodeClient;
        }

        public void InsertVoitureBDD()   // Insertion des vendeurs dans la base de données
        {
            // Connexion à la base de données
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";

            SqlConnection oConnexion = new SqlConnection(strConnexion);
            string strRequete = "INSERT INTO dbo.VOITURE (ImmatriculationVoiture, MontantVoiture, DateAchatVoiture, MarqueVoiture, ModeleVoiture, AnneeModele, CodeClient) VALUES(@ImmatriculationVoiture, @MontantVoiture, @DateAchatVoiture, @MarqueVoiture, @ModeleVoiture, @AnneeModele, @CodeClient)";

            // lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

            // Insertions des valeurs dans les paramètres
            oCommand.Parameters.AddWithValue("@ImmatriculationVoiture", ImmatriculationVoiture);
            oCommand.Parameters.AddWithValue("@MontantVoiture", MontantVoiture);
            oCommand.Parameters.AddWithValue("@DateAchatVoiture", DateAchatVoiture);
            oCommand.Parameters.AddWithValue("@MarqueVoiture", MarqueVoiture);
            oCommand.Parameters.AddWithValue("@ModeleVoiture", ModeleVoiture);
            oCommand.Parameters.AddWithValue("@AnneeModele", AnneeModele);
            oCommand.Parameters.AddWithValue("@CodeClient", CodeClient);

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

        public int SelectVoitureBDD()    // Affichage du numéro du dernier crédit
        {
            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requête
                string strRequete = "SELECT MAX(NumVoiture) AS 'NumVoitureMax' FROM dbo.VOITURE";

                // Lancer ma commande
                SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

                oConnexion.Open();  // Ouverture de la base de données

                // Lire l'enregistrement
                SqlDataReader oReader = oCommand.ExecuteReader();

                while (oReader.Read())
                {
                    NumVoiture = (int)oReader["NumVoitureMax"];
                }

                oConnexion.Close();   // Fermeture de la base de données

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }

            return NumVoiture;
        }
    }
}
