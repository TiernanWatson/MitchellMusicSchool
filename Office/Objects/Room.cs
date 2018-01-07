using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabling.Objects
{
    public class Room
    {
        int _id, _floor;

        public int Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Room(int id, int floor)
        {
            _id = id;
            _floor = floor;
        }
    }
}
