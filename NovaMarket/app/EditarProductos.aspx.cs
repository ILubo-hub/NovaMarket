using NovaMarket.app.BLL;
using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaMarket.app
{
    public partial class EditarProductos : System.Web.UI.Page
    {
        Producto oProducto = new Producto();
        ProductoLogica oProductoLogica = new ProductoLogica();
        /// <summary>
        /// Carga la pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                CargarDDlCategoria();
                CargarDDlTamano();
                oProducto = oProductoLogica.GetProductoByID(Session["Codigo"].ToString());
                CargarCategorias(Session["Cate"].ToString());
                txtID.Text = oProducto.ID;
                txtDescripcion.Text = oProducto.Descripcion;
                txtPrecio.Text = "" + oProducto.Precio;
                ddlTipo.Text = oProducto.Categoria;
            }
        }
        /// <summary>
        /// Carga el combo Tamaño
        /// </summary>
        private void CargarDDlTamano()
        {
            
            dropTamano.Items.Insert(0, "Mini");
            dropTamano.Items.Insert(1, "Pequeño");
            dropTamano.Items.Insert(2, "Mediano");
            dropTamano.Items.Insert(3, "Grande");
        }
        /// <summary>
        /// Carga el combo Categoria
        /// </summary>
        private void CargarDDlCategoria()
        {
            this.ddlCategoria.Items.Insert(0, "Tecnología");
            this.ddlCategoria.Items.Insert(1, "Comida");
            this.ddlCategoria.Items.Insert(2, "Restaurante");
            this.ddlCategoria.Items.Insert(3, "Ropa");
            this.ddlCategoria.Items.Insert(4, "Llantas");
        }
        /// <summary>
        /// Carga el combo de Tipo
        /// </summary>
        /// <param name="cat"></param>
        private void CargarCategorias(string cat)
        {
            if (Session["Cate"].ToString() == "Tec")
            {
                ddlCategoria.SelectedIndex = 0;
                ddlTipo.Items.Insert(0, "Celular");
                ddlTipo.Items.Insert(0, "Laptop");
                ddlTipo.Items.Insert(0, "TV");
                ddlTipo.Items.Insert(0, "Impresora");
                ddlTipo.Items.Insert(0, "Parlante");

            }
            if (Session["Cate"].ToString() == "Food")
            {
                ddlCategoria.SelectedIndex = 1;
                ddlTipo.Items.Insert(0, "Granos Basicos");
                ddlTipo.Items.Insert(0, "Salsa");
                ddlTipo.Items.Insert(0, "Condimento");
                ddlTipo.Items.Insert(0, "Lacteo");
                ddlTipo.Items.Insert(0, "Carne");

            }
            if (Session["Cate"].ToString() == "Ropa")
            {
                ddlCategoria.SelectedIndex = 3;
                ddlTipo.Items.Insert(0, "Camiseta");
                ddlTipo.Items.Insert(0, "Pantalon");
                ddlTipo.Items.Insert(0, "Blusa");
                ddlTipo.Items.Insert(0, "Pantaloneta");
                ddlTipo.Items.Insert(0, "Sandalia");
            }
            if (Session["Cate"].ToString() == "LLa")
            {
                ddlCategoria.SelectedIndex = 4;
                ddlTipo.Items.Insert(0, "Todo Terreno");
                ddlTipo.Items.Insert(0, "Normal");
                
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string condicion = "";
            Producto nuevo = new Producto();
            ProductoLogica _Logica = new ProductoLogica();
            nuevo.ID = txtID.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Precio = Convert.ToDouble(txtPrecio.Text);
            nuevo.Tamano = dropTamano.SelectedItem.Text;
            nuevo.Categoria = ddlTipo.SelectedItem.Text;
            nuevo.NumVentas = 0;
            if (fuploadImagen.HasFile)
            {
                _Logica.UpdateProducto(nuevo);

            }
            else
            {
                _Logica.UpdateProductoSinImagen(nuevo);
            }


            if (ddlCategoria.SelectedItem.Text == "Tecnología")
            {
                Response.Redirect("ProductosTecno.aspx");
            }
            if (ddlCategoria.SelectedItem.Text == "Comida")
            {
                Response.Redirect("ProductosComida.aspx");
            }
            if (ddlCategoria.SelectedItem.Text == "Ropa")
            {
                Response.Redirect("ProductosRopa.aspx");
            }
        }
    }
}