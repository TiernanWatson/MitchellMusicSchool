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
    sealed class RoomAccessLayer
    {
        MDatabase _db;

        public RoomAccessLayer(MDatabase db)
        {
            _db = db;
        }

        // Functionality

        public List<Room> GetAllRooms()
        {
            List<Room> results = new List<Room>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Room";
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetRoomFromReader(_db.Rdr));
            }
            return results;
        }

        public Room GetRoomByID(int id)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Room WHERE Id = @rId";
            _db.Cmd.Parameters.AddWithValue("@rId", id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                if (_db.Rdr.Read())
                    return GetRoomFromReader(_db.Rdr); 
            }
            return null;
        }

        public List<Room> GetAvailableRooms(Term term, DayOfWeek day, Period period)
        {
            List<Room> results = new List<Room>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Room WHERE NOT EXISTS (SELECT * FROM Block WHERE Block.Room = Room.Id AND Block.MasterBlock = @period AND Block.Day = @day AND Block.Term = @term)";
            _db.Cmd.Parameters.AddWithValue("@period", period.Id);
            _db.Cmd.Parameters.AddWithValue("@day", (int)day);
            _db.Cmd.Parameters.AddWithValue("@term", term.Id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetRoomFromReader(_db.Rdr)); 
            }
            return results;
        }

        private Room GetRoomFromReader(SqlDataReader rdr)
        {
            int id = rdr.GetInt32(0);
            int floor = rdr.GetInt32(1);
            return new Room(id, floor);
        }
    }
}
