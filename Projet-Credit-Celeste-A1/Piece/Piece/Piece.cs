using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Piece
{
    public class Piece
    {
        int NumPiece;
        string LibellePiece;
        double PrixPiece;
        string GarantieSouscrite;
        DateTime DateFinGarantie;
        int CodeGarantie;
        int DureeGarantieMois;

        public Piece(string unLibellePiece, double unPrixPiece)
        {
            LibellePiece = unLibellePiece;
            PrixPiece = unPrixPiece;
            GarantieSouscrite = "Non";
        }

        public Piece(string unLibellePiece, double unPrixPiece, int unCodeGarantie, int uneDureeGarantie)
        {
            LibellePiece = unLibellePiece;
            PrixPiece = unPrixPiece;
            GarantieSouscrite = "Oui";
            DateFinGarantie = (DateTime.Now.Date).AddMonths(uneDureeGarantie);
            CodeGarantie = unCodeGarantie;
            DureeGarantieMois = uneDureeGarantie;
        }

        public string getLibellePiece()
        {
            return LibellePiece;
        }
        public double getPrixPiece()
        {
            return PrixPiece;
        }
        public string getGarantieSouscrite()
        {
            return GarantieSouscrite;
        }
        public DateTime getDateFinGarantie()
        {
            return DateFinGarantie;
        }
        public int getDureeGarantieMois()
        {
            return DureeGarantieMois;
        }

        public void InsertPieceAvecGarantieBDD()   // Insertion des vendeurs dans la base de données
        {
            // Connexion à la base de données
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";

            SqlConnection oConnexion = new SqlConnection(strConnexion);
            string strRequete = "INSERT INTO dbo.PIECE (LibellePiece, PrixPiece, GarantieSouscrite, DateFinGarantie, CodeGarantie) VALUES(@LibellePiece, @PrixPiece, @GarantieSouscrite, @DateFinGarantie, @CodeGarantie)";

            // lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

            // Insertions des valeurs dans les paramètres
            oCommand.Parameters.AddWithValue("@LibellePiece", LibellePiece);
            oCommand.Parameters.AddWithValue("@PrixPiece", PrixPiece);
            oCommand.Parameters.AddWithValue("@GarantieSouscrite", GarantieSouscrite);
            oCommand.Parameters.AddWithValue("@DateFinGarantie", DateFinGarantie);
            oCommand.Parameters.AddWithValue("@CodeGarantie", CodeGarantie);

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

        public void InsertPieceSansGarantieBDD()   // Insertion des vendeurs dans la base de données
        {
            // Connexion à la base de données
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";

            SqlConnection oConnexion = new SqlConnection(strConnexion);
            string strRequete = "INSERT INTO dbo.PIECE (LibellePiece, PrixPiece, GarantieSouscrite, DateFinGarantie, CodeGarantie) VALUES(@LibellePiece, @PrixPiece, @GarantieSouscrite, @DateFinGarantie, @CodeGarantie)";

            // lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

            // Insertions des valeurs dans les paramètres
            oCommand.Parameters.AddWithValue("@LibellePiece", LibellePiece);
            oCommand.Parameters.AddWithValue("@PrixPiece", PrixPiece);
            oCommand.Parameters.AddWithValue("@GarantieSouscrite", GarantieSouscrite);
            oCommand.Parameters.AddWithValue("@DateFinGarantie", DBNull.Value);
            oCommand.Parameters.AddWithValue("@CodeGarantie", DBNull.Value);

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

        public int SelectPieceBDD()    // Affichage du numéro du dernier crédit
        {
            try
            {
                // Connexion à la base de données
                string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
                SqlConnection oConnexion = new SqlConnection(strConnexion);

                // Requête
                string strRequete = "SELECT MAX(NumPiece) AS 'NumPieceMax' FROM dbo.PIECE";

                // Lancer ma commande
                SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

                oConnexion.Open();  // Ouverture de la base de données

                // Lire l'enregistrement
                SqlDataReader oReader = oCommand.ExecuteReader();

                while (oReader.Read())
                {
                    NumPiece = (int)oReader["NumPieceMax"];
                }

                oConnexion.Close();   // Fermeture de la base de données

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }

            return NumPiece;
        }
    }
}
