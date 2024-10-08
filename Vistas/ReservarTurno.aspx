﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservarTurno.aspx.cs" Inherits="Vistas.ReservarTurno" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>El Taller de Mati</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
    
 <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/sweetalert2@11/dist/sweetalert2.min.css"/>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
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
            width: 100%;
        }
        .auto-style9 {
            width: 188px;
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
                <asp:Label ID="lblUsuarioLogueado" runat="server" Font-Bold="True" ForeColor="White">USUARIO LOGUEADO</asp:Label>
                 </a>&nbsp;</nav>
        </header>
        <div class="container">
            <section class="intro">
        
             
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="RESERVAR TURNO"></asp:Label>
                <br />
                <br />
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Calendar ID="clTurnosDisponibles" runat="server" BackColor="White" BorderColor="Black" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" Width="330px" OnDayRender="clTurnosDisponibles_DayRender" OnSelectionChanged="clTurnosDisponibles_SelectionChanged" BorderStyle="Solid" CellSpacing="1" NextPrevFormat="ShortMonth">
                                <DayHeaderStyle ForeColor="#333333" Height="8pt" Font-Bold="True" Font-Size="8pt" />
                                <DayStyle BackColor="#CCCCCC" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="White" Font-Bold="True" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                <TitleStyle BackColor="#333399" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" BorderStyle="Solid" />
                                <TodayDayStyle BackColor="#999999" ForeColor="White" />
                            </asp:Calendar>
                        </td>
                        <td class="auto-style9">
                            <asp:RadioButtonList ID="rbHorarios" runat="server" ForeColor="Black">
                            </asp:RadioButtonList>
                        </td>
                        <td>
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Dni:" Visible="False"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtDni" runat="server" TextMode="Number" Visible="False"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Patente:"></asp:Label>
                            <br />
                            <asp:DropDownList ID="ddlPatentes" runat="server" DataSourceID="SqlDataSource3" DataTextField="Patente_Moto_M" DataValueField="Patente_Moto_M">
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddlPatentes2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Patente_Moto_CXM" DataValueField="Patente_Moto_CXM">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:El_TALLER_DE_MATIConnectionString %>" SelectCommand="SELECT [Patente_Moto_M] FROM [MOTOS] WHERE ([Estado_M] = @Estado_M)">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="true" Name="Estado_M" Type="Boolean" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:El_TALLER_DE_MATIConnectionString %>" SelectCommand="SELECT [Patente_Moto_CXM] FROM [CLIENTES_X_MOTOS] WHERE ([Dni_CXM] = @Dni_CXM)">
                                <SelectParameters>
                                    <asp:SessionParameter Name="Dni_CXM" SessionField="Dni" Type="String" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                            <br />
                            <br />
                            <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Servicio:"></asp:Label>
                            <br />
                            <asp:DropDownList ID="ddlServicios" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre_S" DataValueField="Id_Servicio_S" AppendDataBoundItems="True">
                            <asp:ListItem Text="--Seleccionar--" Value="0"></asp:ListItem>
                                </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:El_TALLER_DE_MATIConnectionString %>" SelectCommand="SELECT [Id_Servicio_S], [Nombre_S] FROM [SERVICIOS]"></asp:SqlDataSource>
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="Ingresar Comentario (EJ: &quot;Deseo llevar el aceite&quot;):"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtComentario" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Reservar" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnVolver" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Volver" OnClick="btnVolver_Click" />
                <br />
        
             
            </section>
            
        </div>
    </form>
</body>
</html>
