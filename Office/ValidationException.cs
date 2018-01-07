using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetabling
{
    class ValidationException : Exception
    {
        public ValidationException()
            : base("There was an error performing validation.", null)
        {

        }

        public ValidationException(string message)
            : base(message, null)
        {

        }
    }
}
