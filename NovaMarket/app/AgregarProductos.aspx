<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarProductos.aspx.cs" Inherits="NovaMarket.app.AgregarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <title>Agregar Productos</title>
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
            <h1 class="tecnotitle" style="margin-bottom: 7%; margin-left: 0%; color: #fff; font-size: 300%; text-align: center; border-color: black; background-color: #3a78ae; border-radius: 9px">Agregar Productos</h1>
            <div class="form-group">
                <fieldset>
                    <label class="control-label" for="disabledInput">Categoría</label>
                    <asp:DropDownList ID="ddlCategoria" class="form-control" runat="server"></asp:DropDownList>
                </fieldset>
            </div>
            <div class="form-group">
                <fieldset>
                    <label class="control-label" for="disabledInput">Codigo</label>
                    <asp:TextBox ID="txtID" CssClass="form-control" runat="server" ></asp:TextBox>
                </fieldset>
            </div>
            <div class="form-group">
                <fieldset>
                    <label class="control-label" for="readOnlyInput">Tamaño</label>
                    <asp:DropDownList ID="dropTamano"  CssClass="form-control" runat="server"></asp:DropDownList>
                </fieldset>
            </div>
            <div class="form-group">
                <fieldset >
                    <label class="control-label" for="disabledInput">Descripcion</label>
                    <asp:TextBox ID="txtDescripcion" CssClass="form-control"  runat="server"></asp:TextBox>
                </fieldset>
            </div>
            <div class="form-group">
                <fieldset>
                    <label class="control-label" for="readOnlyInput">Tipo</label>
                    <asp:DropDownList ID="ddlTipo"  CssClass="form-control" runat="server"></asp:DropDownList>
                </fieldset>
            </div>
            <div class="form-group">
                <fieldset>
                    <label class="control-label" for="readOnlyInput">Precio</label>
                    <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                </fieldset>
            </div>
            <div class="form-group">
                <label for="exampleInputFile">Imagen</label>
                <asp:FileUpload ID="fuploadImagen" accept=".jpg" runat="server" />
                <small id="fileHelp" class="form-text text-muted">Imagen del producto que se va a agregar</small>
            </div>
            <div>
                <asp:Button ID="btnRegistrar" class="btn btn-primary" runat="server" Text="Agregar" OnClick="btnRegistrar_Click" />
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
