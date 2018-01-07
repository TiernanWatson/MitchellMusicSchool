using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timetabling.Core;
using Timetabling.Objects;

namespace Timetabling.DBAccess
{
    sealed class StudentAccessLayer
    {
        MDatabase _db;

        public StudentAccessLayer(MDatabase db)
        {
            _db = db;
        }

        // Functionality

        public int InsertStudent(Student student)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "INSERT INTO Student (Forename, Surname, Address1, Address2, Town, PostCode, Telephone, DOB, InSchool) VALUES (@forename,@surname,@add1,@add2,@town,@postcode,@telephone,@dob,@atschool); SELECT Scope_Identity()";
            _db.Cmd.Parameters.AddWithValue("@forename", student.Forename);
            _db.Cmd.Parameters.AddWithValue("@surname", student.Surname);
            _db.Cmd.Parameters.AddWithValue("@add1", student.Address1);
            _db.Cmd.Parameters.AddWithValue("@add2", student.Address2);
            _db.Cmd.Parameters.AddWithValue("@town", student.Town);
            _db.Cmd.Parameters.AddWithValue("@telephone", student.Telephone);
            _db.Cmd.Parameters.AddWithValue("@postcode", student.PostCode);
            _db.Cmd.Parameters.AddWithValue("@dob", student.Dob);
            _db.Cmd.Parameters.AddWithValue("@atschool", student.InSchool);
            return Convert.ToInt32(_db.Cmd.ExecuteScalar().ToString());
        }

        public bool UpdateStudent(Student student)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "UPDATE Student SET Forename = @forename, Surname = @surname, Address1 = @add1, Address2 = @add2, Town = @town, PostCode = @postcode, Telephone = @telephone, DOB = @dob, InSchool = @atschool WHERE Id = @id";
            _db.Cmd.Parameters.AddWithValue("@forename", student.Forename);
            _db.Cmd.Parameters.AddWithValue("@surname", student.Surname);
            _db.Cmd.Parameters.AddWithValue("@add1", student.Address1);
            _db.Cmd.Parameters.AddWithValue("@add2", student.Address2);
            _db.Cmd.Parameters.AddWithValue("@town", student.Town);
            _db.Cmd.Parameters.AddWithValue("@telephone", student.Telephone);
            _db.Cmd.Parameters.AddWithValue("@postcode", student.PostCode);
            _db.Cmd.Parameters.AddWithValue("@dob", student.Dob);
            _db.Cmd.Parameters.AddWithValue("@atschool", student.InSchool);
            _db.Cmd.Parameters.AddWithValue("@id", student.Id);
            if (_db.Cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public bool DeleteStudent(Student student)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "DELETE FROM Student WHERE Id = @id";
            _db.Cmd.Parameters.AddWithValue("@id", student.Id);
            if (_db.Cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }

        // Selections

        public Student GetStudentById(int id)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Student WHERE Id = @id";
            _db.Cmd.Parameters.AddWithValue("@id", id);
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                if (_db.Rdr.Read())
                    return GetStudentFromReader(_db.Rdr); 
            }
            return null;
        }

        public List<Student> GetStudentByForename(string forename)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Student WHERE Forename = @forename";
            _db.Cmd.Parameters.AddWithValue("@forename", forename);
            List<Student> results = new List<Student>();
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetStudentFromReader(_db.Rdr)); 
            }
            return results;
        }

        public List<Student> GetStudentBySurname(string surname)
        {
            _db.Cmd = _db.Conn.CreateCommand();
            _db.Cmd.CommandText = "SELECT * FROM Student WHERE Surname = @surname";
            _db.Cmd.Parameters.AddWithValue("@surname", surname);
            List<Student> results = new List<Student>();
            using (_db.Rdr = _db.Cmd.ExecuteReader())
            {
                while (_db.Rdr.Read())
                    results.Add(GetStudentFromReader(_db.Rdr)); 
            }
            return results;
        }

        private Student GetStudentFromReader(System.Data.SqlClient.SqlDataReader rdr)
        {
            int id = rdr.GetInt32(0);
            string forename = rdr.GetString(1);
            string surname = rdr.GetString(2);
            string add1 = rdr.GetString(3);
            string add2 = rdr.GetString(4);
            string town = rdr.GetString(5);
            string postCode = rdr.GetString(6);
            string telephone = rdr.GetString(7);
            DateTime dob = rdr.GetDateTime(8);
            bool inSchool = rdr.GetBoolean(9);
            return new Student(id, forename, surname, add1, add2, town, postCode, telephone, dob, inSchool);
        }
    }
}
