using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Timetabling.Core
{
    sealed class MDatabase
    {
        // Properties
        private SqlConnection _conn;

        public SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        private SqlCommand _cmd;

        public SqlCommand Cmd
        {
            get { return _cmd; }
            set { _cmd = value; }
        }

        private SqlDataReader _rdr;

        public SqlDataReader Rdr
        {
            get { return _rdr; }
            set { _rdr = value; }
        }

        // Functions
        public bool Connect()
        {
            SqlConnectionStringBuilder connString = new SqlConnectionStringBuilder();
            connString.AttachDBFilename = @"|DataDirectory|\Core\MSMData.mdf";
            connString.DataSource = "(LocalDB)\\v11.0";
            connString.IntegratedSecurity = true;
            _conn = new SqlConnection(connString.ToString());
            try
            {
                _conn.Open();
            }
            catch (SqlException ex)
            {
                return false;
            }
            return true;
        }
    }
}
