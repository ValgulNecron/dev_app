using System.Collections.Generic;

namespace CreditCeleste
{
    internal static class Globales //pas besoin de new en static
    {
        //variable de classes
        //a utiliser directement
        //public static Concession uneConcession = new Concession("Munsch", "Nathan");
        //ensuite on utiliser les set pour mettre l'objet à jour
        //uniquement declarer l'objet
        public static Concession uneConcession;

        // Pour identifier mon application
        public static string monApplication = "MUNSCH";

        // Pour gérer les voitures communes aux différents écrans 
        public static Voiture uneVoiture; // C'est la voiture courrante !

        public static ClientVoit unClientVoit; //le client avec sa voiture

        //permet de créer et de declarer une liste de credit
        public static List<Credit> lesCredits = new List<Credit>();
    }
}