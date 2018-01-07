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
    sealed class LessonAccessLayer
    {
        MDatabase _db;

        public LessonAccessLayer(MDatabase db)
        {
            _db = db;
        }

        // Functionality

        public void CreateLesson(int block, DateTime date)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "INSERT INTO Lesson (Block, Date) VALUES (@block, @date)";
            _db.Cmd.Parameters.AddWithValue("@block", block);
            _db.Cmd.Parameters.AddWithValue("@date", date);
            _db.Cmd.ExecuteNonQuery();
        }

        public bool TutorUpdateLesson(Lesson lesson)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "UPDATE Lesson SET Comments = @comments, Attended = @attended WHERE Id = @id";
            _db.Cmd.Parameters.AddWithValue("@comments", lesson.Comments);
            _db.Cmd.Parameters.AddWithValue("@attended", lesson.Attended);
            _db.Cmd.Parameters.AddWithValue("@id", lesson.Id);
            if (_db.Cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public bool DeleteLesson(Lesson lesson)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "DELETE FROM Lesson WHERE Id = @Id";
            _db.Cmd.Parameters.AddWithValue("@Id", lesson.Id);
            if (_db.Cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public bool DeleteLessonsByBlock(Block block)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "DELETE FROM Lesson WHERE Block = @block";
            _db.Cmd.Parameters.AddWithValue("@block", block.Id);
            if (_db.Cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public List<Lesson> GetAllLessons()
        {
            List<Lesson> results = new List<Lesson>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Lesson";
            _db.Rdr = _db.Cmd.ExecuteReader();
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetLessonFromReader(_db.Rdr)); 
            }
            return results;
        }

        public Lesson GetLessonByID(int id)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Lesson WHERE Id = @id";
            _db.Cmd.Parameters.AddWithValue("@id", id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                if (_db.Rdr.Read())
                    return GetLessonFromReader(_db.Rdr); 
            }
            return null;
        }

        public List<Lesson> GetLessonsByTutor(Tutor tutor)
        {
            List<Lesson> results = new List<Lesson>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Lesson, Block WHERE Block.Id = Lesson.Block AND Block.Tutor = @tId";
            _db.Cmd.Parameters.AddWithValue("@tId", tutor.Id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read()) 
                    results.Add(GetLessonFromReader(_db.Rdr));
            }
            return results;
        }

        public List<Lesson> GetLessonsByTutorToday(Tutor tutor)
        {
            List<Lesson> results = new List<Lesson>();
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Lesson, Block WHERE Block.Id = Lesson.Block AND Block.Tutor = @tId AND Lesson.Date = @date";
            _db.Cmd.Parameters.AddWithValue("@tId", tutor.Id);
            _db.Cmd.Parameters.AddWithValue("@date", DateTime.Today);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read()) 
                    results.Add(GetLessonFromReader(_db.Rdr));
            }
            return results;
        }

        private Lesson GetLessonFromReader(SqlDataReader rdr)
        {
            int id = rdr.GetInt32(0);
            BlockAccessLayer BAL = new BlockAccessLayer(_db);
            Block block = BAL.GetBlockById(rdr.GetInt32(1));
            DateTime date = rdr.GetDateTime(2);
            string comments = "";
            bool attended = false;
            // Stops SQL exception in case of future lessons
            if (!rdr.IsDBNull(3)) comments = rdr.GetString(3);
            if (!rdr.IsDBNull(4)) attended = rdr.GetBoolean(4);
            return new Lesson(id, block, date, comments, attended);
        }
    }
}
