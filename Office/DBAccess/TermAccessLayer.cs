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
    sealed class TermAccessLayer
    {
        MDatabase _db;

        public TermAccessLayer(MDatabase db)
        {
            _db = db;
        }

        // Functionality

        public List<Term> GetAllTerms()
        {
            List<Term> results = new List<Term>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Terms";
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetTermFromReader(_db.Rdr)); 
            }
            return results;
        }

        public Term GetTermById(int id)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Terms WHERE Id = @tId";
            _db.Cmd.Parameters.AddWithValue("@tId", id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                if (_db.Rdr.Read())
                    return GetTermFromReader(_db.Rdr); 
            }
            return null;
        }

        private Term GetTermFromReader(SqlDataReader rdr)
        {
            int id = rdr.GetInt32(0);
            DateTime startDate = rdr.GetDateTime(1);
            DateTime endDate = rdr.GetDateTime(2);
            return new Term(id, startDate, endDate);
        }
    }
}
