using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabling.Objects
{
    public class Block
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        Student _student;

        public Student Student
        {
            get { return _student; }
            set { _student = value; }
        }

        Tutor _tutor;

        public Tutor Tutor
        {
            get { return _tutor; }
            set { _tutor = value; }
        }

        Instrument _instrument;

        public Instrument Instrument
        {
            get { return _instrument; }
            set { _instrument = value; }
        }

        Room _room;

        public Room Room
        {
            get { return _room; }
            set { _room = value; }
        }

        Period _period;

        public Period Period
        {
            get { return _period; }
            set { _period = value; }
        }

        Term _term;

        public Term Term
        {
            get { return _term; }
            set { _term = value; }
        }

        DayOfWeek _day;

        public DayOfWeek Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public Block(int id, Student student, Tutor tutor, Instrument instrument, Room room, Period period, Term term, DayOfWeek day)
        {
            _id = id;
            _student = student;
            _tutor = tutor;
            _instrument = instrument;
            _room = room;
            _period = period;
            _day = day;
        }
    }
}
