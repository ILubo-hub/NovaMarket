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
    public class AdminDatos
    {
        public string InsertarAdmin(Administrador pAdmin)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            string condicion = "";
            Administrador aux = null;
            try
            {
                conexion.Open();
                aux = GetAdminByID(pAdmin.ID);
                if (aux.ID == null)
                {
                    string sql = "Insert into Cliente(ID,nombre,Apellidos,Telefono,IDProvincia,Correo,Contrasena) values(@Id,@nombre,@apellidos,@telefono,@IdProvincia,@correo,@contrasena)";
                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.AddWithValue("@Id", pAdmin.ID);
                    comando.Parameters.AddWithValue("@nombre", pAdmin.Nombre);
                    comando.Parameters.AddWithValue("@apellidos", pAdmin.Apellidos);
                    comando.Parameters.AddWithValue("@telefono", pAdmin.Telefono);
                    comando.Parameters.AddWithValue("@correo", pAdmin.Correo);
                  
                    comando.Parameters.AddWithValue("@contrasena", pAdmin.Contrasena);


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

        public Administrador GetAdminByID(string Id)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);


            Administrador oAdmin = new Administrador();
            try
            {
                conexion.Open();
                string sql = @"select * from Administrador where id = @ID";

                SqlCommand command = new SqlCommand(sql, conexion);
                command.Parameters.AddWithValue("@ID", Id);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                SqlDataReader dr = command.ExecuteReader();
                int pro = 0;
                Provincia provincia = new Provincia();
                while (dr.Read())
                {

                    oAdmin.ID = dr["ID"].ToString();
                    oAdmin.Nombre = dr["Nombre"].ToString();
                    oAdmin.Apellidos = dr["Apellidos"].ToString();
                    oAdmin.Telefono = dr["Telefono"].ToString();
                    oAdmin.Contrasena = dr["Contrasena"].ToString();

                    oAdmin.Correo = dr["Correo"].ToString();
                  
                   
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
            return oAdmin;
        }


    }
}