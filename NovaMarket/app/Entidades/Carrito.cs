using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.Entidades
{
    public class Carrito
    {
        public string IdCliente { get; set; }
        public string IDProducto { get; set; }
        public int Cantidad { get; set; }
    }
}