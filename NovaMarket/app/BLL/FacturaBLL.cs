using NovaMarket.app.DAL;
using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.BLL
{
    public class FacturaBLL
    {
        FacturaDAL oFactutaDAL = new FacturaDAL();

        public int GetConsecutivo()
        {
            return oFactutaDAL.GetNextNumeroFactura();
        }

        public void InsertarEncabezado(EncabezadoFactura enc)
        {
            oFactutaDAL.InsertarEncabezado(enc);
        }
        public void InsertarDetalle(DetalleFactura enc)
        {
            oFactutaDAL.InsertarDetalle(enc);
        }
    }
}