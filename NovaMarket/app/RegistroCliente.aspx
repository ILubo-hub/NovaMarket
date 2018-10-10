<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="NovaMarket.app.RegistroCliente" %>

<!DOCTYPE html>
<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <title>Registro de Usuario</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/estilosRegistro.css" rel="stylesheet" />
</head>

<body>
    <div class="container formulario">
        <div class="row">
            <div class="col-xs-4 col-xs-offset-4">
                <img src="images/logo.jpg" class="logo center-block" />
            </div>
        </div>
        <div class="espaciado">
        </div>
        <div class="row">
            <fieldset class="col-xs-10 col-xs-offset-1">
                <legend class="hidden-xs">
                    <h3>Registro de Usuario</h3>
                </legend>

                <form class="form-horizontal">

                    <div class="form-group">
                        <label class="col-xs-12" for="id">
                            <h4>Número Cédula</h4>
                        </label>
                        <div class="col-xs-10 col-xs-offset-1">
                            <input type="text" id="id" class="form-control Input" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-xs-12" for="nombre">
                            <h4>Nombre</h4>
                        </label>
                        <div class="col-xs-10 col-xs-offset-1">
                            <input type="text" id="nombre" class="form-control Input" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-xs-12" for="apellidos">
                            <h4>Apellidos</h4>
                        </label>
                        <div class="col-xs-10 col-xs-offset-1">
                            <input type="text" id="apellido" class="form-control Input" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-xs-12" for="telefono">
                            <h4>Telefono</h4>
                        </label>
                        <div class="col-xs-10 col-xs-offset-1">
                            <input type="number" id="telefono" class="form-control Input" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-xs-12" for="provincia">
                            <h4>Provincia</h4>
                        </label>
                        <div class="col-xs-10 col-xs-offset-1">

                            <div class="select" style="color:white">
                                <select>
                                    <option value="alajuela">Alajuela</option>
                                    <option value="sanjose">San Jose</option>
                                    <option value="cartago">Cartago</option>
                                    <option value="heredia">Heredia</option>
                                    <option value="guanacaste">Guanacaste</option>
                                    <option value="limon">Limon</option>
                                    <option value="puntarenas">Puntarenas</option>
                                </select>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-xs-12" for="correo">
                            <h4>Correo Electrónico</h4>
                        </label>
                        <div class="col-xs-10 col-xs-offset-1">
                            <input type="email" id="correo" class="form-control Input" />
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
                        <button type="button" class="btn btn-primary center-block" onclick="redireccion()">Registrarse</button>
                    </div>
                </form>
            </fieldset>
        </div>
    </div>
    <script>
        function redireccion() {
            document.location.href = "index.aspx";
        }
    </script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
