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
    public class ClienteDatos
    {
        public string InsertarCliente(Cliente pCliente)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            string condicion = "";
            Cliente aux = null;
            try
            {
                conexion.Open();
                aux = GetClienteByID(pCliente.Cedula);
                if (aux.Cedula == null)
                {
                    string sql = "Insert into Cliente(ID,nombre,Apellidos,Telefono,IDProvincia,Correo,Contrasena) values(@Id,@nombre,@apellidos,@telefono,@IdProvincia,@correo,@contrasena)";
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.AddWithValue("@Id", pCliente.Cedula);
                    comando.Parameters.AddWithValue("@nombre", pCliente.Nombre);
                    comando.Parameters.AddWithValue("@apellidos", pCliente.Apellidos);
                    comando.Parameters.AddWithValue("@telefono", pCliente.Telefono);
                    comando.Parameters.AddWithValue("@correo", pCliente.Correo);
                    comando.Parameters.AddWithValue("@IdProvincia", pCliente.oProvincia.Codigo);
                    comando.Parameters.AddWithValue("@contrasena", pCliente.Contrasena);


                    comando.CommandType = System.Data.CommandType.Text;

                    comando.ExecuteNonQuery();
                    condicion = "Cliente agregado con exito";
                }
                condicion = "Ya se encuentra registrado";
            }
            catch (Exception er)
            {
                condicion = "Cliente no agregado con exito";
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

        public Cliente GetClienteByID(string Id)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

          
            Cliente oCliente = new Cliente();
            try
            {
                conexion.Open();
                string sql = @"select * from Cliente where id = @ID";

                SqlCommand command = new SqlCommand(sql, conexion);
                command.Parameters.AddWithValue("@ID", Id);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                SqlDataReader dr = command.ExecuteReader();
                int pro = 0;
                Provincia provincia = new Provincia();
                while (dr.Read())
                {

                    oCliente.Cedula = dr["ID"].ToString();
                    oCliente.Nombre = dr["Nombre"].ToString();
                    oCliente.Apellidos = dr["Apellidos"].ToString();
                    oCliente.Telefono = dr["Telefono"].ToString();
                    oCliente.Contrasena = dr["Contrasena"].ToString();

                    oCliente.Correo = dr["Correo"].ToString();
                    pro = Convert.ToInt32(dr["Provincia"].ToString());
                    if (pro==1)
                    {
                        provincia.Codigo = 1;
                        provincia.Nombre = "San Jose";
                    }
                    if (pro == 2)
                    {
                        provincia.Codigo = 2;
                        provincia.Nombre = "Alejuela";
                    }
                    if (pro == 3)
                    {
                        provincia.Codigo = 3;
                        provincia.Nombre = "Cartago";
                    }
                    if (pro == 4)
                    {
                        provincia.Codigo = 4;
                        provincia.Nombre = "Heredia";
                    }
                    if (pro == 5)
                    {
                        provincia.Codigo = 5;
                        provincia.Nombre = "Guanacaste";
                    }
                    if (pro == 6)
                    {
                        provincia.Codigo = 6;
                        provincia.Nombre = "Puntarenas";
                    }
                    if (pro == 7)
                    {
                        provincia.Codigo = 7;
                        provincia.Nombre = "Limon";
                    }


                }
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
            return oCliente;
        }
    }
}