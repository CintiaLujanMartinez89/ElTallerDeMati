<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fechas.aspx.cs" Inherits="Vistas.Fechas" %>



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
        .auto-style1 {
            width: 99%;
        }
        .auto-style3 {
            width: 627px;
            height: 236px;
        }
        .auto-style4 {
            width: 12px;
        }
        .auto-style5 {
            width: 155px;
        }
        .auto-style6 {
            width: 367px;
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Administrador.aspx">Volver</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblUsuarioLogueado" runat="server" Font-Bold="True" ForeColor="White">USUARIO LOGUEADO</asp:Label>
                 </a>&nbsp;</nav>
        </header>
        <div class="container">
            <section class="intro">
        
             
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="FECHAS DISPONIBLES PARA TURNOS"></asp:Label>
                <br />
                <br />
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style6">
                             <div class="right-align">
                            <asp:Calendar ID="clTurnosDisponibles" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="230px" Width="339px" OnDayRender="clTurnosDisponibles_DayRender" OnSelectionChanged="clTurnosDisponibles_SelectionChanged">
                                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                <WeekendDayStyle BackColor="#CCCCFF" />
                            </asp:Calendar>
                                 </div>
                        </td>
                        <td class="auto-style5" >
                             <div class="left-align">
                            <asp:RadioButtonList ID="rbHorarios" runat="server" ForeColor="Black">
                            </asp:RadioButtonList>
                                 </div>
                        </td>
                        <td>
                            <br />
                            <asp:Label ID="lblMensaje1" runat="server" Font-Bold="True" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <asp:Button ID="btnEliminarFecha" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Eliminar Fecha" OnClick="btnEliminarFecha_Click" />
        
             
            </section>
            
             <section class="intro">
        
             
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="AGREGAR FECHAS"></asp:Label>
        
             
                 <br />
                 <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table class="auto-style3">
                        <tr>
                            <td class="auto-style4">
                                <asp:Label ID="Label5" runat="server" ForeColor="Black" Text="Fecha:"></asp:Label>
                            </td>
                            <td class="center-align">
                                <asp:TextBox ID="txtFecha" runat="server" TextMode="Date" Width="162px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:Label ID="Label3" runat="server" ForeColor="Black" Text="Horas:"></asp:Label>
                            </td>
                            <td class="left-align">
                                <asp:CheckBoxList ID="chkbHoras" runat="server" ForeColor="Black" RepeatColumns="3">
                                    <asp:ListItem>08:00</asp:ListItem>
                                    <asp:ListItem>09:00</asp:ListItem>
                                    <asp:ListItem>10:00</asp:ListItem>
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
                        </tr>
                        <tr>
                            <td colspan="2" class="center-align">
                                &nbsp;</td>
                        </tr>
                    </table>
                 &nbsp;&nbsp;
                 <br />
               
               
                 <br />
                 <asp:Button ID="btnAgregarFecha" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Agregar Fecha" OnClick="btnAgregarFecha_Click" />
        
             
            </section>
        </div>
    </form>
</body>
</html>
