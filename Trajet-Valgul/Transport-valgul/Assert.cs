using System;

namespace Tramway
{
    public static class Assert
    {
        public static void EstVrai(double ent, double verif, string msg)
        {
            if (Math.Abs(ent - verif) > 0.004)
                Console.WriteLine(msg + " valeur attendue " + ent + " valeur calculée " + verif);
        }

        public static void EstVrai(bool ent, bool verif, string msg)
        {
            if (ent != verif)
                Console.WriteLine(msg + " valeur attendue " + ent + " valeur calculée " + verif);
        }
        
        public static void EstVrai(string ent, string verif, string msg)
        {
            if (ent != verif)
                Console.WriteLine(msg + " valeur attendue " + ent + " valeur calculée " + verif);
        }
    }
}