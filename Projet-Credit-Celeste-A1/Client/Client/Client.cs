using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Client
{
    public class Client
    {
        // Attributs privés

        private int CodeClient;
        private string NomClient;
        private string PrenomClient;

        public Client()
        {
            // Constructeur vide
        }

        public Client(string unNomClient, string unPrenomClient)    // Constructeur 2 paramètres
        {
            CodeClient = 0; // valeur par défaut (autoincrement dans la BDD)
            NomClient = unNomClient;
            PrenomClient = unPrenomClient;
        }

        public void setNomClient(string unNomClient) 
        {
            NomClient = unNomClient;
        }

        public void setPrenomClient(string unPrenomClient)
        {
            PrenomClient = unPrenomClient;
        }

        public int getCodeClient()  // Affichage du code du client
        {
            return CodeClient;
        }

        public string getNomClient()    // Affichage du nom du client
        {
            return NomClient;
        }

        public string getPrenomClient()     // Affichage du prénom du client
        {
            return PrenomClient;
        }

        public string afficheClient()   // Affichage du client
        {
            return (NomClient + " " + PrenomClient);
        }

        public void InsertClientBDD()   // Insertion des clients dans la base de données
        {
            // Connexion à la base de données
            string strConnexion = "Data Source=LAPTOP-ALBAN;Integrated Security=SSPI;Initial Catalog=CreditCelesteA1";
            SqlConnection oConnexion = new SqlConnection(strConnexion);

            // Requête SQL : insertion d'un client
            string strRequete = "INSERT INTO dbo.CLIENT (NomClient, PrenomClient) VALUES(@NomClient, @PrenomClient)";
            
            // lancer ma commande
            SqlCommand oCommand = new SqlCommand(strRequete, oConnexion);
       
            // Insertions des valeurs dans les paramètres
            oCommand.Parameters.AddWithValue("@NomClient", NomClient);
            oCommand.Parameters.AddWithValue("@PrenomClient", PrenomClient);
            
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
