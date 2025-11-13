using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models.Exceptions
{
    public class FormatoCUITException : ApplicationException
    {
        public FormatoCUITException(string msg) : base(msg) { }
    }
}
