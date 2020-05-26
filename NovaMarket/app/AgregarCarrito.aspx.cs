using NovaMarket.app.BLL;
using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaMarket.app
{
    public partial class AgregarCarrito : System.Web.UI.Page
    {
        CarritoBLL oCarritoBll = new CarritoBLL();
        ProductoLogica oProducto = new ProductoLogica();
        Producto oPro = new Producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                string id = Session["IdProducto"].ToString();
                
                oPro = oProducto.GetProductoByID(id);

                txtDescripcion.Text = oPro.Descripcion;
                txtTipo.Text = oPro.Categoria;
                txtPrecio.Text = oPro.Precio.ToString();
                Image1.ImageUrl = @"images/Imagenes Proyecto/" + oPro.Imagen;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Carrito oCarrito = new Carrito();
            oCarrito.IdCliente = Session["id"].ToString();
            oCarrito.IDProducto = Session["IdProducto"].ToString();
            oCarrito.Cantidad = Convert.ToInt32( txtCantidad.Text);

            oCarritoBll.InsertarCarrito(oCarrito);
            Response.Redirect("VentaProductos.aspx");
        }
    }
}