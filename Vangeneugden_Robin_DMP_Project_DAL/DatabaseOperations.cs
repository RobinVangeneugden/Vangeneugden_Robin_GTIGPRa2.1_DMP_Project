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

        public static List<Groep> OphalenGroepen()
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Groep>("SELECT * FROM MUZ.Groep").ToList();

            _muziekbandDb.Close();

            return result;
        }

        public static List<Groep> OphalenGroepenVanBandlid(int lidID)
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Groep>("SELECT * FROM MUZ.Groep INNER JOIN MUZ.LidGroep ON Groep.id = LidGroep.groepId INNER JOIN MUZ.Lid ON Lid.id = LidGroep.lidId WHERE Lid.id = @lidID", param: new { lidID }).ToList();

            _muziekbandDb.Close();

            return result;
        }



        public static List<Repetitie> OphalenRepetities()
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Repetitie>("SELECT * FROM MUZ.Repetitie").ToList();

            _muziekbandDb.Close();

            return result;
        }

        public static List<Locatie> OphalenLocaties()
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Locatie>("SELECT * FROM MUZ.Locatie").ToList();

            _muziekbandDb.Close();

            return result;
        }

        public static List<Optreden> OphalenOptredens()
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Optreden>("SELECT * FROM MUZ.Optreden").ToList();

            _muziekbandDb.Close();

            return result;
        }

        public static List<Instrument> OphalenInstrumenten()
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Instrument>("SELECT * FROM MUZ.Instrument").ToList();

            _muziekbandDb.Close();

            return result;
        }

        public static List<Instrument> OphalenInstrumentenVanBandlid(int lidID)
        {
            Start();

            var result = _muziekbandDb.Connectie.Query<Instrument>("SELECT * FROM MUZ.Instrument INNER JOIN MUZ.LidInstrument ON Instrument.id = LidInstrument.instrumentId INNER JOIN MUZ.Lid ON Lid.id = LidInstrument.lidId WHERE Lid.id = @lidID", param: new { lidID }).ToList();

            _muziekbandDb.Close();

            return result;
        }


    }
}
