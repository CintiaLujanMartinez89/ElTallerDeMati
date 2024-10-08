﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Vistas.Registrarse" %>


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
     <script>function showAlert(message, icon = 'success') {
            Swal.fire({
                text: message,
                icon: icon,
                showConfirmButton: false,
                timer: 2000,
                timerProgressBar: false
            });
        }</script> <!-- Asegúrate de que la ruta es correcta -->

    <style type="text/css">
        .auto-style2 {
            width: 200px;
        }
        .auto-style3 {
            width: 525px;
            margin-left: 80px;
        }
        .auto-style5 {
            width: 70%;
            margin: 0 auto;
        }
        .auto-style6 {
            width: 525px;
        }
        .auto-style7 {
            height: 395px;
            width: 95%;
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
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Inicio.aspx">Inicio</asp:HyperLink>
                 </a>&nbsp;</nav>
        </header>
        <div class="auto-style5">
            <section class="intro">
        
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="REGISTRARSE"></asp:Label>
                <br />
                <br />
                <table class="auto-style7">
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Dni:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                <asp:TextBox ID="txtDni" runat="server" ValidationGroup="g1" TextMode="Number"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDni" ErrorMessage="*Ingresar Dni" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Nombre:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="g1"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RFVNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="*Ingresar Nombre" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Apellido:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                <asp:TextBox ID="txtApellido" runat="server" ValidationGroup="g1"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RFVApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="*Ingresar Apellido" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Domicilio:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                <asp:TextBox ID="txtDomicilio" runat="server" ValidationGroup="g1"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Telefono:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number" ValidationGroup="g1"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RFVTelefono" runat="server" ControlToValidate="txtTelefono" ErrorMessage="*Ingresar Telefono" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Email:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" ValidationGroup="g1"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RFVEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="*Ingresar Email" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Password:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RFVContraseña" runat="server" ControlToValidate="txtPassword" ErrorMessage="*Ingresar Contraseña" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Repetir Password:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtRepetirPassword" runat="server" TextMode="Password" ValidationGroup="g1"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RFVRepContraseña" runat="server" ControlToValidate="txtRepetirPassword" ErrorMessage="*Repetir Contraseña" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRepetirPassword" ErrorMessage="*Las Contraseñas no coinciden" ForeColor="Red"></asp:CompareValidator>
                        </td>
                    </tr>
                </table>
&nbsp;&nbsp;
                <br />
                <br />
                <asp:Button ID="btnIngresar" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Ingresar" OnClick="btnIngresar_Click" />
        
            </section>
        </div>
    </form>
</body>
</html>

