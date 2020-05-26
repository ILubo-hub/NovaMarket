<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductosRest.aspx.cs" Inherits="NovaMarket.app.ProductosRest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <title>Restaurante</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/estilosMantenimientos.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
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
                                <a href="#">Administradores</a>
                            </li>
                            <li>
                                <a href="#">Clientes</a>
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

                        <!--<button type="button" id="sidebarCollapse" class="btn btn-info">
                            <i class="fas fa-align-left"></i>
                        </button>-->

                    </div>
                </nav>
            </div>
        </div>
        <section class="products">
            <h1 class="tecnotitle" style="margin-bottom: 7%; margin-left: 0%; color: #fff; font-size: 300%; text-align: center; border-color: black; background-color: #3a78ae; border-radius: 9px">Restaurante</h1>

            <table class="table table-hover">
                <thead>
                    <tr>
                        <th scope="col">Tipo</th>
                        <th scope="col">Código</th>
                        <th scope="col">Precio</th>
                        <th scope="col">Detalle</th>
                        <th scope="col">Acción</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr class="table-active">
                                <th scope="row">
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Categoria").ToString() %>'></asp:Label></th>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("ID").ToString() %>'></asp:Label></td>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Precio").ToString() %>'></asp:Label></td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("Descripcion").ToString() %>'></asp:Label></td>
                                <td>
                                    <asp:Button ID="btnEliminar" class="btn btn-danger" runat="server" Text="Eliminar" />
                                    <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Editar" OnClick="Button1_Click" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <div>
                <asp:Button ID="btnAgregar" class="btn btn-primary" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
            </div>
        </section>
    </form>

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
