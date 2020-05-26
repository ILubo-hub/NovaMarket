<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarCarrito.aspx.cs" Inherits="NovaMarket.app.AgregarCarrito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <title>Agregar Producto</title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/estilos.css" />
   
</head>
<body>
   

    <form id="form1" runat="server" >
    <div class="col-lg-6">
        <asp:Label  ID="Label1" runat="server" Text="Producto:"></asp:Label>
        <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <asp:Label runat="server" Text="Tipo:"></asp:Label>
        <asp:TextBox ID="txtTipo" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <asp:Label runat="server" Text="Precio:"></asp:Label>
        <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
        <asp:Image ID="Image1" Height="197px" Width="237px" runat="server"/>
      
        </br>
        <asp:Label runat="server" Text="Cantidad:"></asp:Label>
        <asp:TextBox ID="txtCantidad" TextMode="Number" CssClass="form-control"  runat="server"></asp:TextBox>
        </br>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" class="btn btn-primary" OnClick="btnAgregar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-danger" />
    </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
