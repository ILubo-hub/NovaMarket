using NovaMarket.app.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaMarket.app
{
    public partial class ProductosLlantas : System.Web.UI.Page
    {
        ProductoLogica oProductoLogica = new ProductoLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = oProductoLogica.GetProductoByCategoria("Lla");
            Repeater1.DataBind();

            drop.DataSource = oProductoLogica.GetProductoByCategoria("Lla");
            drop.DataTextField = "Descripcion";
            drop.DataValueField = "ID";
            drop.DataBind();
            drop.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            Label1.Text = Session["NomAdmin"].ToString();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProductos.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarProductos.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Session["Cate"] = "LLa";
            Response.Redirect("AgregarProductos.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = drop.SelectedValue;
            oProductoLogica.EliminarProducto(id);
            Response.Redirect("ProductosLlantas.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            string id = drop.SelectedItem.Value;
            Session["Codigo"] = id;
            Session["Cate"] = "LLa";
            Response.Redirect("EditarProductos.aspx");
        }
    }
}