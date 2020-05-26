using NovaMarket.app.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaMarket.app
{
    public partial class ProductosRopa : System.Web.UI.Page
    {
        ProductoLogica oProductoLogica = new ProductoLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = oProductoLogica.GetProductoByCategoria("Rop");
            Repeater1.DataBind();
            
            drop.DataSource = oProductoLogica.GetProductoByCategoria("Rop");
            drop.DataTextField = "Descripcion";
            drop.DataValueField = "ID";
            drop.DataBind();
            drop.Items.Insert(0, new ListItem("[Seleccionar]", "0"));


            Label1.Text = Session["NomAdmin"].ToString();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Session["Cate"] = "Ropa";
            Response.Redirect("AgregarProductos.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProductos.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string id = drop.SelectedItem.Value;
            Session["Codigo"] = id;
            Session["Cate"] = "Ropa";
            Response.Redirect("EditarProductos.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = drop.SelectedValue;
            oProductoLogica.EliminarProducto(id);
            Response.Redirect("ProductosRopa.aspx");
        }
    }
}