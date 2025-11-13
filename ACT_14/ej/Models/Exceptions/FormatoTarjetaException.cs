using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models.Exceptions;
public class FormatoTarjetaException : ApplicationException
{
    public FormatoTarjetaException(string message) : base(message) { }
}
