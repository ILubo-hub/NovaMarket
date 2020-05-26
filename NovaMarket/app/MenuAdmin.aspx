<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuAdmin.aspx.cs" Inherits="NovaMarket.app.MenuAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <title>Menu Admin</title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link href="css/estilosMenuAdmin.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.4.1/css/all.css" integrity="sha384-5sAR7xN1Nv6T6+dT2mhtzEpVJvfS3NScPQTrOxhwjIuvcA67KV2R5Jz6kr4abQsz" crossorigin="anonymous" />
</head>
<body>
    <div class="wrapper">
        
        <nav id="sidebar">
            <div class="sidebar-header">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <h3>Mantenimientos</h3>
            </div>
            <ul class="list-unstyled components">
                <li>
                    <a href="#homeSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle hover1">Productos<i class="icono fas fa-chevron-down"></i></a>
                    <ul class="collapse list-unstyled" id="homeSubmenu">
                        <li>
                            <a href="ProductosTecno.aspx">Tecnología</a>
                        </li>
                        <li>
                            <a href="ProductosComida.aspx">Comida</a>
                        </li>
                        <li>
                            <a href="ProductosRest.aspx">Restaurante</a>
                        </li>
                        <li>
                            <a href="ProductosRopa.aspx">Ropa</a>
                        </li>
                        <li>
                            <a href="ProductosLlantas.aspx">Llantas</a>
                        </li>
                    </ul>
                    <a href="#pageSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle hover1">Usuarios<i class="icono fas fa-chevron-down"></i></a>
                    <ul class="collapse list-unstyled" id="pageSubmenu">
                        <li>
                            <a href="Administradores.aspx">Administradores</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href="#pageSubmenu2" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">Sucursales<i class="icono fas fa-chevron-down"></i></a>
                    <ul class="collapse list-unstyled" id="pageSubmenu2">
                        <li>
                            <a href="#">Alajuela</a>
                        </li>
                        <li>
                            <a href="#">San José</a>
                        </li>
                        <li>
                            <a href="#">Cartago</a>
                        </li>
                    </ul>
                </li>
                <li>
                    <a href="indexAdmin.aspx">Inicio</a>
                </li>
                <li>
                    <a href="#">Portfolio</a>
                </li>
                <li>
                    <a href="#">Contact</a>
                </li>
            </ul>
        </nav>
        <div id="content">
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                <div class="container-fluid">

                    <button type="button" id="sidebarCollapse" class="btn btn-info">
                        <i class="fas fa-align-left"></i>
                    </button>

                </div>
            </nav>
            <div class="container">
                <img class="imagen align img1" src="images/logo2.0Celeste.png"/>
            </div>

        </div>
    </div>




    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script>
        $(document).ready(function () {

            $('#sidebarCollapse').on('click', function () {
                $('#sidebar').toggleClass('active');
                $('img').toggleClass('align');
            });
            if ($('#sidebar').hasClass('active')) {
                $('img').addClass('align');
                $('img').removeClass('imagen');
            } else {
                $('img').removeClass('align');
                $('img').addClass('imagen');
            }    
        });
    </script>
</body>
</html>
