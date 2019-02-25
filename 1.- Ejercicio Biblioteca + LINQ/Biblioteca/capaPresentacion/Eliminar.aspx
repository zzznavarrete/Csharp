<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="capaPresentacion.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table class="style1">
        <tr>
            <td style="width: 352px">
                Eliminar un Libro</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 352px">
                Codigo del Libro a eliminar</td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server" style="height: 22px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 352px">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" onclick="btnEliminar_Click" 
                    Text="Eliminar Libro" />
            </td>
        </tr>
        <tr>
            <td style="width: 352px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
