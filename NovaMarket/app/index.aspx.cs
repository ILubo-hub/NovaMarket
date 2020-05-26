using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaMarket
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"]!= null)
            {
                lblNombreUsuario.Text = Session["nombre"].ToString();
            }
            else
            {
                lblNombreUsuario.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarUsuario.aspx");
        }
    }
}