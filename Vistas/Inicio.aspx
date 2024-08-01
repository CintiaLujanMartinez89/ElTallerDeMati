<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Vistas.Inicio" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>El Taller de Mati</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 578px;
        }
        .auto-style4 {
            text-align: center;
            margin: 20px 0;
            width: 106%;
            height: 314px;
        }
        .auto-style6 {
            font-family: "Trebuchet MS";
            font-weight: normal;
        }
        .auto-style7 {
            font-weight: normal;
        }
        .auto-style8 {
            font-family: "Trebuchet MS", "Lucida Sans Unicode", "Lucida Grande", "Lucida Sans", Arial, sans-serif;
        }
    </style>

     <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/sweetalert2@11/dist/sweetalert2.min.css"/>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <!-- Incluye tu archivo JavaScript compartido -->
    <script src="Scripts/sweetalert.js"></script>
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
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ingresar.aspx">Ingresar</asp:HyperLink>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Registrarse.aspx">Registrarse</asp:HyperLink>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Ingresar.aspx">Solicitar Turno</asp:HyperLink>
                </a>&nbsp;</nav>
        </header>
        <div class="container">
            <section class="intro">
               
                        <div class="PrimerIMG">
                    <img src="Imagenes/imagenInicial.png" alt="ImagenInicial" class="auto-style4" />
                      </div>

              
                <p><span class="auto-style8"><strong>El Taller de Mati</strong>: un nombre en el que puedes confiar</p>
                <p>Servicio rápido, profesional y confiable</p></span>
            </section>
            <section class="services">
                <h2>A tu servicio</h2>
                <h3 class="auto-style7">Reparaciones necesarias para alargar la vida útil de tu moto</h3>
             
                     <div class="PrimerIMG">
                         <table class="auto-style2">
                             <tr>
                                 <td class="auto-style3">
                    <img src="Imagenes/aceite-lubricante-motos-4t.jpg" alt="CambioAceite"/></td>
                                 <td>
                    <h4 class="auto-style7"><strong>Cambio de aceite y filtros (aceite y aire)</strong></h4>
                     
                    <p>El cambio de aceite y filtro en una moto es crucial para mantener su motor en buen estado. Este proceso asegura la
                        lubricación adecuada de las piezas internas, reduce el desgaste y ayuda a disipar el calor generado,
                        manteniendo el motor limpio y libre de residuos. Además, un buen mantenimiento del aceite y del filtro garantiza 
                        un rendimiento eficiente y protege el motor contra daños por partículas abrasivas. Realizar este mantenimiento 
                        regularmente prolonga la vida útil del motor y asegura un funcionamiento óptimo de la moto.</p>
                                 </td>
                             </tr>
                         </table>
&nbsp;</div>
                
                        <div class="PrimerIMG">
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style3">
                    <img src="Imagenes/pastillas-de-freno-de-una-moto.jpeg" alt="ImagenInicial" /></td>
                                    <td>
                    <h4 class="auto-style7"><strong>Regulación de frenos (delanteros y traseros)</strong></h4>
                    <p>Hacer un servicio de regulación de frenos en la moto es esencial para garantizar la seguridad y el rendimiento óptimo
                        de la moto. La regulación adecuada de los frenos asegura que respondan de manera efectiva y uniforme cuando se
                        aplican, evitando frenados bruscos o desiguales que podrían provocar accidentes. Además, un mantenimiento regular de 
                        los frenos ayuda a prolongar la vida útil del sistema de frenos y a prevenir fallas mecánicas que podrían ser costosas
                        de reparar.</p>
                                    </td>
                                </tr>
                            </table>
&nbsp;</div>

                <div class="PrimerIMG">
                    <table class="auto-style2">
                        <tr>
                            <td class="auto-style3">
                    <img src="Imagenes/sistema-embrague-moticletaIMG.jpg" alt="ImagenInicial" /></td>
                            <td>
                    <h4 class="auto-style7"><strong>Regulación de embrague</strong></h4>
                    <p>La regulación del embrague en una moto es esencial para asegurar un funcionamiento suave y eficiente del sistema de transmisión. Las razones principales para realizar este servicio:</p>
<ul>
<li>1. **Mejora de la maniobrabilidad**: Un embrague bien regulado facilita los cambios de marcha, haciendo que sean más suaves y precisos. Esto mejora la experiencia de conducción y evita tirones o cambios bruscos.</li>

<li>2. **Reducción del desgaste**: Si el embrague no está correctamente ajustado, puede provocar un desgaste prematuro tanto en el disco de embrague como en otros componentes del sistema. Regularlo adecuadamente ayuda a prolongar la vida útil de estos elementos.</li>

<li>3. **Prevención de deslizamiento**: Un embrague mal ajustado puede deslizarse, lo que significa que la potencia del motor no se transmite de manera efectiva a la rueda trasera. Esto no solo reduce el rendimiento de la moto, sino que también puede ser peligroso en situaciones donde se necesita una aceleración rápida.</li>

<li>4. **Seguridad**: Un embrague que no funciona correctamente puede hacer que la moto sea impredecible, especialmente al arrancar desde una parada o al cambiar de marcha. Una regulación adecuada garantiza que el embrague se enganche y desenganche de manera consistente y segura.</li>

<li>5. **Optimización del rendimiento**: Un embrague bien ajustado permite que el motor funcione en su rango de potencia óptimo, mejorando la eficiencia del combustible y el rendimiento general de la moto.</li>
                   
                    </ul>
                            </td>
                        </tr>
                    </table>
&nbsp;</div>

            </section>
        </div>
    </form>
</body>
</html>
