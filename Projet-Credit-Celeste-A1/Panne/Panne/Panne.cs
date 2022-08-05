using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Panne
{
    public class Panne
    {
        DateTime DateReparation;
        int NumVoiture;
        int NumFacture;
        int NumPiece;
        decimal PrixPiece;

        public Panne(int unePiece)
        {
            NumPiece = unePiece;
        }
        public Panne(int unePiece, int uneVoiture, int uneFacture)
        {
            DateReparation = DateTime.Now.Date;
            NumPiece = unePiece;
            NumVoiture = uneVoiture;
            NumFacture = uneFacture;
        }
        public Panne(int unePiece, int uneVoiture)
        {
            DateReparation = DateTime.Now.Date;
            NumPiece = unePiece;
            NumVoiture = uneVoiture;
            NumFacture = 0;
        }

        public void setFacture(int uneFacture)
        {
            NumFacture = uneFacture;
        }
        public int getFacture()
        {
            return NumFacture;
        }
        public void InsertPanneBDD()   // Insertion des vendeurs dans la base de données
        {
            // Connexion à la base de données
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";

            SqlConnection oConnexion = new SqlConnection(strConnexion);
            string strRequete = "INSERT INTO dbo.PANNE (DateReparation, NumPiece, NumVoiture, NumFacture) VALUES(@DateReparation, @NumPiece, @NumVoiture, @NumFacture)";

            // lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

            // Insertions des valeurs dans les paramètres
            oCommand.Parameters.AddWithValue("@DateReparation", DateReparation);
            oCommand.Parameters.AddWithValue("@NumPiece", NumPiece);
            oCommand.Parameters.AddWithValue("@NumVoiture", NumVoiture);
            oCommand.Parameters.AddWithValue("@NumFacture", NumFacture);

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
        public decimal SelectMontantPanne()    // Affichage du numéro du dernier crédit
        {
            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requête
                string strRequete = " SELECT PrixPiece FROM PIECE WHERE NumPiece = '" + NumPiece + "'";

                // Lancer ma commande
                SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

                oConnexion.Open();  // Ouverture de la base de données

                // Lire l'enregistrement
                SqlDataReader oReader = oCommand.ExecuteReader();

                while (oReader.Read())
                {
                    PrixPiece = (decimal)oReader["PrixPiece"];
                }

                oConnexion.Close();   // Fermeture de la base de données

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }

            return PrixPiece;
        }

       
    }
}
