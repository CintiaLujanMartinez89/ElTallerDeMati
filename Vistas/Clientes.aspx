﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Vistas.Clientes" %>
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
        .auto-style1 {
            display: inline-block;
            margin: 0 auto;
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
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Inicio.aspx">Salir</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblUsuarioLogueado" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
            </nav>
        </header>
        <div class="container">
            <section class="intro">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="MIS MOTOS"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnAgregarMoto" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Agregar Moto" OnClick="btnAgregarMoto_Click" />
                <br />
                <br />
                <div class="gv-container">
                    <asp:GridView ID="gvMisMotos" CssClass="auto-style1" runat="server" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" Height="183px" Width="682px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="Patente">
                                <ItemTemplate>
                                    <asp:Label ID="lblPatente" runat="server" Text='<%# Eval("Patente_Moto_CXM") %>'></asp:Label>
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
                            <asp:TemplateField HeaderText="Ultimo Service realizado">
                                <ItemTemplate>
                                    <asp:Label ID="lblUltService" runat="server" Text='<%# Eval("Nombre_S") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Fecha de Ultimo Service">
                                <ItemTemplate>
                                    <asp:Label ID="lblFechUltService" runat="server" Text='<%# Eval("Fecha_Realizacion_HXS") %>'></asp:Label>
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
            <section class="intro">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" Text="MIS TURNOS"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnSolicitarTurno" runat="server" Font-Bold="True" ForeColor="#0033CC" Text="Solicitar Turno" PostBackUrl="~/ReservarTurno.aspx" />
                <br />
                <br />
                <div class="gv-container">
                    <asp:GridView ID="gvMisTurnos" CssClass="auto-style1" runat="server" AutoGenerateDeleteButton="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="183px" Width="683px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText=" Patente">
                                <ItemTemplate>
                                    <asp:Label ID="lblPatente" runat="server" Text='<%# Eval("Patente_Moto_T") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText=" Marca">
                                <ItemTemplate>
                                    <asp:Label ID="lblMarca" runat="server" Text='<%# Eval("Marca_M") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText=" Modelo">
                                <ItemTemplate>
                                    <asp:Label ID="lblModelo" runat="server" Text='<%# Eval("Modelo_M") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText=" Servicio">
                                <ItemTemplate>
                                    <asp:Label ID="lblServicio" runat="server" Text='<%# Eval("Nombre_S") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText=" Fecha">
                                <ItemTemplate>
                                    <asp:Label ID="lblFecha" runat="server" Text='<%# Eval("Dia_T") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText=" Hora">
                                <ItemTemplate>
                                    <asp:Label ID="lblHora" runat="server" Text='<%# Eval("Hora_T") %>'></asp:Label>
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
                <br />
                <br />
            </section>
        </div>
    </form>
</body>
</html>
