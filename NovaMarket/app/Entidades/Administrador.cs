﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaMarket.app.Entidades
{
    public class Administrador
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set;}
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}