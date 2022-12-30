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

        public static Lid OphalenLidById(int lidID)
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Lid>("SELECT * FROM MUZ.Lid WHERE Lid.id = @lidID", param: new { lidID }).SingleOrDefault();

            _muziekbandDb.Close();

            return result;
        }

        public static bool AddBandlid(Lid lid)
        {


            string sql = @"INSERT INTO MUZ.Lid (Lid.id, Lid.voornaam, Lid.familienaam, Lid.geslacht, Lid.straat, Lid.huisnummer, Lid.postcode, Lid.gemeente, Lid.land, Lid.rijksregisternr, Lid.telefoon, Lid.email, Lid.inschrijvingsDatum)
                            VALUES (@lidID, @Voornaam, @Familienaam, @Geslacht, @Straat, @Huisnummer, @Postcode, @Gemeente, @Land, @Rijksregnr, @Telefoonnr, @Email, @InschrijvingsDatum)";

            var parameters = new
            {
                @lidID = lid.id,
                @Voornaam = lid.voornaam,
                @Familienaam = lid.familienaam,
                @Geslacht = lid.geslacht,
                @Straat = lid.straat,
                @Huisnummer = lid.huisnummer,
                @Gemeente = lid.gemeente,
                @Postcode = lid.postcode,
                @Land = lid.land,
                @Rijksregnr = lid.rijksregisternr,
                @Telefoonnr = lid.telefoon,
                @Email = lid.email,
                @InschrijvingsDatum = lid.inschrijvingsDatum
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);


            if (affectedRows >= 1)
            {
                return true;
            }

            _muziekbandDb.Close();

            return false;
        }

        public static bool UpdateBandlid(Lid lid)
        {


            string sql = @"UPDATE MUZ.Lid SET   Lid.voornaam = @Voornaam, 
                                                Lid.familienaam = @Familienaam, 
                                                Lid.geslacht = @Geslacht, 
                                                Lid.straat = @Straat, 
                                                Lid.huisnummer = @Huisnummer, 
                                                Lid.postcode = @Postcode, 
                                                Lid.gemeente = @Gemeente, 
                                                Lid.land = @Land, 
                                                Lid.rijksregisternr = @Rijksregnr, 
                                                Lid.telefoon = @Telefoonnr, 
                                                Lid.email = @Email, 
                                                Lid.inschrijvingsDatum = @InschrijvingsDatum
                                        WHERE Lid.id = @lidID"; 

            var parameters = new
            {
                @lidID = lid.id,
                @Voornaam = lid.voornaam,
                @Familienaam = lid.familienaam,
                @Geslacht = lid.geslacht,
                @Straat = lid.straat,
                @Huisnummer = lid.huisnummer,
                @Gemeente = lid.gemeente,
                @Postcode = lid.postcode,
                @Land = lid.land,
                @Rijksregnr = lid.rijksregisternr,
                @Telefoonnr = lid.telefoon,
                @Email = lid.email,
                @InschrijvingsDatum = lid.inschrijvingsDatum
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);


            if (affectedRows >= 1)
            {
                return true;
            }

            _muziekbandDb.Close();

            return false;
        }

        public static List<Locatie> OphalenLocaties()
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Locatie>("SELECT * FROM MUZ.Locatie").ToList();

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


        public static bool AddGroepVanBandlid(int lidID, int groepID)
        {


            string sql = @" IF NOT EXISTS (SELECT * FROM MUZ.LidGroep WHERE LidGroep.lidId = @lidID AND LidGroep.groepId = @groepID)
                            INSERT INTO MUZ.LidGroep (LidGroep.lidId, LidGroep.groepId)
                            VALUES (@lidID, @groepID)";

            var parameters = new
            {
                @lidID = lidID,
                @groepID = groepID
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);


            if (affectedRows >= 1)
            {
                return true;
            }

            _muziekbandDb.Close();

            return false;
        }

        public static bool DeleteGroepVanBandlid(int lidID, int groepID)
        {


            string sql = @"DELETE FROM MUZ.LidGroep WHERE LidGroep.lidId = @lidID AND LidGroep.groepId = @groepID";

            var parameters = new
            {

                @lidID = lidID,
                @groepID = groepID
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);


            if (affectedRows == 1)
            {
                return true;
            }

            _muziekbandDb.Close();

            return false;


        }


        public static List<Repetitie> OphalenRepetities()
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Repetitie>("SELECT * FROM MUZ.Repetitie").ToList();

            _muziekbandDb.Close();

            return result;
        }

        public static List<Repetitie> OphalenRepetitiesVanBandlid(int lidID)
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Repetitie>("SELECT DISTINCT Repetitie.* FROM MUZ.Repetitie INNER JOIN MUZ.LidRepetitie ON Repetitie.id = LidRepetitie.repetitieId INNER JOIN MUZ.Lid ON Lid.id = LidRepetitie.lidId WHERE Lid.id = @lidID", param: new { lidID }).ToList();

            _muziekbandDb.Close();

            return result;
        }

        public static bool AddRepetitiesVanBandlid(int lidID, int repetitieID)
        {


            string sql = @" IF NOT EXISTS (SELECT * FROM MUZ.LidRepetitie WHERE LidRepetitie.lidId = @lidID AND LidRepetitie.repetitieId = @repetitieID)
                            INSERT INTO MUZ.LidRepetitie (LidRepetitie.lidId, LidRepetitie.repetitieId)
                            VALUES (@lidID, @repetitieID)";

            var parameters = new
            {
                @lidID = lidID,
                @repetitieID = repetitieID
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);


            if (affectedRows >= 1)
            {
                return true;
            }

            _muziekbandDb.Close();

            return false;
        }

        public static bool DeleteRepetitieVanBandlid(int lidID, int repetitieID)
        {


            string sql = @"DELETE FROM MUZ.LidRepetitie WHERE LidRepetitie.repetitieId = @repetitieID AND LidRepetitie.lidId = @lidID";

            var parameters = new
            {
                @lidID = lidID,
                @repetitieID = repetitieID
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);


            if (affectedRows >= 1)
            {
                return true;
            }

            _muziekbandDb.Close();

            return false;


        }

        public static List<Optreden> OphalenOptredens()
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Optreden>("SELECT * FROM MUZ.Optreden").ToList();

            _muziekbandDb.Close();

            return result;
        }

        public static List<Optreden> OphalenOptredensVanBandlid(int lidID)
        {
            Start();
            var result = _muziekbandDb.Connectie.Query<Optreden>("SELECT DISTINCT Optreden.* FROM MUZ.Optreden INNER JOIN MUZ.LidOptreden ON Optreden.id = LidOptreden.optredenId INNER JOIN MUZ.Lid ON Lid.id = LidOptreden.lidId WHERE Lid.id = @lidID", param: new { lidID }).ToList();

            _muziekbandDb.Close();

            return result;
        }

        public static bool AddOptredensVanBandlid(int lidID, int optredenID)
        {


            string sql = @" IF NOT EXISTS (SELECT * FROM MUZ.LidOptreden WHERE LidOptreden.lidId = @lidID AND LidOptreden.optredenId = @optredenID)
                            INSERT INTO MUZ.LidOptreden (LidOptreden.lidId, LidOptreden.optredenId)
                            VALUES (@lidID, @optredenID)";

            var parameters = new
            {
                @lidID = lidID,
                @optredenID = optredenID
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);


            if (affectedRows >= 1)
            {
                return true;
            }

            _muziekbandDb.Close();

            return false;
        }

        public static bool DeleteOptredenVanBandlid(int lidID, int optredenID)
        {


            string sql = @"DELETE FROM MUZ.LidOptreden WHERE LidOptreden.optredenId = @optredenID AND LidOptreden.lidId = @lidID";

            var parameters = new
            {
                @lidID = lidID,
                @optredenID = optredenID
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);


            if (affectedRows >= 1)
            {
                return true;
            }

            _muziekbandDb.Close();

            return false;


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

        public static bool AddInstrumentVanBandlid(int lidID, int instrumentID)
        {
            

            string sql = @" IF NOT EXISTS (SELECT * FROM MUZ.LidInstrument WHERE LidInstrument.lidId = @lidID AND LidInstrument.instrumentId = @instrumentID)
                            INSERT INTO MUZ.LidInstrument (LidInstrument.lidId, LidInstrument.instrumentId)
                            VALUES (@lidID, @instrumentID)";

            var parameters = new
            {
                @lidID = lidID,
                @instrumentID = instrumentID
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);

            
            if (affectedRows >= 1)
            {
                return true;
            }

            _muziekbandDb.Close();

            return false;
        }
        public static bool DeleteInstrumentVanBandlid(int lidID, int instrumentID)
        {


            string sql = @"DELETE FROM MUZ.LidInstrument WHERE LidInstrument.instrumentId = @instrumentID AND LidInstrument.lidId = @lidID";

            var parameters = new
            {
                @lidID = lidID,
                @instrumentID = instrumentID
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);


            if (affectedRows >= 1)
            {
                return true;
            }

            _muziekbandDb.Close();

            return false;


        }

        public static bool DeleteBandlid(int lidID)
        {
            

            string sql = @"DELETE FROM MUZ.LidInstrument WHERE LidInstrument.lidId = @lidID; DELETE FROM MUZ.LidGroep WHERE LidGroep.lidId = @lidID; DELETE FROM MUZ.Lid WHERE Lid.id = @lidID;";

            var parameters = new
            {
                @lidID = lidID
            };

            Start();

            var affectedRows = _muziekbandDb.Connectie.Execute(sql, parameters);

            
                if (affectedRows >= 1)
                {
                    return true;
                }

            _muziekbandDb.Close();

            return false;
        }
    }
}
