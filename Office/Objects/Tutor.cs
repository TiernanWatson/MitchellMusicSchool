using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabling.Objects
{
    public class Tutor 
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _forename, _surname, _username, _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c))
                        throw new ValidationException("The surname contains characters other than letters.");
                }
                _surname = value; 
            }
        }

        public string Forename
        {
            get { return _forename; }
            set
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c))
                        throw new ValidationException("The forename contains characters other than letters.");
                }
                _forename = value;
            }
        }

        List<Instrument> _instruments;

        public List<Instrument> Instruments
        {
            get { return _instruments; }
            set { _instruments = value; }
        }

        // Functionality

        public Tutor(int id, string username, string password, string forename, string surname)
        {
            _id = id;
            _username = username;
            _password = password;
            _forename = forename;
            _surname = surname;
        }
    }
}
