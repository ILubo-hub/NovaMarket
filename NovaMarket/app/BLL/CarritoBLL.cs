using NovaMarket.app.DAL;
using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.BLL
{
    public class CarritoBLL
    {
        CarritoDAL oCarritoDAL = new CarritoDAL();
        public string InsertarCarrito(Carrito pCarrito)
        {
            return oCarritoDAL.InsertarCarrito(pCarrito);
        }
        public List<Carrito> GetAllCarritoByID(string ID)
        {
            return oCarritoDAL.GetAllCarritoByID(ID);
        }
        public void EliminarCarrito(string id, string clien)
        {
            oCarritoDAL.DeletedCarrito(id, clien);
        }
    }
}