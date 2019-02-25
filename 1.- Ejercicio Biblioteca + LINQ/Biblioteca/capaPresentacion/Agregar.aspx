<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="capaPresentacion.Agregar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table class="style1">
        <tr>
            <td style="width: 202px">
                Codigo</td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnAgregar" runat="server" onclick="btnAgregar_Click" 
                    Text="Agregar Libro" Width="100px" />
            </td>
        </tr>
    </table>
</asp:Content>
