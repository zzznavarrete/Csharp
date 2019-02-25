<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="capaPresentacion.Estadisticas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table class="style1">
    <tr>
        <td style="width: 186px">
            Cantidad de libros el año :</td>
        <td style="width: 210px">
            <asp:TextBox ID="txtAnnio" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnCalcular" runat="server" onclick="btnCalcular_Click" 
                Text="Calcular" />
        </td>
        <td>
            <asp:Label ID="lblCantidad" runat="server" Text="---"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 186px">
            Promedio de Precios</td>
        <td style="width: 210px">
            <asp:Label ID="lblPromedio" runat="server" Text="---"></asp:Label>
        </td>
        <td>
            <asp:Button ID="btnPromedio" runat="server" onclick="btnPromedio_Click" 
                Text="Calcular Promedio" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="width: 186px; height: 23px;">
            Libros del autor</td>
        <td style="width: 210px; height: 23px;">
            <asp:TextBox ID="txtLibrosAutor" runat="server"></asp:TextBox>
        </td>
        <td class="style4">
            <asp:Button ID="btnLibrosAutor" runat="server" onclick="btnLibrosAutor_Click" 
                Text="Calcular" />
        </td>
        <td class="style4">
            <asp:Label ID="lblLibrosAutor" runat="server" Text="---"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 186px">
            &nbsp;</td>
        <td style="width: 210px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
