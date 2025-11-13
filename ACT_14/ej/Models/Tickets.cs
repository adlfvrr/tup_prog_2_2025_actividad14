using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ej.Models.Exceptions;

namespace ej.Models;
public class Tickets : IComparable
{
    public DateTime Fecha {  get; set; }
    public double PrecioFinal {  get; set; }
    public string Destino {  get; set; }
    public string Transporte { get; set; }

    string cuit;
    string nombre;
    string telefono;
    string tarjeta;
    public Tickets(string cuit, string nombre, string telefono, string tarjeta)
    {
        if (!ValidarCUIT(cuit)) { throw new FormatoCUITException("Formato de CUIT no válido"); }
        if (!ValidarTarjeta(tarjeta)) { throw new FormatoTarjetaException("N° de tarjeta no válido"); }
        this.cuit = cuit;
        this.nombre = nombre;
        this.telefono = telefono;
        this.tarjeta = tarjeta;
    }
    protected bool ValidarCUIT(string cuit)
    {
        return cuit.Length == 11;
    }
    protected bool ValidarTarjeta(string tarjeta)
    {
        return tarjeta.Length == 16;

    }
    public override string ToString()
    {
        return $"{this.nombre} - {this.cuit} - {this.Destino} | Precio: ${this.PrecioFinal:f2}";
    }
    public int CompareTo(object obj)
    {
        Tickets other = obj as Tickets;
        if (other != null)
        {
            return this.Destino.CompareTo(other.Destino);
        }
        return -1;
    }
}
