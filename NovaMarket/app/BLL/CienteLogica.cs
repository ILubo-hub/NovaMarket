using NovaMarket.app.DAL;
using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.BLL
{
    public class CienteLogica
    {
        ClienteDatos oClienteDatos = new ClienteDatos();
        public string InsertarCliente(Cliente pCliente)
        {
            string estado = oClienteDatos.InsertarCliente(pCliente);
            return estado;
        }
        public Cliente InicioDeSesion(string id, string contra)
        {
            Cliente oCliente = new Cliente();
            oCliente = oClienteDatos.GetClienteByID(id);
            return oCliente;
        }
        public Cliente GetCliente(string id)
        {
            Cliente oCliente = new Cliente();
            oCliente = oClienteDatos.GetClienteByID(id);
            return oCliente;
        }
    }
}