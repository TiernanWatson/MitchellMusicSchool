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
    sealed class TutorAccessLayer
    {
        MDatabase _db;

        public TutorAccessLayer(MDatabase db)
        {
            _db = db;
        }

        // Functionality

        public bool Login(string username, string password)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Tutor WHERE Username = @username AND Password = @password";
            _db.Cmd.Parameters.AddWithValue("@username", username); // Prevents SQL Injection
            _db.Cmd.Parameters.AddWithValue("@password", password);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                if (_db.Rdr.Read())
                {
                    Session.CurUser = GetTutorFromReader(_db.Rdr);
                    return true;
                }
            }
            return false;
        }

        public List<Tutor> GetAllTutors()
        {
            List<Tutor> results = new List<Tutor>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Tutor";
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetTutorFromReader(_db.Rdr));
            }
            return results;
        }

        public Tutor GetTutorByID(int id)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Tutor WHERE Id = @id";
            _db.Cmd.Parameters.AddWithValue("@id", id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                if (_db.Rdr.Read())
                    return GetTutorFromReader(_db.Rdr); 
                else 
                    return null; 
            }
        }

        public List<Tutor> GetAvailableTutors(Period period, Term term, DayOfWeek day)
        {
            List<Tutor> results = new List<Tutor>();
            _db.Cmd = _db.Conn.CreateCommand();
            // Try using list of tutors that do tutor that instrument and compare who is available
            _db.Cmd.CommandText = "SELECT Tutor.Id, Tutor.Forename, Tutor.Surname, Tutor.Username, Tutor.Password FROM Tutor WHERE NOT EXISTS (SELECT * FROM Block WHERE Tutor.Id = Block.Tutor AND MasterBlock = @period AND Term = @term AND Day = @day)";
            _db.Cmd.Parameters.AddWithValue("@day", day);
            _db.Cmd.Parameters.AddWithValue("@term", term.Id);
            _db.Cmd.Parameters.AddWithValue("@period", period.Id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetTutorFromReader(_db.Rdr)); 
            }
            return results;
        }

        public List<Tutor> GetAvailableTutorsInstrument(Instrument instrument, Period period, Term term, DayOfWeek day)
        {
            List<Tutor> freeTutors = GetAvailableTutors(period, term, day);
            List<Tutor> tutorsForInstrument = GetTutorsByInstrument(instrument);
            // Filters out tutors who do not tutor the instrument or are busy with another instrument during that period
            bool inList = false;
            for (int i = 0; i < freeTutors.Count; i++)
            {
                foreach (Tutor t in tutorsForInstrument)
                {
                    if (t.Id == freeTutors[i].Id)
                    {
                        inList = true;
                        break;
                    }
                }
                if (!inList) { freeTutors.RemoveAt(i); i--; }
                inList = false;
            }
            return freeTutors;
        }

        public List<Tutor> GetTutorsByInstrument(Instrument instrument)
        {
            List<Tutor> results = new List<Tutor>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT Tutor.Id, Tutor.Username, Tutor.Password, Tutor.Forename, Tutor.Surname FROM Tutor, TutorInstruments WHERE Tutor.Id = TutorInstruments.Tutor AND TutorInstruments.Instrument = @instrument";
            _db.Cmd.Parameters.AddWithValue("@instrument", instrument.Id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetTutorFromReader(_db.Rdr)); 
            }
            return results;
        }

        public bool IsTutorBusyPeriod(Tutor tutor, Term term, DayOfWeek day, Period period)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Block WHERE Tutor = @tutor AND MasterBlock = @masterblock AND Day = @day AND Term = @term";
            _db.Cmd.Parameters.AddWithValue("@tutor", tutor.Id);
            _db.Cmd.Parameters.AddWithValue("@masterblock", period.Id);
            _db.Cmd.Parameters.AddWithValue("@day", (int)day);
            _db.Cmd.Parameters.AddWithValue("@term", term.Id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                if (_db.Rdr.Read())
                    return true; 
            }
            return false;
        }

        public double CalculateTutorEfficiency(Tutor tutor, Term term)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT COUNT(Block.Tutor) FROM Block WHERE Tutor = @tutor AND Term = @term";
            _db.Cmd.Parameters.AddWithValue("@term", term.Id);
            _db.Cmd.Parameters.AddWithValue("@tutor", tutor.Id);
            // Takes the number of periods the tutor is booked and divides by the total periods in a week
            return Math.Round((Convert.ToInt32(_db.Cmd.ExecuteScalar().ToString()) / 45.00D) * 100D, 1);
        }

        public int CountTutorsForInstrument(Instrument instrument)
        {
            int count = 0;
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT TutorInstruments.Tutor FROM Tutor, TutorInstruments WHERE Tutor.Id = TutorInstruments.Instrument AND TutorInstruments.Instrument = @instrument";
            _db.Cmd.Parameters.AddWithValue("@instrument", instrument.Id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    count++; 
            }
            return count;
        }

        private Tutor GetTutorFromReader(SqlDataReader rdr)
        {
            int id = rdr.GetInt32(0);
            string forename = rdr.GetString(1);
            string surname = rdr.GetString(2);
            string username = rdr.GetString(3);
            string password = rdr.GetString(4);
            return new Tutor(id, username, password, forename, surname);
        }
    }
}
