<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fechas.aspx.cs" Inherits="Vistas.Fechas" %>



<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>El Taller de Mati</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 419px;
        }
    </style>
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
                             <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Administrador.aspx">Volver</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblUsuarioLogueado" runat="server" Font-Bold="True" ForeColor="White">USUARIO LOGUEADO</asp:Label>
                 </a>&nbsp;</nav>
        </header>
        <div class="container">
            <section class="intro">
        
             
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="FECHAS DISPONIBLES"></asp:Label>
                <br />
                <br />
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Calendar ID="clTurnosDisponibles" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="230px" Width="339px">
                                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                <WeekendDayStyle BackColor="#CCCCFF" />
                            </asp:Calendar>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="rbHorarios" runat="server">
                            </asp:RadioButtonList>
                        </td>
                        <td>
                            <br />
                            <asp:Label ID="lblMensaje1" runat="server" Font-Bold="True"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <asp:Button ID="btnEliminarFecha" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Eliminar Fecha" />
        
             
            </section>
            
             <section class="intro">
        
             
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="AGREGAR FECHAS"></asp:Label>
        
             
                 <br />
                 <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <br />
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style2">
                            &nbsp;&nbsp;
                            <asp:Calendar ID="clTurnosDisponibles0" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="230px" Width="339px">
                                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                <WeekendDayStyle BackColor="#CCCCFF" />
                            </asp:Calendar>
                        </td>
                        <td>
                            <asp:CheckBoxList ID="ckbHorario" runat="server" RepeatColumns="2">
                                <asp:ListItem Value="08:00">08:00</asp:ListItem>
                                <asp:ListItem Value="09:00">09:00</asp:ListItem>
                                <asp:ListItem Value="10:00">10:00</asp:ListItem>
                                <asp:ListItem>11:00</asp:ListItem>
                                <asp:ListItem>12:00</asp:ListItem>
                                <asp:ListItem>13:00</asp:ListItem>
                                <asp:ListItem>14:00</asp:ListItem>
                                <asp:ListItem>15:00</asp:ListItem>
                                <asp:ListItem>16:00</asp:ListItem>
                                <asp:ListItem>17:00</asp:ListItem>
                                <asp:ListItem>18:00</asp:ListItem>
                                <asp:ListItem>19:00</asp:ListItem>
                            </asp:CheckBoxList>
                        </td>
                        <td>
                            <br />
                            <asp:Label ID="lblMensaje2" runat="server" Font-Bold="True"></asp:Label>
                        </td>
                    </tr>
                </table>
                 <br />
                 <asp:Button ID="btnAgregarFecha" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Agregar Fecha" />
        
             
            </section>
        </div>
    </form>
</body>
</html>
