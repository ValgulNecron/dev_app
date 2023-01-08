using System;
using System.Data.SqlClient;

namespace convendeur
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try //essaye 
            {
                //connexion a la bdd
                //serveur ; l'adresse ip/dns
                //la base de données
                //le moyen securisé : id / mdp
                //
                //authentification sqlServeur
                //var strConnexion = "Data Source=10.129.253.209;User Id=connEleveSio;password=mdpEleveSio; Initial Catalog=creditCeleste";
                // authentification active directory
                var strConnexion = "Data Source=10.129.253.209;Integrated Security=SSPI;Initial Catalog=creditCeleste";
                //requete
                var strRequete = "SELECT nomVendeur, prenomVendeur FROM Vendeur";
                //connexion à la bdd
                var oConnexion = new SqlConnection(strConnexion);
                //ouverture de la connexion
                oConnexion.Open();
                //création de la commande
                var oCommand = new SqlCommand(strRequete, oConnexion);
                //execution de la commande
                oCommand.ExecuteNonQuery();
                //création du reader
                var oReader = oCommand.ExecuteReader();
                //lecture du reader
                while (oReader.Read()) Console.WriteLine(oReader["nomVendeur"] + " " + oReader["prenomVendeur"]);
                //fermeture du reader
                oReader.Close();
                //fermeture de la connexion
                oConnexion.Close();
                Console.ReadLine();
            }
            catch (Exception e) // et affiche l'erreur si y en a une
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}