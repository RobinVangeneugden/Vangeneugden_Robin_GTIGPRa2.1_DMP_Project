using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vangeneugden_Robin_DMP_Project_DAL
{

    public static class DatabaseOperations
    {
        private static DatabaseConnectie _muziekbandDb;

        private static void Start ()
        {
            _muziekbandDb = new DatabaseConnectie();
            _muziekbandDb.Open();
        }

        public static List<Lid> OphalenLeden()
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Lid>("SELECT * FROM MUZ.Lid").ToList();

            _muziekbandDb.Close();

            return result;
        }

        
    }
}
