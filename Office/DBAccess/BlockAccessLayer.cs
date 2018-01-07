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
    sealed class BlockAccessLayer
    {
        MDatabase _db;

        public BlockAccessLayer(MDatabase db)
        {
            _db = db;
        }

        // Functionality

        public void CreateBlock(int studentId, Instrument instrument, Term term, Room room, Period masterBlock, Tutor tutor, DayOfWeek day)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "INSERT INTO Block (Student, Instrument, Room, Tutor, MasterBlock, Term, Day) VALUES (@student, @instrument, @room, @tutor, @masterBlock, @term, @day); SELECT Scope_Identity()";
            _db.Cmd.Parameters.AddWithValue("@student", studentId);
            _db.Cmd.Parameters.AddWithValue("@instrument", instrument.Id);
            _db.Cmd.Parameters.AddWithValue("@room", room.Id);
            _db.Cmd.Parameters.AddWithValue("@tutor", tutor.Id);
            _db.Cmd.Parameters.AddWithValue("@masterBlock", masterBlock.Id);
            _db.Cmd.Parameters.AddWithValue("@term", term.Id);
            _db.Cmd.Parameters.AddWithValue("@day", (int)day);
            // Scope_Idenity in SQL cmd allows retrieval of the block ID
            int blockId = Convert.ToInt32(_db.Cmd.ExecuteScalar().ToString());
            LessonAccessLayer LAL = new LessonAccessLayer(_db);
            DateTime startDate = term.StartDate.AddDays((int)day - 1);
            // Creates lessons until the term is finished
            while (startDate.CompareTo(term.EndDate) < 0)
            {
                LAL.CreateLesson(blockId, startDate);
                startDate = startDate.AddDays(7);
            }
        }

        public void CreateBlock(int studentId, Instrument instrument, Term term, Room room, Period masterBlock, Tutor tutor, DayOfWeek day, DateTime customDate)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "INSERT INTO Block (Student, Instrument, Room, Tutor, MasterBlock, Term, Day) VALUES (@student, @instrument, @room, @tutor, @masterBlock, @term, @day); SELECT Scope_Identity()";
            _db.Cmd.Parameters.AddWithValue("@student", studentId);
            _db.Cmd.Parameters.AddWithValue("@instrument", instrument.Id);
            _db.Cmd.Parameters.AddWithValue("@room", room.Id);
            _db.Cmd.Parameters.AddWithValue("@tutor", tutor.Id);
            _db.Cmd.Parameters.AddWithValue("@masterBlock", masterBlock.Id);
            _db.Cmd.Parameters.AddWithValue("@term", term.Id);
            _db.Cmd.Parameters.AddWithValue("@day", (int)day);
            // Scope_Idenity in SQL cmd allows retrieval of the block ID
            int blockId = Convert.ToInt32(_db.Cmd.ExecuteScalar().ToString());
            LessonAccessLayer LAL = new LessonAccessLayer(_db);
            // Creates lessons until the term is finished
            while (customDate.CompareTo(term.EndDate) < 0)
            {
                LAL.CreateLesson(blockId, customDate);
                customDate = customDate.AddDays(7);
            }
        }

        public bool DeleteBlock(Block block)
        {
            LessonAccessLayer LAL = new LessonAccessLayer(_db);
            LAL.DeleteLessonsByBlock(block);
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "DELETE FROM Block WHERE Id = @Id";
            _db.Cmd.Parameters.AddWithValue("@Id", block.Id);
            if (_db.Cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public List<Block> GetAllBlocks()
        {
            List<Block> results = new List<Block>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Block";
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetBlockFromReader(_db.Rdr)); 
            }
            return results;
        }

        public Block GetBlockById(int id)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Block WHERE id = @bId";
            _db.Cmd.Parameters.AddWithValue("@bId", id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                if (_db.Rdr.Read()) 
                    return GetBlockFromReader(_db.Rdr); 
            }
            return null;
        }

        private Block GetBlockFromReader(SqlDataReader rdr)
        {
            int id = rdr.GetInt32(0);
            StudentAccessLayer SAL = new StudentAccessLayer(_db);
            Student student = SAL.GetStudentById(rdr.GetInt32(1));
            InstrumentAccessLayer IAL = new InstrumentAccessLayer(_db);
            Instrument instrument = IAL.GetInstrumentById(rdr.GetInt32(2));
            TutorAccessLayer TAL = new TutorAccessLayer(_db);
            Tutor tutor = TAL.GetTutorByID(rdr.GetInt32(3));
            RoomAccessLayer RAL = new RoomAccessLayer(_db);
            Room room = RAL.GetRoomByID(rdr.GetInt32(4));
            PeriodAccessLayer PAL = new PeriodAccessLayer(_db);
            Period period = PAL.GetPeriodById(rdr.GetInt32(5));
            TermAccessLayer TeAL = new TermAccessLayer(_db);
            Term term = TeAL.GetTermById(rdr.GetInt32(6));
            DayOfWeek day = (DayOfWeek)rdr.GetInt32(7);
            return new Block(id, student, tutor, instrument, room, period, term, day);
        }
    }
}
