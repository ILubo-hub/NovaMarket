using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.Entidades
{
    public class Producto
    {
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public string Tamano { get; set; }
        public string Categoria { get; set; }
        public int NumVentas { get; set; }
        public double Precio { get; set; }
        public string Imagen { get; set; }

    }
}