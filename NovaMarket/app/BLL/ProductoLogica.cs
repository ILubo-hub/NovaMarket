using NovaMarket.app.DAL;
using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.BLL
{
    public class ProductoLogica
    {
        ProductoDatos oProductoDatos = new ProductoDatos();
        public List<Producto> GetaAllProducto()
        {
            return oProductoDatos.GetAllProducto();
        }
        public Producto GetProductoByID(string ID)
        {
            return oProductoDatos.GetProductoByID(ID);
        }

        public string InsertarProducto(Producto pProducto)
        {
            return oProductoDatos.InsertarProducto(pProducto);
        }
        public void EliminarProducto(string id)
        {
            oProductoDatos.EliminarProducto(id);
        }

        public List<Producto> GetProductoByCategoria(string cat)
        {
            return oProductoDatos.GetProductoByCategoria(cat);
        }
        public string UpdateProducto(Producto pProducto)
        {
            return oProductoDatos.UpdateProducto(pProducto);
        }
        public string UpdateProductoSinImagen(Producto pProducto)
        {
            return oProductoDatos.UpdateProductoSinImagen(pProducto);
        }
    }
}