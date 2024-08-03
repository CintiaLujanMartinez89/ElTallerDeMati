<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresarFechas.aspx.cs" Inherits="Vistas.IngresarFechas" %>

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
                <img src="Imagenes/logo.png" alt="Logo"/>
                <h1>El Taller de Mati</h1>
            </div>
            <nav>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Inicio.aspx">Salir</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblUsuarioLogueado" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
            </nav>
        </header>
        <div class="container">
            <section class="intro">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="Agregar Fechas para Turnos"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnAgrega" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Agregar" OnClick="btnAgregarMoto_Click" />
                <br />
                <br />
                <div class="gv-container">
                    <table class="auto-style9">
                        <tr>
                            <td class="right-align">
                                <asp:Label ID="Label2" runat="server" ForeColor="Black" Text="Fecha:"></asp:Label>
                            </td>
                            <td class="left-align">
                                <asp:TextBox ID="txtFecha" runat="server" TextMode="Date"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="right-align">
                                <asp:Label ID="Label3" runat="server" ForeColor="Black" Text="Horas:"></asp:Label>
                            </td>
                            <td class="left-align">
                                <asp:CheckBoxList ID="chkbHoras" runat="server" DataSourceID="SqlDataSource1" DataTextField="Hora_H" DataValueField="Hora_H">
                                </asp:CheckBoxList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:El_TALLER_DE_MATIConnectionString %>" SelectCommand="SELECT [Hora_H] FROM [HORA]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" class="center-align">
                                <asp:Button ID="btnAgregar" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Agregar" OnClick="btnAgregar_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
            </section>
        </div>
    </form>
</body>
</html>
