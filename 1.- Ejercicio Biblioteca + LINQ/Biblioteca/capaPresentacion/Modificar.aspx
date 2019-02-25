<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="capaPresentacion.Modificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
<table class="style1">
        <tr>
            <td colspan="2">
                Ingresar codigo del libro a modificar</td>
        </tr>
        <tr>
            <td style="width: 202px">
                Codigo</td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                    Text="Buscar Libro" />
            </td>
        </tr>
        <tr>
            <td style="width: 202px">
                Titulo</td>
            <td>
                <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 202px">
                Autor</td>
            <td>
                <asp:TextBox ID="txtAutor" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 202px">
                Editorial</td>
            <td>
                <asp:TextBox ID="txtEditorial" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 202px">
                Año de publicación</td>
            <td>
                <asp:TextBox ID="txtAnnioPublicacion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 202px">
                Precio</td>
            <td>
                <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 202px">
                Está en prestamo</td>
            <td>
                <asp:CheckBox ID="chkPrestamo" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 202px">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnModificar" runat="server" onclick="btnModificar_Click" 
                    Text="Modificar" Width="100px" />
            </td>
        </tr>
    </table>

</asp:Content>
