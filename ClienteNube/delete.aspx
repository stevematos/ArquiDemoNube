<%@ Page Title="Borrar Libro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="ClienteNube.delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>.</h2>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Seleccionar"></asp:Label>
        <asp:DropDownList ID="ComboBoxLibros" runat="server" Height="38px" Width="191px">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Seleccionar" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Table ID="TableEjemplares" runat="server" Width="558px" Height="26px">
        <asp:TableRow>
            <asp:TableCell>EjemplarID</asp:TableCell>
            <asp:TableCell>Editora</asp:TableCell>
            <asp:TableCell>Titulo</asp:TableCell>
            <asp:TableCell>Fecha de Publicacion</asp:TableCell>
            <asp:TableCell>Costo</asp:TableCell>
            <asp:TableCell>Precio de venta</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
    <br />
    <asp:Button CssClass="boton_crear" ID="Button2" runat="server" Text="Eliminar" OnClick="Button2_Click" />
</asp:Content>
