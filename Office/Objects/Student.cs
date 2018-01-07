using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Timetabling.Objects
{
    public class Student
    {
        #region Fields/Properties

        int _id;
        string _forename, _surname, _add1, _add2, _town, _postCode, _telephone;
        DateTime _dob;
        bool _inSchool;

        public string Surname
        {
            get { return _surname; }
            set 
            {
                if (!Regex.IsMatch(value, @"^\w{1,32}"))
                    throw new ArgumentException("The surname contains characters other than letters or is greater than 32 characters.");
                _surname = value; 
            }
        }

        public string Forename
        {
            get { return _forename; }
            set 
            {
                if (!Regex.IsMatch(value, @"^\w{1,32}"))
                    throw new ArgumentException("The forename contains characters other than letters.");
                _forename = value; 
            }
        }

        public bool InSchool
        {
            get { return _inSchool; }
            set { _inSchool = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Telephone
        {
            get { return _telephone; }
            set
            {
                if (!Regex.IsMatch(value, @"^\d+$"))
                    throw new ArgumentException("A character in the telephone number was not a digit.");
                _telephone = value;
            }
        }

        public string Town
        {
            get { return _town; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Town is blank");
                _town = value; 
            }
        }

        public string Address2
        {
            get { return _add2; }
            set { _add2 = value; }
        }

        public string Address1
        {
            get { return _add1; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Address line 1 is blank");
                _add1 = value; 
            }
        }

        public string PostCode
        {
            get { return _postCode; }
            set
            {
                if (!Regex.IsMatch(value, @"^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z])))) [0-9][A-Za-z]{2})$"))
                    throw new ArgumentException("PostCode was not in correct format.");
                _postCode = value;
            }
        }

        public DateTime Dob
        {
            get { return _dob; }
            set
            {
                if (value > DateTime.Today)
                    throw new ArgumentException("The date of birth is in the future.");
                _dob = value;
            }
        }

        #endregion

        public Student(int id, string forename, string surname, string add1, string add2, string town, string postCode, string telephone, DateTime dob, bool inSchool)
        {
            Id = id;
            Forename = forename;
            Surname = surname;
            Address1 = add1;
            Address2 = add2;
            Town = town;
            PostCode = postCode;
            Telephone = telephone;
            Dob = dob;
            InSchool = inSchool;
        }

        public Student()
        {
            _id = 0;
            _forename = "";
            _surname = "";
            _add1 = "";
            _add2 = "";
            _town = "";
            _postCode = "";
            _telephone = "";
            _dob = new DateTime();
            _inSchool = true;
        }
    }
}
