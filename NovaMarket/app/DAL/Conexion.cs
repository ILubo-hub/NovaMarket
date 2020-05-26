using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.DAL
{
    public class Conexion
    {
        public static string Cadena
        {
            get
            {
                return @"Data Source = localhost;
                        Initial Catalog= NovaMarketDB   ;
                        User ID = sa;
                        Password = 123456";
            }
        }
    }
}