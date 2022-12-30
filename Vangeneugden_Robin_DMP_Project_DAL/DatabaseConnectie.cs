using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vangeneugden_Robin_DMP_Project_DAL
{
    public interface IDatabaseConnectie
    {
        void Connecteren();
        IDbConnection Connectie { get; set; }
        void Open();
        void Close();
    }
    public class DatabaseConnectie: IDatabaseConnectie
    {
        public IDbConnection Connectie { get; set; }

        public DatabaseConnectie()
        {
            Connecteren();
        }

        public void Connecteren()
        {
            try
            {
                //Connectie = new SqlConnection(ConfigurationManager.ConnectionStrings["TestEntities"].ConnectionString);
                Connectie = new SqlConnection("server=(localdb)\\mssqllocaldb;Database=MuziekbandBeheer;MultipleActiveResultSets=True;");
            }
            catch (Exception ex)
            {
                //throw new Exception("Er is een probleem met de SQL-connectie.");
                throw new Exception(ex.ToString());
            }
        }
        public void Open()
        {
            if (Connectie == null) Connecteren();

            Connectie.Open();
        }

        public void Close()
        {
            if (Connectie != null)
                Connectie.Close();
        }
    }
}
