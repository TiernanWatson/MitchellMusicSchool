using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timetabling.Objects;

namespace Timetabling.Core
{
    static class Session
    {
        static Tutor _curUser;
        static MDatabase _database;

        internal static MDatabase Database
        {
            get { return _database; }
            set { _database = value; }
        }

        public static Tutor CurUser
        {
            get { return _curUser; }
            set { _curUser = value; }
        }

        // Functionality

        public static void StartSession()
        {
            _database = new MDatabase();
            _database.Connect();
        }
    }
}
