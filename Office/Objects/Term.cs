using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabling.Objects
{
    public class Term
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        DateTime _startDate, _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public Term(int id, DateTime startDate, DateTime endDate)
        {
            _id = id;
            _startDate = startDate;
            _endDate = endDate;
        }

        // Functionality


    }
}
