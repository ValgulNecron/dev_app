using System;

namespace Tramway
{
    internal class Transporvalgul
    {
        public static void Main(string[] args)
        {
            var trajet = new Trajet("F", "Cameroun", "Louis");
            Assert.EstVrai(0, trajet.getStations().Count, "Le trajet doit être vide");
            trajet.rajoutStation("Cameroun", 6);
            trajet.rajoutStation("Pommier", 7);
            trajet.rajoutStation("Platon", 6);
            trajet.rajoutStation("Gargantua", 4);
            trajet.rajoutStation("valgul", 3);
            trajet.rajoutStation("Clovis", 2);
            trajet.rajoutStation("Perce-neige", 8);
            trajet.rajoutStation("Louis", 0);

            Console.WriteLine(trajet.afficherTrajet());

            Console.WriteLine("________________________");

            if (trajet.verifieCoherence())
                Console.WriteLine("La saisie est cohérent");
            else
                Console.WriteLine("La saisie n'est pas cohérent");

            Console.WriteLine("________________________");

            Console.WriteLine("Duree totale : " + trajet.tempsDeTrajet());

            Console.WriteLine("________________________");

            Console.WriteLine("Duree entre la station 2 et 4 :" + trajet.tempsDeTrajet(2, 4));

            Console.WriteLine("________________________");

            Console.WriteLine("Duree entre la station 2 et le terminus :" + trajet.tempsDeTrajet(2));

            Console.WriteLine("________________________");


            var trajetRapide = new TrajetRapide("FF", "Cameroun", "Louis",
                new DateTime(2022, 6, 12, 0, 0, 0)
                , new DateTime(2022, 9, 27, 0, 0, 0));
            trajetRapide.rajoutStation("Cameroun", 6);
            trajetRapide.rajoutStation("Pommier", 7);
            trajetRapide.rajoutStation("Platon", 6);
            trajetRapide.rajoutStation("Gargantua", 4);
            trajetRapide.rajoutStation("valgul", 3);
            trajetRapide.rajoutStation("Clovis", 2);
            trajetRapide.rajoutStation("Perce-neige", 8);
            trajetRapide.rajoutStation("Louis", 0);

            Console.WriteLine("Le trajet rapide est ouvert : " + trajetRapide.nombreJourOuvert().Days + "jours");

            Console.WriteLine("________________________");

            var minute =
                trajetRapide.tempsDeTrajet() *
                2; // oublie de comment utiliser la fonction tempsDeTrajet() de la classe mere 
            var heure = 0;
            while (minute > 60)
            {
                minute -= 60;
                heure++;
            }

            Console.WriteLine("Duree totale : " + heure + "h" + minute);

            Console.WriteLine("________________________");

            var minute2 = trajetRapide.tempsDeTrajet();
            var heure2 = 0;
            while (minute > 60)
            {
                minute -= 60;
                heure++;
            }

            Console.WriteLine("Duree totale en trajet rapide : " + heure2 + "h" + minute2);

            Console.WriteLine("________________________");

            Console.WriteLine("Duree entre la station Pommier et Platon :" + trajet.tempsDeTrajet("Pommier", "Platon"));

            Console.WriteLine("________________________");

            Console.WriteLine("Duree entre la station Pommier et le terminus :" + trajet.tempsDeTrajet("Pommier"));

            Console.WriteLine("________________________");

            var trajet2 = new Trajet("A", "Rondin", "Garrigue");
            trajet2.rajoutStation("Rondin", 15);
            trajet2.rajoutStation("Souci", 7);
            trajet2.rajoutStation("Pommier", 7);
            trajet2.rajoutStation("valgul", 2);
            trajet2.rajoutStation("Roseraie", 12);
            trajet2.rajoutStation("Catamaran", 3);
            trajet2.rajoutStation("Gutenberg", 2);
            trajet2.rajoutStation("Garrigue", 0);

            Console.WriteLine(trajet2.compareStation(trajet));
        }
    }
}