using System;
using Tramway;

namespace Tramway
{
    public class TrajetRapide: Trajet
    {
        DateTime ouverture;
        DateTime fermeture;
        public TrajetRapide() : base()
        {
        }
        public TrajetRapide(string codeLigne, String depart, string terminus, DateTime ouverture, DateTime fermeture) : base(codeLigne, depart, terminus)
        {
            this.ouverture = ouverture;
            this.fermeture = fermeture;
        }

        public new String afficherTrajet()
        {
            string affichage;
            affichage = "Ligne : " + ligne.CodeLigne;
            affichage += "\nStation : " + ligne.DepartLigne;
            return affichage;
        }

        public TimeSpan nombreJourOuvert()
        {
            return (fermeture - ouverture);
        }
        
        public override int tempsDeTrajet()
        {
            return base.tempsDeTrajet()/2;
        }
    }
}