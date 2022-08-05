using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquettes
{
    static class Globales
    {
        // VARIABLES GLOBALES

        // Listes
        public static List<Credit.Credit> lesCredits = new List<Credit.Credit>();   //permet de déclarer et de créer une liste de crédit
        public static List<Client.Client> lesClients = new List<Client.Client>();   //permet de déclarer et de créer une liste de clients
        public static List<Vendeur.Vendeur> lesVendeurs = new List<Vendeur.Vendeur>();   //permet de déclarer et de créer une liste de vendeurs
        public static List<Voiture.Voiture> lesVoitures = new List<Voiture.Voiture>();   //permet de déclarer et de créer une liste de voitures
        public static List<Piece.Piece> lesPieces = new List<Piece.Piece>();   //permet de déclarer et de créer une liste de pièces
        public static List<Facture.Facture> lesFactures = new List<Facture.Facture>();   //permet de déclarer et de créer une liste de pièces

        // Objets
        public static Client.Client unClient = new Client.Client();
        public static Vendeur.Vendeur unVendeur;
        public static Voiture.Voiture uneVoiture;
        public static Piece.Piece unePiece;
        public static Facture.Facture uneFacture;

        // Pages
        public static PageAccueil PageAccueil;
        public static PagePrincipale PagePrinc;    
        public static Validation PageValidation;
        public static Résumé_Crédit PageResumeCredit;
        public static AffichageCredits PageAffichageCredits;
        public static PageAjout PageAjout;
        public static Résumé_AjoutClient PageResumeAjoutClient;
        public static Résumé_AjoutVendeur PageResumeAjoutVendeur;
        public static PageVoiture PageVoiture;
        public static Résumé_AjoutVoiture PageResumeAjoutVoiture;
        public static ReparationVoiture PageReparationVoiture;
        public static PageAjoutPieces PageAjoutPieces;
    }
}
