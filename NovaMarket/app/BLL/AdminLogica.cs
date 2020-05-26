using NovaMarket.app.DAL;
using NovaMarket.app.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.BLL
{
    public class AdminLogica
    {
        AdminDatos oAdminDatos = new AdminDatos();

        public string InsertarAdmin(Administrador pAdmin)
        {
            string estado = "";
            estado=oAdminDatos.InsertarAdmin(pAdmin);
            return estado;
        }

        public Administrador GetAdminByID(string id)
        {
            Administrador admin = oAdminDatos.GetAdminByID(id);
            return admin;
        }
    }
}