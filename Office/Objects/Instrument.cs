using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabling.Objects
{
    public class Instrument
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        string _section;

        public string Section
        {
            get { return _section; }
            set { _section = value; }
        }

        public Instrument(int id, string name, string section)
        {
            _id = id;
            _name = name;
            _section = section;
        }
    }
}
