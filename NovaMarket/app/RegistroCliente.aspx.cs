using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaMarket.app
{
    public partial class RegistroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlProvincias.Items.Insert(0, "Alajuela");
            ddlProvincias.Items.Insert(1, "San José");
            ddlProvincias.Items.Insert(2, "Cartago");
            ddlProvincias.Items.Insert(3, "Heredia");
            ddlProvincias.Items.Insert(4, "Puntarenas");
            ddlProvincias.Items.Insert(5, "Guanacaste");
            ddlProvincias.Items.Insert(6, "Limon");

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioSesion.aspx");
        }
    }
}