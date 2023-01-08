    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantClasse
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mnuEco = new Menu("Menu economique", "Salade Verte", "Steak Haché", "Pomme", 3, 6, 2);
            var mnuClass = new Menu("Menu Classique");
            mnuClass.SetNomEntree("Rillete de la mer");
            mnuClass.SetNomPlatPrincipal("Steak Frites");
            mnuClass.SetNomDessert("Boule de glace");
            mnuClass.SetPrixEntree(5);
            mnuClass.SetPrixPlatPrincipal(8);
            mnuClass.SetPrixDessert(4);

            var mnuGastro = new Menu();
            mnuGastro.SetLesNom("Menu Gastronomique", "Meli-mélo", "Croustade de la mer", "Sabayon aux fruit des bois");
            mnuGastro.SetLesPrix(8, 12, 6);


            var clt1 = new Client(1, "Dupont", "Pierre");
            clt1.SetAdresseClient("4 rue des pieds");
            clt1.Mange(mnuEco);
            var clt2 = new Client(2, "Wecker", "Thierry");
            clt2.SetAdresseClient("2 rue de l'Eglise Strasbourg");
            clt2.Mange(mnuGastro);
            var clt3 = new Client(3, "Sayn", "Mehmet");
            clt3.SetAdresseClient("27 rue de la Marne Strasbourg");
            clt3.Mange(mnuClass);
            var clt4 = new Client(4, "Demetz", "Stéphanie");
            clt4.SetAdresseClient("4 avenue de l'Opéra Mulhouse");
            clt4.Mange(mnuEco);


            Console.WriteLine(mnuEco.GetNomMenu() + "   :");
            Console.WriteLine("     entrée : " + mnuEco.GetNomEntree());
            Console.WriteLine("     plat principale : " + mnuEco.GetNomPlatPrincipal());
            Console.WriteLine("     entrée : " + mnuEco.GetNomDessert());
            Console.WriteLine("     prix menu : " + mnuEco.PrixMenu());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(mnuClass.GetNomMenu() + "   :");
            Console.WriteLine("     entrée : " + mnuClass.GetNomEntree());
            Console.WriteLine("     plat principale : " + mnuClass.GetNomPlatPrincipal());
            Console.WriteLine("     entrée : " + mnuClass.GetNomDessert());
            Console.WriteLine("     prix menu : " + mnuClass.PrixMenu());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(mnuGastro.GetNomMenu() + "   :");
            Console.WriteLine("     entrée : " + mnuGastro.GetNomEntree());
            Console.WriteLine("     plat principale : " + mnuGastro.GetNomPlatPrincipal());
            Console.WriteLine("     entrée : " + mnuGastro.GetNomDessert());
            Console.WriteLine("     prix menu : " + mnuGastro.PrixMenu());

            for (var i = 0; i < 10; i++) Console.WriteLine("");


            Console.WriteLine("Prénom   " + clt1.GetPrenomClient());
            Console.WriteLine("Nom      " + clt1.GetNomClient());
            Console.WriteLine("Adresse  " + clt1.GetAdresseClient());
            Console.WriteLine("Numéro   " + clt1.GetNumeroClient());
            var tempsMenu = clt1.GetMange();
            Console.WriteLine("le nom du menu que le client mange est le " + tempsMenu.GetNomMenu());
            Console.WriteLine("le prix a payer est " + tempsMenu.PrixMenu());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Prénom   " + clt2.GetPrenomClient());
            Console.WriteLine("Nom      " + clt2.GetNomClient());
            Console.WriteLine("Adresse  " + clt2.GetAdresseClient());
            Console.WriteLine("Numéro   " + clt2.GetNumeroClient());
            tempsMenu = clt2.GetMange();
            Console.WriteLine("le nom du menu que le client mange est le " + tempsMenu.GetNomMenu());
            Console.WriteLine("le prix a payer est " + tempsMenu.PrixMenu());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Prénom   " + clt3.GetPrenomClient());
            Console.WriteLine("Nom      " + clt3.GetNomClient());
            Console.WriteLine("Adresse  " + clt3.GetAdresseClient());
            Console.WriteLine("Numéro   " + clt3.GetNumeroClient());
            tempsMenu = clt3.GetMange();
            Console.WriteLine("le nom du menu que le client mange est le " + tempsMenu.GetNomMenu());
            Console.WriteLine("le prix a payer est " + tempsMenu.PrixMenu());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Prénom   " + clt4.GetPrenomClient());
            Console.WriteLine("Nom      " + clt4.GetNomClient());
            Console.WriteLine("Adresse  " + clt4.GetAdresseClient());
            Console.WriteLine("Numéro   " + clt4.GetNumeroClient());
            tempsMenu = clt4.GetMange();
            Console.WriteLine("le nom du menu que le client mange est le " + tempsMenu.GetNomMenu());
            Console.WriteLine("le prix a payer est " + tempsMenu.PrixMenu());

            Console.ReadLine();


            var clt5 = new Client(5, "Charlier", "Yann");
            clt5.SetAdresseClient("15 rue d'auvergne");
            clt5.rajouteMenu(mnuEco);
            clt5.rajouteMenu(mnuEco);
            clt5.rajouteMenu(mnuGastro);
            clt5.rajouteMenu(mnuGastro);
            clt5.rajouteMenu(mnuGastro);
            clt5.rajouteMenu(mnuGastro);
            clt5.rajouteMenu(mnuClass);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Prénom   " + clt5.GetPrenomClient());
            Console.WriteLine("Nom      " + clt5.GetNomClient());
            Console.WriteLine("Adresse  " + clt5.GetAdresseClient());
            Console.WriteLine("Numéro   " + clt5.GetNumeroClient());
            Console.WriteLine("addition " + clt5.Addition());
            Console.WriteLine("adittion avec reduction " + clt5.Addition(15));


            Console.ReadLine();
            var cltf1 = new ClientFid(1, "Clientfid", "Ahmet");
            var cltf2 = new ClientFid(2, "Charlier", "Yann");
            cltf2.SetAdresseClient("12 rue de la mairie");
            cltf1.rajouteMenu(mnuEco);
            cltf1.rajouteMenu(mnuEco);
            cltf1.rajouteMenu(mnuGastro);
            cltf1.rajouteMenu(mnuGastro);
            cltf1.rajouteMenu(mnuGastro);
            cltf1.rajouteMenu(mnuGastro);
            cltf1.rajouteMenu(mnuClass);
            cltf2.rajouteMenu(mnuEco);
            cltf2.rajouteMenu(mnuEco);
            cltf2.rajouteMenu(mnuGastro);
            cltf2.rajouteMenu(mnuGastro);
            cltf2.rajouteMenu(mnuGastro);
            cltf2.rajouteMenu(mnuGastro);
            cltf2.rajouteMenu(mnuClass);
            for (var i = 0; i < 10; i++) Console.WriteLine("");
            Console.WriteLine("Prénom   " + cltf1.GetPrenomClient());
            Console.WriteLine("Nom      " + cltf1.GetNomClient());
            Console.WriteLine("Adresse  " + cltf1.GetAdresseClient());
            Console.WriteLine("Numéro   " + cltf1.GetNumeroClient());
            Console.WriteLine("addition si vous n'etiez pas une client fidele " + cltf1.AdditionNormal());
            Console.WriteLine("addition " + cltf1.Addition());
            Console.WriteLine("adittion avec reduction " + cltf1.Addition(15));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Prénom   " + cltf2.GetPrenomClient());
            Console.WriteLine("Nom      " + cltf2.GetNomClient());
            Console.WriteLine("Adresse  " + cltf2.GetAdresseClient());
            Console.WriteLine("Numéro   " + cltf2.GetNumeroClient());
            Console.WriteLine("addition si vous n'etiez pas une client fidele " + cltf2.AdditionNormal());
            Console.WriteLine("addition " + cltf2.Addition());
            Console.WriteLine("adittion avec reduction " + cltf2.Addition(15));

            MonGenerique.WriteXML(cltf1.mnuTab);
            MonGenerique.WriteJSON(cltf1.mnuTab);
            MonGenerique.WriteYAML(cltf1.mnuTab);

            Console.ReadLine();
        }
    }
}

