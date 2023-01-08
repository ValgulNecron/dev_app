using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CreditCeleste
{
    static class ClassSql
    {
        private static SqlConnection connexion;
        
        public static void init()
        {
            string strConnexion;
            var ip = "127.0.0.1";
            var id = "root";
            var mdp = "password";
            var ic = "CreditCelesteCredit";
            strConnexion = "Data Source=" + ip + ";User Id=" + id + ";password=" + mdp + "; Initial Catalog=" + ic;
            connexion = new SqlConnection(strConnexion);
        }
        
        public static void majBddCredit(Credit credit)
        {
            SqlCommand sqlcommand;
            try
            {
                if (connexion.State == ConnectionState.Closed)
                {
                    connexion.Open();
                }
                if (credit.Equals(null))
                {
                    throw new ArgumentException("Le crédit est null");
                }
                sqlcommand = new SqlCommand("majBddCredit", connexion);
                sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlcommand.Parameters.Add(new SqlParameter("@montant", SqlDbType.Decimal).Value = credit.getMontant());
                sqlcommand.Parameters.Add(new SqlParameter("@duree", SqlDbType.Decimal).Value = credit.getDuree());
                sqlcommand.Parameters.Add(new SqlParameter("@taux", SqlDbType.Decimal).Value = credit.getTaux());
                sqlcommand.Parameters.Add(new SqlParameter("@mensualite", SqlDbType.Decimal).Value = credit.getMensualite());
                sqlcommand.ExecuteNonQuery();    
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<Credit> recupBddCredit()
        {
            SqlCommand sqlcommand;
            try
            {
                connexion.Open();
                sqlcommand = new SqlCommand("majBddCredit", connexion);
                SqlDataReader reader = sqlcommand.ExecuteReader();
                List<Credit> credit = new List<Credit>();
                while (reader.Read())
                {
                    Credit creditTemps = new Credit(reader.GetDouble(1), reader.GetDouble(2), reader.GetDouble(3));
                    const double tolerance = 0.00001;
                    if (Math.Abs(creditTemps.getMensualite() - reader.GetDouble(4)) > tolerance)
                    {
                        throw new ArgumentException("Erreur: la mensualiter stocker est diffenrete de celle stocker dans la base de donnée" +
                                            "donnée stocker: " + creditTemps.getMensualite() + "donnée dans la base de donnée: " + reader.GetDouble(4)
                                            + "difference: " + Math.Abs(creditTemps.getMensualite() - reader.GetDouble(4)));
                    }
                    credit.Add(creditTemps);
                }
                return credit;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Credit>();
            }
        }
    }
}