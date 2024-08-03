<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Vistas.Registrarse" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>El Taller de Mati</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
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
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Nombre:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="g1"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Apellido:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                <asp:TextBox ID="txtApellido" runat="server" ValidationGroup="g1"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
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
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Email:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" ValidationGroup="g1"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Password:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Repetir Password:"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtRepetirPassword" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style6">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
&nbsp;&nbsp;
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Ingresar" />
        
            </section>
        </div>
    </form>
</body>
</html>

