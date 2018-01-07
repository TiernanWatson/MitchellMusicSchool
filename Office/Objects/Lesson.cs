using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabling.Objects
{
    public class Lesson
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        Block _block;

        public Block Block
        {
            get { return _block; }
            set { _block = value; }
        }

        DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        string _comments;

        public string Comments
        {
            get { return _comments; }
            set 
            {
                if (value.Count<char>() <= 255)
                    _comments = value;
                else
                    throw new ValidationException("The number of characters in the comments is above 255");
            }
        }

        bool _attended;

        public bool Attended
        {
            get { return _attended; }
            set { _attended = value; }
        }

        public Lesson(int id, Block block, DateTime date, string comments = null, bool attended = false)
        {
            _id = id;
            _block = block;
            _date = date;
            _comments = comments;
            _attended = attended;
        }

        public Lesson(int id, int block, DateTime date, string comments = null, bool attended = false)
        {
            _id = id;
            Timetabling.DBAccess.BlockAccessLayer BAL = new Timetabling.DBAccess.BlockAccessLayer(Timetabling.Core.Session.Database);
            _block = BAL.GetBlockById(block);
            _date = date;
            _comments = comments;
            _attended = attended;
        }

        // Functionality
    }
}
