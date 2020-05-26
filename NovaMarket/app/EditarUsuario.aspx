<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="NovaMarket.app.EditarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <title>NovaMarket</title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/estilos.css" />
</head>
<body>
    <header>
        <nav class="navbar navbar-inverse navbar-static-top" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navegacion-fm">
                        <span class="sr-only">Desplegar / Oculat Menu</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a href="#" class="onoff navbar-brand">NovaMarket</a>
                </div>
                <!--Inicia Menu-->
                <div class="collapse navbar-collapse" id="navegacion-fm">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="index.aspx">Incio</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button">Productos <span class="caret"></span>
                            </a>
                            <ul class="dropdown-menu" role="menu">
                                <li><a href="#">Tecnologia</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Hogar</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Ropa</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Muebles</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Comida</a></li>
                            </ul>
                        </li>
                        <li><a href="#">Contacto</a></li>
                        <li><a href="InicioSesion.aspx" icon>Iniciar Sesión</a></li>
                        <form class="navbar-form navbar-right" role="search">
                            <div class="form-group">
                                <input type="text" class="form-control" placeholder="buscar" />
                            </div>
                            <!--El type submit es por si se usa php, puede ser que se haga igual con c#-->
                            <button type="submit" class="btnBuscar btn btn-primary">
                                <span class="glyphicon glyphicon-search"></span>
                            </button>
                        </form>
                    </ul>
                    <form action="" class="navbar-form navbar-right" role="search">
                        <div class="form-group">
                            <asp:Label CssClass="admin1" ID="lblNombreUsuario" runat="server" Text="Jonathan Morera Garcia"></asp:Label>
                        </div>
                        <!--El type submit es por si se usa php, puede ser que se haga igual con c#-->
                        <button type="submit" class="btn btn-primary">
                            <span class="glyphicon glyphicon-user"></span>
                        </button>
                    </form>
                </div>
            </div>
        </nav>
    </header>
    <section class="jumbotron">
        <div class="container">
            <!--<h1 class="titulo-blog">Nova Market</h1>-->
            <img class="imgJumbotron" src="images/logoDelgado.png" />
            <!--<p>Tus compras desde la comodidad de tu casa</p>-->
        </div>
    </section>
    <form id="form1" class="container" runat="server">
        <h1 class="tecnotitle" style="margin-bottom: 2%; margin-top: 2%; margin-left: 0%; color: #fff; font-size: 300%; text-align: center; border-color: black; background-color: #3a78ae; border-radius: 9px">Editar Datos</h1>
        <center><h5>Digite los valores que desea cambiar y presione el boton editar</h5></center>
        <div class="row">
            <div class="col-lg-6">
                <div class="form-group">
                    <fieldset>
                        <label class="control-label" for="disabledInput">Nombre</label>
                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" placeholder="Nombre"></asp:TextBox>
                    </fieldset>
                </div>
                <div class="form-group">
                    <fieldset>
                        <label class="control-label" for="readOnlyInput">Apellidos</label>
                        <asp:TextBox ID="txtApellidos" CssClass="form-control" runat="server" placeholder="Apellidos"></asp:TextBox>
                    </fieldset>
                </div>
                <div class="form-group">
                    <fieldset>
                        <label class="control-label" for="disabledInput">Telefono</label>
                        <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server" type="number" placeholder="Número de telefono"></asp:TextBox>
                    </fieldset>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="form-group">
                    <fieldset>
                        <label class="control-label" for="readOnlyInput">Correo</label>
                        <asp:TextBox ID="txtCorreo" CssClass="form-control" runat="server" type="email" placeholder="Correo"></asp:TextBox>
                    </fieldset>
                </div>
                <div class="form-group">
                    <fieldset>
                        <label class="control-label" for="readOnlyInput">Provincia</label>
                        <asp:DropDownList ID="dllProvincias" runat="server" CssClass="form-control" placeholder="Seleccione"></asp:DropDownList>
                    </fieldset>
                </div>
                <div class="form-group">
                    <fieldset>
                        <label class="control-label" for="readOnlyInput">Contraseña</label>
                        <asp:TextBox ID="txtContrasenna" CssClass="form-control" runat="server" type="password"></asp:TextBox>
                    </fieldset>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <div>
                        <fieldset>
                            <asp:Button ID="btnRegistrar" class="btn btn-primary form-control" runat="server" Text="Editar" />
                        </fieldset>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <br />
    <br />
    <footer>
        <div class="container-fluid">
            <br />
            <p id="footerid">Recuerda iniciar sesión para poder realizar tus compras</p>
            <p id="infofooter">Reporte cualquier error de la página para poder brindar una mejor experiencia</p>
            <p id="infofooter">
                <a href="mailto:jona506@outlook.com" style="color: white">jona506@outlook.com</a>
                <br />
                <a href="mailto:maveherrera@gmail.com" style="color: white">maveherrera@gmail.com</a>
                <br />
                <br />
                Copyright © 2018 | NovaMarket
            </p>
        </div>
    </footer>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
