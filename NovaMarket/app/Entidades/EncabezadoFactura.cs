using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.Entidades
{
    public class EncabezadoFactura
    {
        public int Consecutivo { get; set; }
        public string NumFactura { get; set; }
        public string IdCliente { get; set; }
        public string NumTarjeta { get; set; }
    }
}