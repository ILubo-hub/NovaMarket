using NovaMarket.app.BLL;
using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaMarket.app
{
    public partial class VistaCarrito : System.Web.UI.Page
    {
        CarritoBLL oCarrito = new CarritoBLL();
        ProductoLogica oProducto = new ProductoLogica();
        List<Carrito> carrito = new List<Carrito>();
        List<Producto> listaPro = new List<Producto>();
        FacturaBLL oFactura = new FacturaBLL();
        CienteLogica co = new CienteLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            string clien = Session["id"].ToString();
            carrito = oCarrito.GetAllCarritoByID(clien);
            cargar(carrito);
            Totalizar(carrito);
        }
        public void cargar(List<Carrito> lista)
        {
            listaPro.Clear();
            foreach (var item in lista)
            {
                listaPro.Add(oProducto.GetProductoByID(item.IDProducto));
            }
            
            rptEvento.DataSource = listaPro;
            rptEvento.DataBind(); 
        }

        protected void rptEvento_ItemComand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "controlBtn")
            {
                string IdProducto = ((LinkButton)e.CommandSource).CommandArgument;
                oCarrito.EliminarCarrito(IdProducto, Session["id"].ToString());



                string clien = Session["id"].ToString();
                carrito = oCarrito.GetAllCarritoByID(clien);
                cargar(carrito);
                Totalizar(carrito);
            }
        }

        public void Totalizar(List<Carrito> lista)
        {
            double total = 0.0;
            foreach (var item in lista)
            {
                foreach (var item2 in listaPro)
                {
                    if (item.IDProducto == item2.ID)
                    {
                        total += item.Cantidad * item2.Precio;
                    }
                }
            }
            txtTotal.Text = total.ToString();
        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            //Encabezado de la factura
            string idcliente = Session["id"].ToString();
            int conse = oFactura.GetConsecutivo();
            string idfac = "100" + conse;
            string tar = txtTarjeta.Text;

            EncabezadoFactura enc = new EncabezadoFactura();
            enc.Consecutivo = conse;
            enc.IdCliente = idcliente;
            enc.NumFactura = idfac;
            enc.NumTarjeta = tar;

            oFactura.InsertarEncabezado(enc);

            //Detalle Factura
            foreach (var item in listaPro)
            {
                DetalleFactura oDet = new DetalleFactura();
                oDet.IdEncabezado = idfac;
                oDet.NumLinea++;
                oDet.producto = item.ID;

                oFactura.InsertarDetalle(oDet); 
            }
            string tes = "";
            foreach (var item in carrito)
            {
                
                oCarrito.EliminarCarrito(item.IDProducto,item.IdCliente);

            }
            foreach (var item in listaPro)
            {
                tes += "\n " + item.Descripcion;
            }
            Cliente oCliente = new Cliente();

            oCliente = co.GetCliente(Session["id"].ToString());
            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = "Hola ! ";
            mensaje.Body = "Gracias por usar nuestros servicios, adjuntamos la factura por el monto de "+txtTotal.Text +"Adjuntamos los productos\n"+tes;
            mensaje.From = new MailAddress("novamarket506@gmail.com");
            mensaje.To.Add(oCliente.Correo);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("novamarket506@gmail.com", "Maverick28");
            smtp.EnableSsl = true;

            smtp.Send(mensaje);

            Response.Redirect("index.aspx");

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (var item in carrito)
            {
                oCarrito.EliminarCarrito(item.IDProducto, item.IdCliente);
            }
            Response.Redirect("VentaProductos.aspx");
        }
    }
}