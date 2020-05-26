using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.Entidades
{
    public class Factura
    {
        public string IdCliente { get; set; }
        public string IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public double Cantidad { get; set; }
       
    }
}