using NovaMarket.app.BLL;
using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaMarket
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        CienteLogica oClienteLogica = new CienteLogica();
        Cliente oCliente = new Cliente();
        Administrador oAdmin = new Administrador();
        AdminLogica oAdminLogica = new AdminLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            StringBuilder Mensaje = new StringBuilder();
            try
            {
                oCliente = oClienteLogica.InicioDeSesion(txtUsuario.Text, txtContrasena.Text);
                if (oCliente.Nombre == null)
                {
                    oAdmin = oAdminLogica.GetAdminByID(txtUsuario.Text);

                    if (oAdmin.Contrasena==txtContrasena.Text)
                    {
                        Session["IDadmin"] = oAdmin.ID;
                        Session["NomAdmin"] = oAdmin.Nombre;
                        
                        Response.Write(Mensaje);
                        Response.Redirect("MenuAdmin.aspx");
                    }
                }
                else
                {
                    if (oCliente.Contrasena == txtContrasena.Text)
                    {
                        Session["id"] = oCliente.Cedula;
                        Session["nombre"] = oCliente.Nombre;

                        Response.Redirect("index.aspx");

                    }
                    else
                    {
                        Mensaje.Append("<script>");
                        Mensaje.Append("r=confirm('Usuario o Contraseña Incorrectos')");
                        Mensaje.Append("</script>");
                        Response.Write(Mensaje);
                    }
                }
            }
            catch (Exception er)
            {

            }

        }
    }
}