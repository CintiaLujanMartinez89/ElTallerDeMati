<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservarTurno.aspx.cs" Inherits="Vistas.ReservarTurno" %>


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
                        </td>
                        <td class="auto-style9">
                            <asp:RadioButtonList ID="rbHorarios" runat="server">
                            </asp:RadioButtonList>
                        </td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Patente:"></asp:Label>
                            <br />
                            <asp:TextBox ID="txtPatente" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Servicio:"></asp:Label>
                            <br />
                            <asp:DropDownList ID="ddlServicios" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre_S" DataValueField="Id_Servicio_S">
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
                <br />
        
             
            </section>
            
             <section class="intro">
        
             
                 <br />
                 <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <br />
                 <br />
                 <br />
        
             
            </section>
        </div>
    </form>
</body>
</html>
