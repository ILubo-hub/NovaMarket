using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.Entidades
{
    public class DetalleFactura
    {
        public string IdEncabezado { get; set; }
        public string producto { get; set; }
        public int NumLinea { get; set; }
    }
}