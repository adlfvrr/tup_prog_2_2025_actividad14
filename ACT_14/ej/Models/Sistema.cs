using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej.Models;
public class Sistema
{
    List<Tickets> tickets = new List<Tickets>();
    List<Transporte> transportes = new List<Transporte>();
    public void AgregarTransporte(Transporte transporte)
    {
        transportes.Add(transporte);
    }
    public void CrearTicket(string cuit, string nombre, string telefono, string tarjeta)
    {
        Tickets t = new Tickets(cuit, nombre, telefono, tarjeta);
        tickets.Add(t);
    }
    public string[] Imprimir()
    {
        string[] lista = new string[tickets.Count];
        tickets.Sort();
        int n = 0;
        foreach(Tickets t in tickets)
        {
            lista[n++] = t.ToString();
        }
        return lista;
    }

}
