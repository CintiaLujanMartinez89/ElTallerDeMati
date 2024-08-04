﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="Vistas.Servicios" %>

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
    <style type="text/css">
        .auto-style7 {
            width: 574px;
        }
        .auto-style8 {
            width: 292px;
        }
    </style>
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
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Inicio.aspx">Salir</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Administrador.aspx">Volver</asp:HyperLink>
                &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblUsuarioLogueado" runat="server" Font-Bold="True" ForeColor="White">USUARIO LOGUEADO</asp:Label>
                 </a>&nbsp;</nav>
        </header>
        <div class="container">
 
            
             <section class="intro">
        
             
                 <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="AGREGAR SERVICIO"></asp:Label>
                 <br />
                 <br />
                 <table style="height: 232px">
                     <tr>
                         <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
                <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Identificador de Servicio:"></asp:Label>
                         </td>
                         <td class="auto-style8">
                <asp:TextBox ID="txtId" runat="server" ValidationGroup="g1" TextMode="Number"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Nombre:"></asp:Label>
                         </td>
                         <td class="auto-style8">
                <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="g1"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Descripcion:"></asp:Label>
                         </td>
                         <td class="auto-style8">
                <asp:TextBox ID="txtDescripcion" runat="server" ValidationGroup="g1" TextMode="MultiLine"></asp:TextBox>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Precio:"></asp:Label>
                         </td>
                         <td class="auto-style8">
                <asp:TextBox ID="txtPrecio" runat="server" TextMode="Number" ValidationGroup="g1"></asp:TextBox>
                         </td>
                     </tr>
                 </table>
                 <br />
                 <br />

                 <asp:Button ID="btnAgregar" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Agregar" ValidationGroup="g1" />
                 <br />
                 <br />
        
             
            </section>
        </div>
    </form>
</body>
</html>

