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
    public partial class RegistroCliente : System.Web.UI.Page
    {
        CienteLogica oClienteLogica = new CienteLogica();
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
            Cliente oCliente = new Cliente();
            try
            {
                oCliente.Cedula = txtUNumeroCedula.Text;
                oCliente.Nombre = txtNombre.Text;
                oCliente.Apellidos = txtApellidos.Text;
                oCliente.Correo = txtCorreo.Text;
                oCliente.oProvincia = new Provincia();
                if (ddlProvincias.SelectedItem.Text == "San jose")
                {
                    oCliente.oProvincia.Codigo = 1;
                }
                if (ddlProvincias.SelectedItem.Text == "Alajuela")
                {
                    oCliente.oProvincia.Codigo = 2;
                }
                if (ddlProvincias.SelectedItem.Text == "Cartago")
                {
                    oCliente.oProvincia.Codigo = 3;
                }
                if (ddlProvincias.SelectedItem.Text == "Heredia")
                {
                    oCliente.oProvincia.Codigo = 4;
                }
                if (ddlProvincias.SelectedItem.Text == "Guanacaste")
                {
                    oCliente.oProvincia.Codigo = 5;
                }
                if (ddlProvincias.SelectedItem.Text == "Puntarenas")
                {
                    oCliente.oProvincia.Codigo = 6;
                }
                if (ddlProvincias.SelectedItem.Text == "Limon")
                {
                    oCliente.oProvincia.Codigo = 7;
                }
                oCliente.Telefono = txtNumeroTelefono.Text;
                oCliente.Contrasena = txtContrasena.Text;

                string resultado = oClienteLogica.InsertarCliente(oCliente);

            }
            catch (Exception er)
            {

            }

            Response.Redirect("InicioSesion.aspx");
        }
    }
}