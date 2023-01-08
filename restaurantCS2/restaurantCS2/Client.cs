using System.Collections.Generic;

namespace consResto
{
    public class Client
    {
        //attributs de la classe Client 
        private string adresseClient, prenomClient, nomClient;
        private Menu mnu;

        private List<Menu> mnuTab = new List<Menu>();

        // private Menu[] mnuTab= new Menu[10];
        private int nbreMenu;
        private int numeroClient;

        public Client()
        {
            numeroClient = -1;
            adresseClient = prenomClient = nomClient = "  ";
        }//constructeur par defaut

        public Client(int numCli)
        {
            adresseClient = prenomClient = nomClient = "  ";
            numeroClient = numCli;
        }//constructeur avec parametre

        public Client(int numCli, string nomCli, string prenomCli)
        {
            adresseClient = "    ";
            nomClient = nomCli;
            numeroClient = numCli;
            prenomClient = prenomCli;
        }//constructeur avec parametre

        public int GetNumeroClient()
        {
            return numeroClient;
        }//recuperer le numero du client

        public void SetNumeroClient(int numCli)
        {
            numeroClient = numCli;
        }//modifier le numero du client

        public string GetNomClient()
        {
            return nomClient;
        }//recuperer le nom du client

        public void SetNomClient(string nomCli)
        {
            nomClient = nomCli;
        }//modifier le nom du client

        public string GetPrenomClient()
        {
            return prenomClient;
        }

        public void SetPrenomClient(string prenomCli)
        {
            prenomClient = prenomCli;
        }

        public string GetAdresseClient()
        {
            return adresseClient;
        }

        public void SetAdresseClient(string adresseCli)
        {
            adresseClient = adresseCli;
        }

        public void Mange(Menu unMenu)
        {
            mnu = unMenu;
        }

        public Menu GetMange()
        {
            return mnu;
        }

        public void rajouteMenu(Menu menu)
        {
            /*mnuTab[nbreMenu] = menu;
            nbreMenu += 1;*/
            mnuTab.Add(menu);
        }

        public virtual double Addition()
        {
            var addition = 0;
            /*for (int i = 0; i < nbreMenu; i++)
            {
                addition += mnuTab[i].PrixMenu();
            }*/
            foreach (var item in mnuTab) addition += item.PrixMenu();
            return addition;
        }

        public double Addition(double reduc)
        {
            double addition = 0;
            Addition();
            addition = addition - addition / 100 * reduc;
            return addition;
        }
    }
}