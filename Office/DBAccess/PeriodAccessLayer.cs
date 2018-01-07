using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Timetabling.Core;
using Timetabling.Objects;

namespace Timetabling.DBAccess
{
    sealed class PeriodAccessLayer
    {
        MDatabase _db;

        public PeriodAccessLayer(MDatabase db)
        {
            _db = db;
        }

        // Functionality

        public List<Period> GetAllPeriods()
        {
            List<Period> results = new List<Period>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM MasterBlocks";
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetPeriodFromReader(_db.Rdr)); 
            }
            return results;
        }

        public Period GetPeriodById(int id)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM MasterBlocks WHERE Id = @id";
            _db.Cmd.Parameters.AddWithValue("@id", id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                if (_db.Rdr.Read())
                    return GetPeriodFromReader(_db.Rdr); 
            }
            return null;
        }

        public List<Period> GetAvailablePeriods(Instrument instrument, Term term, DayOfWeek day)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            // Checks for periods that are available for the particular instrument, term and day of week
            _db.Cmd.CommandText = "SELECT * FROM MasterBlocks WHERE NOT EXISTS (SELECT * FROM Block WHERE MasterBlocks.Id = Block.MasterBlock AND Instrument = @iId AND Term = @term AND Day = @day)";
            _db.Cmd.Parameters.AddWithValue("@iId", instrument.Id);
            _db.Cmd.Parameters.AddWithValue("@term", term.Id);
            _db.Cmd.Parameters.AddWithValue("@day", day);
            List<Period> results = new List<Period>();
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetPeriodFromReader(_db.Rdr)); 
            }
            return results;
        }

        public List<Period> GetFreePeriods(Instrument instrument, Term term, DayOfWeek day)
        {
            TutorAccessLayer TAL = new TutorAccessLayer(Session.Database);
            List<Tutor> tutorsForInstrument = TAL.GetTutorsByInstrument(instrument);
            List<Period> allPeriods = GetAllPeriods();
            for (int i = 0; i < allPeriods.Count; i++)
            {
                bool periodAvailable = false;
                foreach (Tutor t in tutorsForInstrument)
                {
                    if (!TAL.IsTutorBusyPeriod(t, term, day, allPeriods[i]))
                        periodAvailable = true;
                }
                if (!periodAvailable)
                {
                    allPeriods.RemoveAt(i);
                    i--;
                }
            }
            return allPeriods;
        }

        public List<Period> GetTakenPeriods(Instrument instrument, Term term, DayOfWeek day)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            // Checks for periods that are available for the particular instrument, term and day of week
            _db.Cmd.CommandText = "SELECT * FROM Block, Tutor, TutorInstrument WHERE Block.Instrument = ";
            _db.Cmd.Parameters.AddWithValue("@iId", instrument.Id);
            _db.Cmd.Parameters.AddWithValue("@term", term.Id);
            _db.Cmd.Parameters.AddWithValue("@day", day);
            List<Period> results = new List<Period>();
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetPeriodFromReader(_db.Rdr));
            }
            return results;
        }

        private Period GetPeriodFromReader(SqlDataReader rdr)
        {
            return new Period(rdr.GetInt32(0), rdr.GetTimeSpan(1), rdr.GetTimeSpan(2));
        }
    }
}
