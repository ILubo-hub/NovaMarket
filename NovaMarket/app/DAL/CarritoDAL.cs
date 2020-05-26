using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NovaMarket.app.DAL
{
    public class CarritoDAL
    {
        /// <summary>
        /// Inserta al carrito el producto seleccionado
        /// </summary>
        /// <param name="pCarrito"></param>
        /// <returns></returns>
        public string InsertarCarrito(Carrito pCarrito)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            string condicion = "";
            Carrito oCarrito = new Carrito();
            try
            {
                oCarrito = GetCarritoByIDandProducto(pCarrito.IDProducto, pCarrito.IdCliente);
                if (oCarrito.IdCliente==null) {
                    conexion.Open();

                    string sql = "Insert into Carrito(IDCliente,IDProducto,Cantidad) values(@IDCliente,@IDProducto,@Cantidad)";
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.AddWithValue("@IDCliente", pCarrito.IdCliente);
                    comando.Parameters.AddWithValue("@IDProducto", pCarrito.IDProducto);
                    comando.Parameters.AddWithValue("@Cantidad", pCarrito.Cantidad);
                    comando.CommandType = System.Data.CommandType.Text;

                    comando.ExecuteNonQuery();
                }else
                {
                    UpdateCarrito(pCarrito);
                }
                    
                
            }
            catch (Exception er)
            {
    
            }
            finally
            {
                conexion.Close();
            }
            return condicion;
        }

        public Carrito GetCarritoByIDandProducto(string ID ,string clien)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            Carrito oCarrito = new Carrito();
            try
            {
                conexion.Open();
                string sql = @"Select * from Carrito where IDProducto=@ID and IDCliente=@Cliente";
                SqlCommand command = new SqlCommand(sql, conexion);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Cliente", clien);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    oCarrito.IDProducto = reader["IDProducto"].ToString();
                    oCarrito.IdCliente = reader["IDCliente"].ToString();
                    oCarrito.Cantidad =Convert.ToInt32(reader["Cantidad"].ToString());
                }
            }
            catch (Exception ec)
            {

            }
            finally
            {
                conexion.Close();
            }
            return oCarrito;
        }
        public void UpdateCarrito(Carrito pCarrito)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            string condicion = "";
            Carrito oCarrito = new Carrito();
            try
            {
                    oCarrito = GetCarritoByIDandProducto(pCarrito.IDProducto,pCarrito.IdCliente);
                    conexion.Open();

                    string sql = "Update Carrito set Cantidad = @cantidad where Idproducto=@IdProducto and IDCliente = @IDClien";
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.AddWithValue("@IDClien", pCarrito.IdCliente);
                    comando.Parameters.AddWithValue("@IdProducto", pCarrito.IDProducto);
                    int cant = pCarrito.Cantidad + oCarrito.Cantidad;
                    comando.Parameters.AddWithValue("@cantidad", cant.ToString());
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.ExecuteNonQuery();
            }

            catch (Exception er)
            {

            }
            finally
            {
                conexion.Close();
            }
            
        }

        public List<Carrito> GetAllCarritoByID(string ID)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            
            List<Carrito> lista = new List<Carrito>();
            try
            {
                conexion.Open();
                string sql = @"Select * from Carrito where IDCliente=@Cliente";
                SqlCommand command = new SqlCommand(sql, conexion);
                command.Parameters.AddWithValue("@Cliente", ID);
           
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Carrito oCarrito = new Carrito();
                    oCarrito.IDProducto = reader["IDProducto"].ToString();
                    oCarrito.IdCliente = reader["IDCliente"].ToString();
                    oCarrito.Cantidad = Convert.ToInt32(reader["Cantidad"].ToString());
                    lista.Add(oCarrito);
                }
            }
            catch (Exception ec)
            {

            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }
        public void DeletedCarrito(string ID, string idclien)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();


                string sql = "Delete from carrito where Idproducto = @ID and IDCliente=@clien";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", ID);
                comando.Parameters.AddWithValue("@clien", idclien);
                comando.CommandType = System.Data.CommandType.Text;

                comando.ExecuteNonQuery();

            }
            catch (Exception er)
            {
             
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}