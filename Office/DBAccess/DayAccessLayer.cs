using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Timetabling.Objects;
using Timetabling.Core;

namespace Timetabling.DBAccess
{
    class DayAccessLayer
    {
        MDatabase _db;

        public DayAccessLayer(MDatabase db)
        {
            _db = db;
        }

        // Functionality

        public List<DayOfWeek> GetAllDays()
        {
            List<DayOfWeek> results = new List<DayOfWeek>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Days";
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetDayFromReader(_db.Rdr)); 
            }
            return results;
        }

        public List<DayOfWeek> GetAvailableDays(Instrument instrument, Term term)
        {
            List<DayOfWeek> results = GetAllDays();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT COUNT(Block.Id), Block.Day FROM Block, Days WHERE Block.Day = Days.Id AND Block.Instrument = @instrument AND Term = @term GROUP BY Block.Day ORDER BY Block.Day ASC";
            _db.Cmd.Parameters.AddWithValue("@term", term.Id);
            _db.Cmd.Parameters.AddWithValue("@instrument", instrument.Id);
            DataTable dt = new DataTable();  // DataTable used so days can be easily sorted
            using (_db.Rdr = _db.Cmd.ExecuteReader()) { dt.Load(_db.Rdr); }
            foreach (DataRow dr in dt.Rows)  // Loops checks for any days with all periods
                if (Convert.ToInt32(dr[0].ToString()) >= 9) { results.Remove((DayOfWeek)Convert.ToInt32(dr[1].ToString())); }
            return results;
        }

        private DayOfWeek GetDayFromReader(SqlDataReader rdr)
        {
            return (DayOfWeek)rdr.GetInt32(0);
        }
    }
}