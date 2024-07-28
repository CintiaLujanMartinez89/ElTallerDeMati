﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Vistas.Administrador" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>El Taller de Mati</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="logo">
                <img src="Imagenes/logo.png" alt="Logo">
                <h1>El Taller de Mati</h1>
            </div>
            <nav>
                <a href="#">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Inicio.aspx">Salir</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblUsuarioLogueado" runat="server" Font-Bold="True" ForeColor="White">USUARIO LOGUEADO</asp:Label>
                 </a>&nbsp;</nav>
        </header>
        <div class="container">
            <section class="intro">
        
             
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="TURNOS ASIGNADOS"></asp:Label>

                 <br />

                 <br />

                 <asp:Button ID="btnAsignarTurno" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Asignar Turno" PostBackUrl="~/ReservarTurno.aspx" />
               
                <br />
                <br />
                <asp:GridView ID="gvTurnosAsignados" runat="server" AutoGenerateDeleteButton="True">
                </asp:GridView>
        
             
            </section>
            
             <section class="intro">
        
             
                 <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="SERVICIOS"></asp:Label>
                 <br />
                 <br />

                 <asp:Button ID="btnAgregarServicio" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Agregar Servicio" />
                 <br />
                 <br />
                 <asp:GridView ID="gvMisTurnos" runat="server" AutoGenerateDeleteButton="True">
                 </asp:GridView>
                 <br />
                 <br />
        
             
            </section>

             <section class="intro">
        
             
                     <asp:Button ID="btnCliXMotos" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="VER CLIENTES Y MOTOS" />
                <br />
                 <br />
                 <asp:Button ID="btnHistorial" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="HISTORIAL" />
               <br />
                 <br />
         <asp:Button ID="btnIngresarFechas" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="INGRESAR FECHAS PARA TURNOS" />
                <br />
                 <br />
             
             
            </section>
        </div>
    </form>
</body>
</html>

