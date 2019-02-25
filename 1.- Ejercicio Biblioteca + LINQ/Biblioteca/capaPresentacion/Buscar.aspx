<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="capaPresentacion.Buscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table class="style1">
        <tr>
            <td style="width: 293px">
                Buscar Libro</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 293px">
                Ingrese el codigo del Libro a buscar</td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 293px">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                    Text="Buscar Libro" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gvListado" runat="server">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
