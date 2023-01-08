using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    public abstract class Client
    {
        //abstract permet de ne pas pouvoir faire de client simple juste des clients voit
        private int numeroClient;
        private string civClient;
        private string nomClient;
        private string prenomClient;
        private string adresseClient;

        public Client()
        {
            numeroClient = 0;
            nomClient = "Munsch";
            prenomClient = "Nathan";
            adresseClient = "7 rue du Nagelsthal Windstein";
        }

        public Client(int numCli)
        {
            numeroClient = numCli;
            nomClient = "Munsch";
            prenomClient = "Nathan";
            adresseClient = "7 rue du Nagelsthal Windstein";
        }

        public Client(int numCli, string nomCli, string prenomCli)
        {
            numeroClient = numCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
            adresseClient = "7 rue du Nagelsthal Windstein";
        }

        public int getNumeroClient()
        {
            return (numeroClient);
        }

        public void setNumeroClient(int numCli)
        {
            numeroClient = numCli;
        }

        public string getNomClient()
        {
            return (nomClient);
        }

        public void setNomClient(string nomCli)
        {
            nomClient = nomCli;
        }

        public string getPrenomClient()
        {
            return (prenomClient);
        }

        public void setPrenomClient(string prenomCli)
        {
            prenomClient = prenomCli;
        }

        public string getAdresseClient()
        {
            return (adresseClient);
        }

        public void setAdresseClient(string adresseCli)
        {
            adresseClient = adresseCli;
        }

        public string getCivClient()
        {
            return civClient;
        }

        public void setCivClient(string civCli)
        {
            civClient = civCli;
        }
    }
}