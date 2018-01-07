using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timetabling.Core;
using Timetabling.Objects;

namespace Timetabling.DBAccess
{
    sealed class InstrumentAccessLayer
    {
        MDatabase _db;

        public InstrumentAccessLayer(MDatabase db)
        {
            _db = db;
        }

        // Functionality

        public List<Instrument> GetAllInstruments()
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Instrument";
            List<Instrument> result = new List<Instrument>();
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    result.Add(GetInstrumentFromRdr(_db.Rdr)); 
            }
            return result;
        }

        public Instrument GetInstrumentById(int id)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Instrument WHERE Id = @id";
            _db.Cmd.Parameters.AddWithValue("@id", id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                if (_db.Rdr.Read())
                    return GetInstrumentFromRdr(_db.Rdr); 
            }
            return null;
        }

        private Instrument GetInstrumentFromRdr(System.Data.SqlClient.SqlDataReader rdr)
        {
            int id = rdr.GetInt32(0);
            string name = rdr.GetString(1);
            string section = rdr.GetString(2);
            return new Instrument(id, name, section);
        }
    }
}
