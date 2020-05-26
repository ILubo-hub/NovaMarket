using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NovaMarket.app.DAL
{
    public class FacturaDAL
    {
        public int GetNextNumeroFactura()
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            int num = 0;
            try
            {
                conexion.Open();
                string sql = @"SELECT NEXT VALUE FOR noSeNova as valor";
                SqlCommand command = new SqlCommand(sql, conexion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    num = Convert.ToInt32(dr["valor"].ToString());
                }

            }
            catch (Exception er)
            {
                
            }
            finally
            {
                conexion.Close();
            }
            return num;
        }

        public void InsertarEncabezado( EncabezadoFactura enc)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            string condicion = "";
            Carrito oCarrito = new Carrito();
            try
            {
                
                    conexion.Open();
                    string sql = "Insert into EncabezadoFactura(NumConsecutivo,NumFactura,IdCliente,NumTarjeta) values(@NumConsecutivo,@NumFactura,@IdCliente,@NumTarjeta)";
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.AddWithValue("@NumConsecutivo", enc.Consecutivo);
                    comando.Parameters.AddWithValue("@NumFactura", enc.NumFactura);
                    comando.Parameters.AddWithValue("@IdCliente", enc.IdCliente);
                    comando.Parameters.AddWithValue("@NumTarjeta", enc.NumTarjeta);
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

        public void InsertarDetalle(DetalleFactura enc)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            string condicion = "";
            Carrito oCarrito = new Carrito();
            try
            {

                conexion.Open();
                string sql = "Insert into DetalleFactura(IDEncFactura,NumLinea,IDProducto) values(@IDEncFactura,@NumLinea,@IDProdcuto)";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@IDEncFactura", enc.IdEncabezado);
                comando.Parameters.AddWithValue("@NumLinea", enc.NumLinea);
                comando.Parameters.AddWithValue("@IDProdcuto", enc.producto);
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