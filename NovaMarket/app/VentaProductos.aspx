<%@ Page EnableEventValidation="false"  Language="C#" AutoEventWireup="true" CodeBehind="VentaProductos.aspx.cs" Inherits="NovaMarket.app.VentaProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <title>NovaMarket</title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/estilosVentas.css" />
    <script src="js/eventos.js"></script>
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
                        <li class="active"><a href="#">Incio</a></li>
                        
                        <li><a href="#">Contacto</a></li>
                        <li><a href="InicioSesion.aspx" icon>Iniciar Sesión</a></li>
                        <form action="" class="navbar-form navbar-right" role="search">
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
    <!--<section class="jumbotron">
        <div class="container">
            <img class="imgJumbotron" src="images/logoDelgado.png" />
        </div>
    </section>-->
    <form runat="server" id="form1" class="container">
        <div class="col-lg-5">
            <asp:Label ID="Label2" runat="server" Text="Categoria"></asp:Label>
            <asp:DropDownList CssClass="form-control" ID="ddlCategoria" runat="server" AppendDataBoundItems="True" OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged"></asp:DropDownList>
            <br/>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscar_Click" />
        </div>
        <div style="float:right">
            <asp:Button ID="btnPagar" class="btn btn-primary" runat="server" Text="Pagar" OnClick="btnPagar_Click" />
        </div>
        <div style="float:left">
        </div>
            <br/>
        <br />
        <br />
        <br/>
        <br />
        <br />
        <br/>
        <br />
        <br />
        <br/>
       
        <div  >
            <legend>Listado de Productos</legend>
        <asp:Repeater ID="rptEvento" runat="server" OnItemCommand="rptEvento_ItemComand">
            <HeaderTemplate>
                <div class="row">
            </HeaderTemplate>
            <ItemTemplate>
                <div class="card border-primary mb-3" style="max-width: 20rem; display: inline-block; margin-right: 2.5%;">
                    <div class="card-header">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Descripcion") %>'></asp:Label>
                    </div>
                    <div class="card-body">
                        <img class="img-responsive" width="200" height="200" src="images\Imagenes Proyecto\<%#Eval("Imagen") %>" />
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="controlBtn" CommandArgument='<%# Eval("ID") %>' >Agregar</asp:LinkButton>
                    </div>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>
     
        </div>
    </form>
    </br>
    </br>
    </br>
    <footer>
        <div class="container-fluid">
            <br />
            
            <p id="footerid">Recuerda iniciar sesión para poder realizar tus compras</p>
            <p id="infofooter">Reporte cualquier error de la página para poder brindar una mejor experiencia</p>
            <p id="infofooter">
                <a href="mailto:jona506@outlook.com" style="color: white">jona506@outlook.com</a>
                <br />
                <a href="mailto:maverrera@gmail.com" style="color: white">maverrera@gmail.com</a>
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
