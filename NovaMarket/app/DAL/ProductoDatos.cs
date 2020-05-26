using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace NovaMarket.app.DAL
{
    public class ProductoDatos
    {
        public object MessageBox { get; private set; }

        public List<Producto> GetAllProducto()
        {
            List<Producto> lista = new List<Producto>();

            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();

                string sql = @"Select * from Producto";
                SqlCommand command = new SqlCommand(sql, conexion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Producto oProducto = new Producto();
                    oProducto.ID =(reader["ID"].ToString());
                    oProducto.Precio = Convert.ToDouble(reader["Precio"].ToString());
                    oProducto.Descripcion = (reader["Descripcion"].ToString());
                    oProducto.Categoria = (reader["Categoria"].ToString());
                    oProducto.Imagen = reader["Imagen"].ToString();
                    lista.Add(oProducto);

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

        public List<Producto> GetProductoByCategoria(string Cat)
        {
            List<Producto> lista = new List<Producto>();

            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();

                string sql = @"Select * from Producto where ID like '%'+@Cat+'%'";
                SqlCommand command = new SqlCommand(sql, conexion);
                command.CommandText = sql;
                command.Parameters.AddWithValue("@Cat", Cat);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Producto oProducto = new Producto();
                    oProducto.ID = (reader["ID"].ToString());
                    oProducto.Precio = Convert.ToDouble(reader["Precio"].ToString());
                    oProducto.Descripcion = (reader["Descripcion"].ToString());
                    oProducto.Categoria = (reader["Categoria"].ToString());
                    oProducto.Tamano = (reader["Tamaño"].ToString());
                    oProducto.Imagen = reader["Imagen"].ToString();
                    lista.Add(oProducto);

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

        public void InsertarProducto(string ID)
        {

        }
        public Producto GetProductoByID(string ID)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            Producto oProducto = new Producto();
            try
            {
                conexion.Open();
                string sql = @"Select * from Producto where ID=@ID";
                SqlCommand command = new SqlCommand(sql, conexion);
                command.Parameters.AddWithValue("@ID", ID);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    oProducto.ID = (reader["ID"].ToString());
                    oProducto.Precio = Convert.ToDouble(reader["Precio"].ToString());
                    oProducto.Descripcion = (reader["Descripcion"].ToString());
                    oProducto.Categoria = (reader["Categoria"].ToString());
                    oProducto.Tamano = (reader["Tamaño"].ToString());
                    oProducto.Imagen = reader["Imagen"].ToString();
                }
            }
            catch (Exception ec)
            {

            }
            finally
            {
                conexion.Close();
            }
            return oProducto;
        }

        public string InsertarProducto(Producto pProducto)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            string condicion = "";
            Producto aux = null;
            try
            {
                conexion.Open();
                aux = GetProductoByID(pProducto.ID);
                if (aux.ID == null)
                {
                    string sql = "Insert into Producto(ID,Descripcion,Categoria,NumVentas,Precio,Tamaño,Imagen) values(@Id,@Descripcion,@Categoria,@NumVentas,@Pecio,@Tamaño,@Imagen)";
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.AddWithValue("@Id", pProducto.ID);
                    comando.Parameters.AddWithValue("@Descripcion", pProducto.Descripcion);
                    comando.Parameters.AddWithValue("@Categoria", pProducto.Categoria);
                    comando.Parameters.AddWithValue("@NumVentas", pProducto.NumVentas);
                    comando.Parameters.AddWithValue("@Pecio", pProducto.Precio);
                    comando.Parameters.AddWithValue("@Tamaño", pProducto.Tamano);
                    comando.Parameters.AddWithValue("@Imagen", pProducto.Imagen);


                    comando.CommandType = System.Data.CommandType.Text;

                    comando.ExecuteNonQuery();
                    condicion = "Producto agregado con exito";
                }
                condicion = "Ya se encuentra registrado";
            }
            catch (Exception er)
            {
                condicion = "Producto no agregado con exito";
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje    :{0}\n", er.Message);
                msg.AppendFormat("Source     :{0}\n", er.Source);
                msg.AppendFormat("StackTrace :{0}\n", er.StackTrace);
            }
            finally
            {
                conexion.Close();
            }
            return condicion;
        }
        public void EliminarProducto(string id)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();
                
               
                    string sql = "Delete from Producto where ID = @ID";
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.AddWithValue("@ID", id);
                    comando.CommandType = System.Data.CommandType.Text;

                    comando.ExecuteNonQuery();
                   
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje    :{0}\n", er.Message);
                msg.AppendFormat("Source     :{0}\n", er.Source);
                msg.AppendFormat("StackTrace :{0}\n", er.StackTrace);
            }
            finally
            {
                conexion.Close();
            }
        }
        public string UpdateProducto(Producto pProducto)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            string condicion = "";
            Producto aux = null;
            try
            {
                conexion.Open();
                aux = GetProductoByID(pProducto.ID);
                
                    string sql = "Update Producto set ID=@ID, Descripcion=@Descripcion,Categoria=@Categoria,NumVentas=@NumVentas, Precio=@Precio,Tamaño=@Tamaño,Imagen =@Imagen  where ID=@Id";
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.AddWithValue("@Id", pProducto.ID);
                    comando.Parameters.AddWithValue("@Descripcion", pProducto.Descripcion);
                    comando.Parameters.AddWithValue("@Categoria", pProducto.Categoria);
                    comando.Parameters.AddWithValue("@NumVentas", pProducto.NumVentas);
                    comando.Parameters.AddWithValue("@Precio", pProducto.Precio);
                    comando.Parameters.AddWithValue("@Tamaño", pProducto.Tamano);
                    comando.Parameters.AddWithValue("@Imagen", SqlDbType.Image).Value = pProducto.Imagen;


                    comando.CommandType = System.Data.CommandType.Text;

                    comando.ExecuteNonQuery();
                    condicion = "Producto   Modificado con exito";
             
            }
            catch (Exception er)
            {
                condicion = "Producto no agregado con exito";
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje    :{0}\n", er.Message);
                msg.AppendFormat("Source     :{0}\n", er.Source);
                msg.AppendFormat("StackTrace :{0}\n", er.StackTrace);
            }
            finally
            {
                conexion.Close();
            }
            return condicion;
        }

        public string UpdateProductoSinImagen(Producto pProducto)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            string condicion = "";
            Producto aux = null;
            try
            {
                conexion.Open();
                aux = GetProductoByID(pProducto.ID);
              
                    string sql = "Update Producto set  Descripcion=@Descripcion,Categoria=@Categoria,NumVentas=@NumVentas, Precio=@Precio,Tamaño=@Tamano where ID=@ID";
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.AddWithValue("@ID", pProducto.ID);
                    comando.Parameters.AddWithValue("@Descripcion", pProducto.Descripcion);
                    comando.Parameters.AddWithValue("@Categoria", pProducto.Categoria);
                    comando.Parameters.AddWithValue("@NumVentas", pProducto.NumVentas);
                    comando.Parameters.AddWithValue("@Precio", pProducto.Precio);
                    comando.Parameters.AddWithValue("@Tamano", pProducto.Tamano);
                    
                    comando.CommandType = System.Data.CommandType.Text;

                    comando.ExecuteNonQuery();
                    condicion = "Producto   Modificado con exito";
                
            }
            catch (Exception er)
            {
                condicion = "Producto no agregado con exito";
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Mensaje    :{0}\n", er.Message);
                msg.AppendFormat("Source     :{0}\n", er.Source);
                msg.AppendFormat("StackTrace :{0}\n", er.StackTrace);
            }
            finally
            {
                conexion.Close();
            }
            return condicion;
        }
    }
}