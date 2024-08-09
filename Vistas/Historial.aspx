<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="Vistas.Historial" %>
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
        .auto-style9 {
            display: inline-block;
/* Ajusta el ancho según sea necesario */max-width: 100%; /* Máximo 100% del contenedor */
            box-sizing: border-box;
            margin: 0 auto 0 0px;
            padding: 0;
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
                </a>&nbsp;
            </nav>
        </header>
        <div class="container">
            <section class="intro">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="HISTORIAL"></asp:Label>
                <br />
                <br />
                Dni:
                <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                Patente:
                <asp:TextBox ID="txtPatente" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Filtrar" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnVerTodos" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Ver Todos" OnClick="btnVerTodos_Click" />
                <br />
                <br />
                <div class="gv-container">
                    <asp:GridView ID="gvHistorial" CssClass="auto-style9" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1200px" AllowPaging="True" AllowSorting="True" HorizontalAlign="Center">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="Dni">
                                <ItemTemplate>
                                    <asp:Label ID="lblDni" runat="server" Text='<%# Eval("Dni_HXS") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nombre">
                                <ItemTemplate>
                                    <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("Nombre_CLI") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Patente">
                                <ItemTemplate>
                                    <asp:Label ID="lblPatente" runat="server" Text='<%# Eval("Patente_Moto_HXS") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Marca">
                                <ItemTemplate>
                                    <asp:Label ID="lblMarca" runat="server" Text='<%# Eval("Marca_M") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Modelo">
                                <ItemTemplate>
                                    <asp:Label ID="lblModelo" runat="server" Text='<%# Eval("Modelo_M") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Servicio Realizado">
                                <ItemTemplate>
                                    <asp:Label ID="lblServicio" runat="server" Text='<%# Eval("Nombre_S") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Detalle">
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Detalle_HXS") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Fecha">
                                <ItemTemplate>
                                    <asp:Label ID="lblDia" runat="server" Text='<%# Eval("Fecha_Realizacion_HXS") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Kilometros">
                                <ItemTemplate>
                                    <asp:Label ID="lblKm" runat="server" Text='<%# Eval("Kilometraje_HXS") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </div>
            </section>
        </div>
    </form>
</body>
</html>
