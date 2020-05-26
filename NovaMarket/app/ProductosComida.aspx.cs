using NovaMarket.app.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaMarket.app
{
    public partial class ProductosComida : System.Web.UI.Page
    {
        ProductoLogica oProductoLogica = new ProductoLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = oProductoLogica.GetProductoByCategoria("Com");
            Repeater1.DataBind();
            
            drop.DataSource = oProductoLogica.GetProductoByCategoria("Com");
            drop.DataTextField = "Descripcion";
            drop.DataValueField = "ID";
            drop.DataBind();
            drop.Items.Insert(0, new ListItem("[Seleccionar]", "0"));


            Label1.Text = Session["NomAdmin"].ToString();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)   
        {
            Session["Cate"] = "Food";
            Response.Redirect("AgregarProductos.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = drop.SelectedValue;
            oProductoLogica.EliminarProducto(id);
            Response.Redirect("ProductosComida.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string id = drop.SelectedItem.Value;
            Session["Codigo"] = id;
            Session["Cate"] = "Food";
            Response.Redirect("EditarProductos.aspx");
        }
    }
}