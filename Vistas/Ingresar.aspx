<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingresar.aspx.cs" Inherits="Vistas.Ingresar" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>El Taller de Mati</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
    
     <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/sweetalert2@11/dist/sweetalert2.min.css"/>
     <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <!-- Incluye tu archivo JavaScript compartido -->
    <script src="sweetalert.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="logo">
                <img src="Imagenes/logo.png" alt="Logo"/>
                <h1>El Taller de Mati</h1>
            </div>
            <nav>
                <a href="#">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Inicio.aspx">Inicio</asp:HyperLink>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Registrarse.aspx">Registrarse</asp:HyperLink>
                 </a>&nbsp;</nav>
        </header>
        <div class="container">
            <section class="intro">
        
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="DNI"></asp:Label>
                <br />
                <asp:TextBox ID="txtDni" runat="server" ValidationGroup="g1"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="PASSWORD"></asp:Label>
                <br />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ValidationGroup="g1"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#0033CC" OnClick="Button1_Click" Text="Ingresar" />
        
            </section>
        </div>
    </form>
</body>
</html>

