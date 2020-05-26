using NovaMarket.app.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace NovaMarket.app
{
    public partial class VentaProductos : System.Web.UI.Page
    {
        ProductoLogica oProductoBLL = new ProductoLogica();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                rptEvento.DataSource = oProductoBLL.GetaAllProducto();
                rptEvento.DataBind();

                cargarDDLCategoria();

            }
        }

        protected void rptEvento_ItemComand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "controlBtn")
            {
                string IdProducto = ((LinkButton)e.CommandSource).CommandArgument;
                Session["IdProducto"] = IdProducto;
                Response.Redirect("AgregarCarrito.aspx");
            }

        }
        protected void btnComprar_Click(object sender, EventArgs e)
        {
            

        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void cargarDDLCategoria()
        {
            this.ddlCategoria.Items.Insert(0, "Tecnología");
            this.ddlCategoria.Items.Insert(1, "Comida");
            this.ddlCategoria.Items.Insert(2, "Restaurante");
            this.ddlCategoria.Items.Insert(3, "Ropa");
            this.ddlCategoria.Items.Insert(4, "Llantas");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ddlCategoria.SelectedItem.Text == "Tecnología")
            {
                rptEvento.DataSource= oProductoBLL.GetProductoByCategoria("Tec");
                rptEvento.DataBind();
            }
            if (ddlCategoria.SelectedItem.Text == "Comida")
            {
                rptEvento.DataSource = oProductoBLL.GetProductoByCategoria("Com");
                rptEvento.DataBind();
            }
            if (ddlCategoria.SelectedItem.Text == "Restaurante")
            {
                rptEvento.DataSource = oProductoBLL.GetProductoByCategoria("Res");
                rptEvento.DataBind();
            }
            if (ddlCategoria.SelectedItem.Text == "Ropa")
            {
                rptEvento.DataSource = oProductoBLL.GetProductoByCategoria("Rop");
                rptEvento.DataBind();
            }
            if (ddlCategoria.SelectedItem.Text == "Llantas")
            {
                rptEvento.DataSource = oProductoBLL.GetProductoByCategoria("Lla");
                rptEvento.DataBind();
            }
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            Response.Redirect("VistaCarrito.aspx");
        }
    }
}