using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabling.Objects
{
    public class Period
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        TimeSpan _startTime, _endTime;

        public TimeSpan EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public TimeSpan StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public Period(int id, TimeSpan startTime, TimeSpan endTime)
        {
            _id = id;
            _startTime = startTime;
            _endTime = endTime;
        }
    }
}
