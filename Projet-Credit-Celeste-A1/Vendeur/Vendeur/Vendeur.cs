using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Vendeur
{
    public class Vendeur
    {
        // Attributs privés

        private int CodeVendeur;
        private string NomVendeur;
        private string PrenomVendeur;
        private decimal SalairePrevuMois;

        public Vendeur()
        {
            // Constructeur vide
        }
        public Vendeur(string unNomVendeur, string unPrenomVendeur)     // Constructeurs 2 paramètres
        {
            CodeVendeur = 0;
            NomVendeur = unNomVendeur;
            PrenomVendeur = unPrenomVendeur;
        }
        public Vendeur(string unNomVendeur, string unPrenomVendeur, decimal unSalairePrevuMois)     // Constructeurs 3 paramètres
        {
            CodeVendeur = 0;
            NomVendeur = unNomVendeur;
            PrenomVendeur = unPrenomVendeur;
            SalairePrevuMois = unSalairePrevuMois;
        }

        public void setNomVendeur(string unNomVendeur)
        {
            NomVendeur = unNomVendeur;
        }

        public void setPrenomVendeur(string unPrenomVendeur)
        {
            PrenomVendeur = unPrenomVendeur;
        }
        public void setSalairePrevuMois(decimal unSalairePrevuMois)
        {
            SalairePrevuMois = unSalairePrevuMois;
        }

        public int getCodeVendeur()     // Affichage du code du vendeur
        {
            return CodeVendeur;
        }

        public string getNomVendeur()   // Affichage du nom du vendeur
        {
            return NomVendeur;
        }

        public string getPrenomVendeur()    // Affichage du prénom du vendeur
        {
            return PrenomVendeur;
        }
        public decimal getSalairePrevuMois()    // Affichage du salaire prévu par mois du vendeur
        {
            return SalairePrevuMois;
        }

        public string afficheVendeur()  // Affichage du vendeur (nom + prénom)
        {
            return (NomVendeur + " " + PrenomVendeur);
        }
        
        public void InsertVendeurBDD()   // Insertion des vendeurs dans la base de données
        {
            // Connexion à la base de données
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
            SqlConnection oConnexion = new SqlConnection(strConnexion);

            // Requête SQL : insertion d'un vendeur
            string strRequete = "INSERT INTO dbo.VENDEUR (NomVendeur, PrenomVendeur, SalairePrevuMois) VALUES(@NomVendeur, @PrenomVendeur, @SalairePrevuMois)";

            // lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);

            // Insertions des valeurs dans les paramètres
            oCommand.Parameters.AddWithValue("@NomVendeur", NomVendeur);
            oCommand.Parameters.AddWithValue("@PrenomVendeur", PrenomVendeur);
            oCommand.Parameters.AddWithValue("@SalairePrevuMois", SalairePrevuMois);

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
    }
}

