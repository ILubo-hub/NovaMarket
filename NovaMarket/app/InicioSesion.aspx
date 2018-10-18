<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="NovaMarket.InicioSesion" %>

<!DOCTYPE html>
<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <title>Inicio de Sesion</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/estilosInicioSesion.css" rel="stylesheet" />
</head>

<body>
    <div class="container formulario">
        <div class="row">
            <div class="col-xs-4 col-xs-offset-4">
                
                <img src="images/carrito_ico.png" class="logo center-block" />
            </div>
        </div>
        <div class="espaciado">
        </div>
        <div class="row">
            <fieldset class="col-xs-10 col-xs-offset-1">
                <legend class="hidden-xs">
                    <h3>Inicio de Sesión</h3>
                </legend>

                <form class="form-horizontal">

                    <div class="form-group">
                        <label class="col-xs-12" for="usuario">
                            <h4>Usuario</h4>
                        </label>
                        <div class="col-xs-10 col-xs-offset-1">
                            <input type="text" id="usuario" class="form-control Input" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-xs-12" for="password">
                            <h4>Contraseña</h4>
                        </label>
                        <div class="col-xs-10 col-xs-offset-1">
                            <input type="password" id="password" class="form-control Input" />
                        </div>
                    </div>

                    <div class="form-group">
                        <button type="button" class="btn btn-primary center-block" onclick="redireccion()">Aceptar</button>
                    </div>
                    <!--Boton que hay que eliminar-->
                    <div class="form-group">
                        <button type="button" class="btn btn-primary center-block" onclick="redireccion2()">Admin</button>
                    </div>

                    <div class="form-group register">
                        <label class="col-xs-12 mini">
                            <br />
                            Si no tienes cuenta
                            <br />
                        </label>
                        <label class="col-xs-12" for="register">Has click <a href="RegistroCliente.aspx">aquí</a> para registrarte</label>
                    </div>
                </form>
            </fieldset>
        </div>
    </div>
    <script>
        function redireccion() {
            document.location.href = "index.aspx";
        }
        function redireccion2() {
            document.location.href = "indexAdmin.aspx";
        }
    </script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
