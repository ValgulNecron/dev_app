using System;
using System.Collections.Generic;
using System.Linq;

namespace Tramway
{
    public class Trajet
    {
        //private List<String> stations;
        //private List<int> tempsEntreStations;
        private static int vitesseKmH = 50;
        protected Ligne ligne;
        private Dictionary<string, int> tempsStation;

        public Trajet()
        {
            ligne = new Ligne();
            // stations = new List<String>();
            // tempsEntreStations = new List<int>();
            tempsStation = new Dictionary<string, int>();
        }

        public Trajet(string codeTrajet, string depart, string terminus)
        {
            ligne = new Ligne(codeTrajet, depart, depart);
            // stations = new List<String>();
            // tempsEntreStations = new List<int>();
            tempsStation = new Dictionary<string, int>();
        }

        public Ligne Ligne
        {
            get => ligne;
            set => ligne = value;
        }

        public List<string> getStations()
        {
            return tempsStation.Keys.ToList();
        }

        public List<int> getTempsEntreStations()
        {
            return tempsStation.Values.ToList();
        }
/*
        public void setStations(String station)
        {
            stations.Add(station);
        }

        public void setTempsEntreStations(int temps)
        {
            tempsEntreStations.Add(temps);
        } */

        public void setTempsStation(string station, int temps)
        {
            try
            {
                tempsStation.Add(station, temps);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Dictionary<string, int> getTempsStation()
        {
            return tempsStation;
        }

        public void setTrajet(Ligne ligne, Dictionary<string, int> dico)
        {
            this.ligne = ligne;
            //this.stations = stations;
            //this.tempsEntreStations = tempsEntreStations;
            tempsStation = dico;
        }

        public void rajoutStation(string station, int temps)
        {
            //stations.Add(station);
            //tempsEntreStations.Add(temps);
            tempsStation.Add(station, temps);
        }

        public string afficherTrajet()
        {
            string affichage;
            affichage = "Ligne : " + ligne.CodeLigne;
            // for (int i = 0; i < stations.Count; i++)
            foreach (var entry in tempsStation) affichage += "\nStation : " + entry.Key;
            /* pas besoin des durées entre les stations
                affichage += "\nStation : " + stations[i] + " - Temps : " + tempsEntreStations[i]; */
            //    affichage += "\nStation : " + stations[i];
            return affichage;
        }

        public bool verifieCoherence()
        {
            List<String> stations = getStations();
            if (ligne.TerminusLigne != stations[stations.Count - 1]) return false;
            if (ligne.DepartLigne != stations[0]) return false;

            return true;
        }

        public virtual int tempsDeTrajet()
        {
            var temps = 0;
            // for (int i = 0; i < tempsEntreStations.Count; i++)
            foreach (var entry in tempsStation) temps += entry.Value;
            //temps += tempsEntreStations[i];
            return temps;
        }

        public int tempsDeTrajet(int stationDepart)
        {
            var temps = 0;
            var tempsEntreStations = tempsStation.Values.ToList();
            for (var i = stationDepart - 1; i < tempsEntreStations.Count; i++) temps += tempsEntreStations[i];

            return temps;
        }

        public int tempsDeTrajet(int stationDepart, int stationArrivee)
        {
            var temps = 0;
            var tempsEntreStations = tempsStation.Values.ToList();
            for (var i = stationDepart; i < stationArrivee; i++) temps += tempsEntreStations[i];

            return temps;
        }

        public int tempsDeTrajet(string stationDepart)
        {
            var temps = 0;
            var depart = 0;
            var go = false;
            foreach (var entry in tempsStation)
            {
                if (entry.Key == stationDepart) go = true;

                if (go) temps += entry.Value;
            }

            return temps;
        }

        public int tempsDeTrajet(string stationDepart, string stationArrivee)
        {
            var temps = 0;
            var depart = 0;
            var arrivee = 0;
            var go = false;
            foreach (var entry in tempsStation)
            {
                if (entry.Key == stationDepart) go = true;
                if (entry.Key == stationArrivee) go = false;
                if (go) temps += entry.Value;
            }

            return temps;
        }

        public string compareStation(Trajet trajet)
        {
            /*
            var listeDesStationsCommunes = new List<string>();
            for (var i = 0; i < stations.Count; i++)
            for (var j = 0; j < trajet.stations.Count; j++)
                if (stations[i] == trajet.stations[j])
                    if (!listeDesStationsCommunes.Contains(stations[i]))
                        listeDesStationsCommunes.Add(stations[i]);

            var stationsCommunes = "";
            for (var i = 0; i < listeDesStationsCommunes.Count; i++)
                stationsCommunes += listeDesStationsCommunes[i] + ", " + listeDesStationsCommunes.Count;*/
            String stationsCommunes = "";
            List < String > listeStationsCommunes = new List<String>();
            foreach (var entry in tempsStation)
            {
                foreach (var entry2 in trajet.tempsStation)
                {
                    if (entry.Key == entry2.Key)
                    {
                        if (!listeStationsCommunes.Contains(entry.Key))
                        {
                            listeStationsCommunes.Add(entry.Key);
                            stationsCommunes += entry.Key + ", ";
                        }
                    }
                }
                {
                    
                }
            }
            return stationsCommunes;
        }

        public static string listeDesStationCommunes(Trajet trajet1, Trajet trajet2)
        {
            String stationsCommunes = "";
            List<String> listeStationsCommunes = new List<String>();
            foreach (var entry in trajet1.tempsStation)
            {
                foreach (var entry2 in trajet2.tempsStation)
                {
                    if (entry.Key == entry2.Key)
                    {
                        if (!listeStationsCommunes.Contains(entry.Key))
                        {
                            listeStationsCommunes.Add(entry.Key);
                            stationsCommunes += entry.Key + ", ";
                        }
                    }
                }

                {

                }
            }
            return stationsCommunes;
        }
    }
}