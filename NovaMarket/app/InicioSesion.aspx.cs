using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaMarket
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if(this.txtUsuario.Text.Equals("1") && this.txtContrasena.Text.Equals("2"))
            {
                Response.Redirect("indexAdmin.aspx");
            }else
            {
                Response.Redirect("index.aspx");
            }
            
        }
    }
}